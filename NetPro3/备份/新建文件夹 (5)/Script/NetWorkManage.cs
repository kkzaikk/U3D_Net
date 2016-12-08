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

    //收到的协议队列
    private Queue<MessageStruct> recDataQueue = new Queue<MessageStruct>();
    //场景上频繁收到的协议处理，避免阻塞其它协议数据的读取
    private Queue<MessageStruct> recDataScene = new Queue<MessageStruct>();

    private MessageStruct pbnoCurr = new MessageStruct();
    private string host="";
    private int port=0;
    private static List<MessageStruct> sendMemory = new List<MessageStruct>();

    
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

    //网络响应已处理（原来在GD.cs文件）
    public const int NETACCEPTED = -100000;
    
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

                ParseData(receData);
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

        recDataQueue.Clear();
        sendMemory.Clear();
        pbnoCurr.setNull();
    }

    public void ClearDataScene()
    {
        recDataScene.Clear();
    }

    //清除数据
    private void clearDataQueue()
    {
        recDataQueue.Clear();
    }

    public static void SendData(SendDataStruct data)
    {
        IProtocolFactory factory = new ProtocolFactory();
        factory.createProtocolType1().SerializeData(data);
        //GDDirector.getInstance().getCurrentFactory().createProtocolType1().SerializeData(data);
    }

    //获取消息队列第一个数据
    public MessageStruct getCMsg()
    {
        //发送消息
        pbnoCurr.setNull();

        MessageStruct _msg = new MessageStruct();
        //网络 是否有消息过来
        _msg.dest = NetWorkManage.NETACCEPTED;


        //PBNO _msg=new PBNO(); 每一帧都new一个 也许会影响效率
        if (recDataQueue.Count > 0)
        {
            _msg = recDataQueue.Dequeue();

            //服务器时间
            //STime = _msg.serverTime;

            pbnoCurr.CloneMessage(_msg);

            return _msg;
        }

        return _msg;
    }

    private void SendBySocket()
    {
        int count = sendMemory.Count;
        if (count == 0) return;

        MessageStruct smsg = sendMemory[0];

        if (_socketCon == null)
        {
            Connect();
        }

        if (_socketCon.Send(smsg.body))
        {
            Debug.Log("发送消息 dest=" + smsg.dest + ",cmd=" + smsg.cmd + " 成功 !");
            sendMemory.RemoveAt(0);
        }

    }

    //解析协议信息
    private void ParseData(ReceDataStruct data)
    {
        //GDDirector.getInstance().getCurrentFactory().createProtocolType1().DeserializeData(data);
        IProtocolFactory factory = new ProtocolFactory();
        factory.createProtocolType1().DeserializeData(data);
    }

    /// <summary>
    /// jf add
    /// </summary>
    /// <param name="_pb"></param>
    public void PushReceDataScene(MessageStruct _pb)
    {
        recDataScene.Enqueue(_pb);
    }
    public void PushReceDataQueue(MessageStruct _pb)
    {
        recDataQueue.Enqueue(_pb);
    }
    public void PushSendDataQueue(MessageStruct smsg)
    {
        sendMemory.Add(smsg);
    }
    /// <summary>
    /// end
    /// </summary>
    /// <returns></returns>
    /// 

    public bool isConnect()
    {
        return _socketCon != null;
    }
}
