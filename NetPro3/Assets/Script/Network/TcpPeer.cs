using UnityEngine;
using System.Collections;
using System.Threading;
using System.IO;
using System.Collections.Generic;
using System;

public enum ENetServiceState
{
    Stop = 0,
    Running = 1
}

public class TcpPeer
{
    public delegate void PacketHandler(MessageStruct message);
    public event PacketHandler OnReceivedPacket;

    //网络线程
    private Thread thread = null;

    private SocketConnect _socketCon = null;

    private string host="";
    private int port=0;
    
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

    //网络连接状态
    private ENetServiceState serviceState;
    public ENetServiceState ServiceState
    {
        get
        {
            return serviceState;
        }
        set
        {
            serviceState = value;
        }
    }

    public bool StartService(string addr, int port)
    {
        setHostPort(addr, port);

        return Connect();
    }

    public bool StopService()
    {
        serviceState = ENetServiceState.Stop;

        if (_socketCon != null)
        {
            _socketCon.Close();
            _socketCon = null;
        }

        return true;
    }

    //保存ip地址与端口
    private void setHostPort(string host, int port)
	{
        this.host = host;
        this.port = port;
	}

    //连接服务器
    private bool Connect()
    {
        acceptNet = true;

        StopService();

        _socketCon = new SocketConnect(host, port);
        
        if (_socketCon.Open())
        {
            Debug.Log("连接服务器成功！");
                
            serviceState = ENetServiceState.Running;

            thread = new Thread(new ThreadStart(CheckReceive));
            thread.Start();

            return true;
        }
        Debug.LogError("连接服务器失败！");
        return false;
    }

    //服务器时间戳
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

    private void CheckReceive()
    {
        while (true)
        {
            if (_socketCon.isSocketNull()) break;

            //接收协议
            byte[] data = null;
            int datalen = 0;
            if (_socketCon.Rece(ref data, ref datalen))
            {
                MessageStruct message = MessageStruct.DeserializeData(data, datalen);

                sTime = message.serverTime;

                //分发协议
                if (OnReceivedPacket != null)
                { 
                    OnReceivedPacket(message);
                }
            }

            Thread.Sleep(50);
        }
    }

    public bool isConnect()
    {
        return _socketCon != null;
    }

    public bool SendPacket(int dest, int cmd, byte[] data)
    {
        if (_socketCon.isSocketNull())
        {
            return false;
        }

        if (data != null && _socketCon.Send(data))
        {
            Debug.Log("发送消息 dest=" + dest + ",cmd=" + cmd + " 成功 !");
        }

        return true;
    }
    public bool SendPacket(MessageStruct message)
    {
        if (_socketCon.isSocketNull())
        {
            return false;
        }

        if (message != null && _socketCon.Send(message.body))
        {
            Debug.Log("发送消息 dest=" + message.dest + ",cmd=" + message.cmd + " 成功 !");
        }

        return true;
    }

    public void Breath()
    {

    }

}
