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
    private Queue<messageStruct> recDataQueue = new Queue<messageStruct>();
    //场景上频繁收到的协议处理，避免阻塞其它协议数据的读取
    private Queue<messageStruct> recDataScene = new Queue<messageStruct>();

    private messageStruct pbnoCurr = new messageStruct();
    private string host="";
    private int port=0;
    private static List<messageStruct> sendMemory = new List<messageStruct>();

    
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
                ReceDataStruct receData = new ReceDataStruct();
                receData.data = data;
                receData.datalen = datalen;

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

    public messageStruct getOftenData(ref int dest, ref int cmd)
    {
        if (recDataScene.Count <= 0) return null;

        messageStruct _msg = recDataScene.Dequeue();
        dest = _msg.dest;
        cmd = _msg.cmd;

        return _msg;
    }

    //获取当前传过来的协议信息
    public messageStruct getCurrMsg(int dest, int cmd)
    {
        if (pbnoCurr.body == null)
        {
            return null;
        }
        if (pbnoCurr.cmd == cmd && pbnoCurr.dest == dest && pbnoCurr.body != null)
        {
            return pbnoCurr;
        }
        return null;
    }

    //清除数据
    private void clearDataQueue()
    {
        recDataQueue.Clear();
    }

    //判断是否场景上频繁接受到的协议
    public bool IsOftenData(int dest, int cmd)
    {
        if (dest == 7)
        {
            if (cmd == 4 || cmd == 5 || cmd == 6 || cmd == 7 || cmd == 8 || cmd == 11) return true;
        }
        return false;
    }

    public static void SendData(SendDataStruct data)
    {
        IProtocolFactory factory = new ProtocolFactory();
        factory.createProtocolType1().SerializeData(data);
    }

    //获取消息队列第一个数据
    public void getCMsg(ref int dest, ref int cmd)
    {
        //发送消息
        pbnoCurr.setNull();

        //PBNO _msg=new PBNO(); 每一帧都new一个 也许会影响效率
        if (recDataQueue.Count > 0)
        {
            messageStruct _msg = recDataQueue.Dequeue();
            dest = _msg.dest;
            cmd = _msg.cmd;
            STime = _msg.serverTime;

            pbnoCurr.cmd = _msg.cmd;
            pbnoCurr.dest = _msg.dest;
            pbnoCurr.serverTime = _msg.serverTime;
            pbnoCurr.body = _msg.body;

            _msg.setNull();
        }
    }

    private void SendBySocket()
    {
        int count = sendMemory.Count;
        if (count == 0) return;

        messageStruct smsg = sendMemory[0];

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
        IProtocolFactory factory = new ProtocolFactory();
        factory.createProtocolType1().DeserializeData(data);
    }

    /// <summary>
    /// jf add
    /// </summary>
    /// <param name="_pb"></param>
    public void PushReceDataScene(messageStruct _pb)
    {
        recDataScene.Enqueue(_pb);
    }
    public void PushReceDataQueue(messageStruct _pb)
    {
        recDataQueue.Enqueue(_pb);
    }
    public void PushSendDataQueue(messageStruct smsg)
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
