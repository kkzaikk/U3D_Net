using UnityEngine;
using System.Collections;
using com.protobuf;
using System.Threading;
using System.IO;
using System.Collections.Generic;
using System;

//协议号
public struct PBNO
{
    public CMsg msg;
    public global::ProtoBuf.IExtensible pbInstance;
    public void setNull()
    {
        msg = null;
        pbInstance = null;
    }
}

//存发送的消息
public struct SendPBMsg
{
    public int dest;
    public int cmd;
    public byte[] sendBody;
}

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
    private Thread thread = null;
    //end////////////////////////////////////////////////////////////////////

    private SocketConnect _socketCon = null;

    //收到的协议队列
    private Queue<PBNO> recDataQueue = new Queue<PBNO>();
    //场景上频繁收到的协议处理，避免阻塞其它协议数据的读取
    private Queue<PBNO> recDataScene = new Queue<PBNO>();

    private PBNO pbnoCurr = new PBNO();
    private string host="";
    private int port=0;
    private static List<SendPBMsg> sendMemory = new List<SendPBMsg>();

    
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
            Send();

            if (_socketCon.isSocketNull() == null) continue;

            //接收协议
            byte[] data = null;
            int datalen = 0;
            if (_socketCon.Rece(ref data, ref datalen))
            {
                ParseData(new MemoryStream(data, 0, datalen));
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

    public global::ProtoBuf.IExtensible getOftenData(ref int dest, ref int cmd)
    {
        if (recDataScene.Count <= 0) return null;
        PBNO _msg = recDataScene.Dequeue();
        dest = _msg.msg.dest;
        cmd = _msg.msg.cmd;
        return _msg.pbInstance;
    }

    //获取当前传过来的协议信息
    public T getCurrMsg<T>(int dest, int cmd) where T : global::ProtoBuf.IExtensible
    {
        global::ProtoBuf.IExtensible pbInstance = null;
        if (pbnoCurr.pbInstance == null)
        {
            return (T)pbInstance;
        }
        if (pbnoCurr.msg.cmd == cmd && pbnoCurr.msg.dest == dest && pbnoCurr.pbInstance != null)
        {
            return (T)pbnoCurr.pbInstance;
        }
        return (T)pbInstance;
    }

    //清除数据
    private void clearDataQueue()
    {
        recDataQueue.Clear();
    }

    //判断是否场景上频繁接受到的协议
    private bool IsOftenData(int dest, int cmd)
    {
        if (dest == 7)
        {
            if (cmd == 4 || cmd == 5 || cmd == 6 || cmd == 7 || cmd == 8 || cmd == 11) return true;
        }
        return false;
    }


    //发送协议数据到服务器
    public static void SendData<T>(int dest, int cmd, T instance) where T : global::ProtoBuf.IExtensible
    {
#if UNITY_EDITOR
        Debug.Log("要发送协议：dest=" + dest + ",cmd=" + cmd);
#endif
        byte[] body = PBParseManage.getSerialize<T>(instance);
        CMsg _nnn = new CMsg();
        _nnn.dest = dest;
        _nnn.cmd = cmd;
        if (body != null && body.Length > 0)
        {
            _nnn.body = body;
        }

        //放在消息队列里面发
        SendPBMsg smsg = new SendPBMsg();
        smsg.dest = dest;
        smsg.cmd = cmd;
        smsg.sendBody = PBParseManage.getSerialize<CMsg>(_nnn);

        sendMemory.Add(smsg);
    }


    //发送协议数据到服务器 只传协议号，没有内容
    public static void SendData(int dest, int cmd)
    {
#if UNITY_EDITOR
        Debug.Log("要发送协议：dest=" + dest + ",cmd=" + cmd);
#endif
        SendPBMsg smsg = new SendPBMsg();
        smsg.dest = dest;
        smsg.cmd = cmd;
        CMsg _nnn = new CMsg();
        _nnn.dest = dest;
        _nnn.cmd = cmd;
        smsg.sendBody = PBParseManage.getSerialize<CMsg>(_nnn);

        sendMemory.Add(smsg);
    }

    //获取消息队列第一个数据
    public void getCMsg(ref int dest, ref int cmd)
    {
        //发送消息
        pbnoCurr.setNull();

        //PBNO _msg=new PBNO(); 每一帧都new一个 也许会影响效率
        if (recDataQueue.Count > 0)
        {
            PBNO _msg = recDataQueue.Dequeue();
            dest = _msg.msg.dest;
            cmd = _msg.msg.cmd;

            STime = _msg.msg.serverTime;

            pbnoCurr.msg = _msg.msg;
            pbnoCurr.pbInstance = _msg.pbInstance;
            _msg.setNull();
        }
    }

    private void Send()
    {
        int count = sendMemory.Count;
        if (count == 0) return;

        SendPBMsg smsg = sendMemory[0];

        if (_socketCon == null)
        {
            Connect();
        }

        if (_socketCon.Send(smsg.sendBody))
        {
            Debug.Log("发送消息 dest=" + smsg.dest + ",cmd=" + smsg.cmd + " 成功 !");
            sendMemory.RemoveAt(0);
        }

    }

    //解析协议信息
    private void ParseData(Stream source)
    {
        CMsg cmsg = ProtoBuf.Serializer.Deserialize<CMsg>(source);
        int cmd = cmsg.cmd;
        int dest = cmsg.dest;
        long serverTime = cmsg.serverTime;
        byte[] body = cmsg.body;
        //消息号保存进队列
        PBNO _pb = new PBNO();
        _pb.msg = cmsg;
        _pb.pbInstance = null;

        //分发协议去解析
        _pb.pbInstance = PBParseManage.getInstance().ParseData(dest, cmd, body);

        if (IsOftenData(dest, cmd))
        {
            recDataScene.Enqueue(_pb);
        }
        else
        {
            recDataQueue.Enqueue(_pb);
        }

        Debug.Log("收到消息 dest=" + dest + ",cmd=" + cmd);
    }

    public void PushDataQueue(PBNO _pb)
    {
        recDataQueue.Enqueue(_pb);
    }

    public void PushDataScene(PBNO _pb)
    {
        recDataScene.Enqueue(_pb);
    }

    public bool isConnect()
    {
        return _socketCon != null;
    }
}
