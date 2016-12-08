using UnityEngine;
using System.Collections;
using System.Threading;
using System.IO;
using System.Collections.Generic;
using System;

public class NetWorkManage
{
    private static NetWorkManage s_NetWorkManage = null;
    public static NetWorkManage getInstance()
    {
        if (s_NetWorkManage == null)
        {
            s_NetWorkManage = new NetWorkManage();
        }
        return s_NetWorkManage;
    }

    //20140912 add ///////////////////////////////////////////////////////////
    
    //网络线程
    private Thread thread = null;

    //end////////////////////////////////////////////////////////////////////


    private SocketConnect _socketCon = null;

    private string host="";
    private int port=0;
    

    
    //jf add 2150721 (原来是放在GDDirector类里)//////////////////////////////////////////////////////
    //连接过网络
    private bool acceptNet = false;
    public void setAcceptNet(bool accept)
    {
        acceptNet = accept;
    }
    public bool getAcceptNet()
    {
        return acceptNet;
    }

    //网络连接状态 0普通，1已连接，2断开
    private int netStatus = 0;
    public void setNetStatus(int _status)
    {
        netStatus = _status;
    }
    public int getNetStatus()
    {
        return netStatus;
    }

    //服务器时间戳(原来是放在GDDataTime类里)
    private long sTime = 0;
    private float gameTime = Time.time;
    public long STime
    {
        set
        {
            long vv = value;
            if (vv > 0)
            {
                sTime = vv;
                gameTime = Time.time;
            }
        }
        get
        {
            if (sTime == 0)
            {
                TimeSpan ts = DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0, 0);
                sTime = (long)ts.TotalMilliseconds;
            }
            long rett = sTime + (long)((Time.time - gameTime) * 1000);
            return rett;
        }
    }
    
    //end/////////////////////////////////////////////////////////////////////////////////////////

    //保存ip地址与端口
    public void setHostPort(string host, int port)
	{
        this.host = host;
        this.port = port;
	}

    //连接服务器
    public bool Connect()
    {
        acceptNet = true;

        Close();
        _socketCon = new SocketConnect(host, port);
        
        if (_socketCon.Open())
        {
            Debug.Log("连接服务器成功！");

            //20150912 add////////////////////////////////////////
            thread = new Thread(new ThreadStart(CheckReceive));
            thread.Start();
            //end////////////////////////////////////////////////


            return true;
        }
        Debug.LogError("连接服务器失败！");
        return false;
    }

    private void CheckReceive()
    {
        while (true)
        {
            if (_socketCon.isSocketNull() == null) break;

            //发送协议。需要发协议单独开个线程？？？？？
            SendBySocket();

            if (_socketCon.isSocketNull() == null) continue;

            //接收协议
            byte[] data = null;
            int datalen = 0;
            if (_socketCon.Rece(ref data, ref datalen))
            {
                ReceDataStruct receData = new ReceDataStruct(data, datalen);

                //解析协议
                CurrProtocolManage.getInstance().DeserializeData(receData);
            }

            Thread.Sleep(50);
        }
    }

    //关闭连接
    public void Close()
    {
        setNetStatus(2);

        if (_socketCon != null)
        {
            _socketCon.Close();
            _socketCon = null;
        }

        SendreceiveManage.getInstance().clear();
    }

    //发送数据给服务端
    public static void SendData(SendDataStruct data)
    {
        CurrProtocolManage.getInstance().SerializeData(data);
    }

    //获取消息队列第一个数据
    public MessageStruct getCMsg()
    {
        MessageStruct message = SendreceiveManage.getInstance().getYetReceData();

        return message;
    }

    private void SendBySocket()
    {
        //从消息队列中取一条消息数据
        MessageStruct message = SendreceiveManage.getInstance().getWillSendData();

        if (message != null && _socketCon.Send(message.body))
        {
            Debug.Log("发送消息 dest=" + message.dest + ",cmd=" + message.cmd + " 成功 !");
        }

    }

    public bool isConnect()
    {
        return _socketCon != null;
    }
}
