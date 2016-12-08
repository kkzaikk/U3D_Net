using UnityEngine;
using System.Collections;
using System.Threading;
using System.IO;
using System.Collections.Generic;
using System;

public class NetWorkManage
{
    private TcpPeer TcpPeerAgent;
    private PacketGate PacketGate;

    private float m_TimeSum = 0.0f;
    public static readonly float NET_TIME_INTERVAL = 40;

    // 过滤消息
    //--4>: 注意服务器一定也要验证
    private int m_FilterType = 0;	// 0: 不过滤, 1: 正过滤  2 : 反过滤
    private HashSet<string> m_FilterMsg;

    public NetWorkManage()
    {
        // 初始化网络
        PacketGate = new PacketGate();
        TcpPeerAgent = new TcpPeer();

        TcpPeerAgent.OnReceivedPacket += new TcpPeer.PacketHandler(PacketGate.ProcessPacket);
    }

    public bool ConnectServer(string strAddr, int nPort)
    {
        if (TcpPeerAgent.ServiceState == ENetServiceState.Running)
        {
            Debug.Log("LogicApp Warning: Tcp PeerAgent is Running, " +
                "if you want to connect to another server, stop current first.");
            return false;
        }
        if (!TcpPeerAgent.StartService(strAddr, nPort))
        {
            Debug.Log("LogicApp Warning: ConnectServer: " + strAddr + ":" + nPort + " Failed!");
            return false;
        }
        return true;
    }

    public void DisconnectServer()
    {
        if (TcpPeerAgent.ServiceState == ENetServiceState.Running)
        {
            TcpPeerAgent.StopService();
        }
    }

    public void SendDataToServer(MessageStruct message)
    {
        doSendData(message);
    }

    private void doSendData(MessageStruct message)
    {
        string fit =  "Msg_" + message.dest + "_" + message.cmd + "_";

        if (1 == m_FilterType && !m_FilterMsg.Contains(fit))
            return;

        if (2 == m_FilterType && m_FilterMsg.Contains(fit))
            return;

        if (null == message.body)
        {
            Debug.Log("[ERROR] Failed to send packet, cmd:{0} msg is null");
            return;
        }

        if (TcpPeerAgent.ServiceState == ENetServiceState.Running)
        {
            if (!TcpPeerAgent.SendPacket(message))
            {
                Debug.Log("[ERROR] Failed to send packet, cmd:{0} size:{1}");
            }
        }
    }

    // 网络层只能发送这些消息
    public void AddFilterMsg(params string[] cmd)
    {
        if (1 != m_FilterType)
        {
            m_FilterType = 1;
            m_FilterMsg.Clear();
        }
        for (int i = 0; i < cmd.Length; i++)
        {
            m_FilterMsg.Add((string)cmd[i]);
        }
    }

    public void RemoveFilterMsg(params string[] cmd)
    {
        if (1 == m_FilterType)
        {
            for (int i = 0; i < cmd.Length; i++)
            {
                m_FilterMsg.Remove((string)cmd[i]);
            }
        }

        if (m_FilterMsg.Count == 0)
            CancelFilter();
    }

    // 网络层除了这些消息, 剩下的都能发送
    public void AddUnFilterMsg(params string[] cmd)
    {
        if (2 != m_FilterType)
        {
            m_FilterType = 2;
            m_FilterMsg.Clear();
        }
        for (int i = 0; i < cmd.Length; i++)
            m_FilterMsg.Add((string)cmd[i]);
    }

    public void RemoveUnFilterMsg(params string[] cmd)
    {
        if (2 == m_FilterType)
        {
            for (int i = 0; i < cmd.Length; i++)
            {
                m_FilterMsg.Remove((string)cmd[i]);
            }
        }
    }

    public void CancelFilter()
    {
        m_FilterType = 0;
        m_FilterMsg.Clear();
    }

    public void Breathe()
    {
        m_TimeSum += Time.time;
        //if (m_TimeSum >= NET_TIME_INTERVAL)
        {
            m_TimeSum = 0.0f;
            TcpPeerAgent.Breath();
        }
    }

    //获取服务器时间
    public long GetServeTime()
    {
        return TcpPeerAgent.STime;
    }

}
