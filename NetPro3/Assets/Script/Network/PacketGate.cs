using UnityEngine;
using System.Collections;

public class PacketGate
{
    public delegate void PacketProcessFuc(MessageStruct message);

    Hashtable m_ProcessMethod;

    public PacketGate()
    {
        m_ProcessMethod = new Hashtable();

        Register("Msg_2_1_", Msg_2_1_);
        Register("Msg_2_2_", Msg_2_2_);
        Register("Msg_2_3_", Msg_2_3_);
        Register("Msg_2_6_", Msg_2_6_);
        Register("Msg_3_3_", Msg_3_3_);
        Register("Msg_4_1_", Msg_4_1_);
        Register("Msg_100_1_", Msg_100_1_);
        Register("Msg_6_1_", Msg_6_1_);

    }

    public void ProcessPacket(MessageStruct packet)
    {
        if (m_ProcessMethod.Contains(packet.getHeadCommand()) == false)
        {
            //--4>: 不用 LogLeve.ERROR, 客户端没处理的一些包先不用管
            Debug.Log("[ERROR] PacketGate.ProcessPacket: Attempt to packet with commad: ");
            return;
        }
        PacketProcessFuc fun = m_ProcessMethod[packet.getHeadCommand()] as PacketProcessFuc;
        if (fun != null)
        {
            fun(packet);
        }
    }

    private void Register(string cmd, PacketProcessFuc method)
    {
        if (m_ProcessMethod.Contains(cmd))
        {
            Debug.Log("[WARN] PacketGate.Register failed, cmd: " + cmd);
            return;
        }
        m_ProcessMethod.Add(cmd, method);
    }

    private void Msg_2_1_(MessageStruct message)
    {
        Debug.Log("协议2——1-");
    }

    private void Msg_2_2_(MessageStruct message)
    {
        Debug.Log("协议2——2-");
    }

    private void Msg_2_3_(MessageStruct message)
    {
        Debug.Log("协议2——3-");
    }

    private void Msg_2_6_(MessageStruct message)
    {
        Debug.Log("协议2——6-");
    }

    private void Msg_3_3_(MessageStruct message)
    {
        Debug.Log("协议3——3-");
    }

    private void Msg_100_1_(MessageStruct message)
    {
        Debug.Log("协议100——1");
    }

    private void Msg_6_1_(MessageStruct message)
    {
        Debug.Log("协议6——1-");
    }

    private void Msg_4_1_(MessageStruct message)
    {
        Debug.Log("协议4——1-");
    }



}
