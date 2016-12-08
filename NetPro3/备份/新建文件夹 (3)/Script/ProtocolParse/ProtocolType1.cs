using UnityEngine;
using System.Collections;
using System.IO;
using com.protobuf;


//通讯消息结构(根据后端的CMsg定义)
public struct messageStruct
{
    public int dest;
    public int cmd;
    public byte[] body;
    public long serverTime;
}

class ProtocolType1 : IProtocolType1
{
    //public object SerializeData(int dest, int cmd,object instance)
    //{
    //    Debug.Log("SerializeData");

    //    MemoryStream memStream = new MemoryStream();
    //    ProtoBuf.Serializer.Serialize(memStream, instance);

    //    byte[] body = memStream.ToArray();
    //    CMsg _nnn = new CMsg();
    //    _nnn.dest = dest;
    //    _nnn.cmd = cmd;
    //    if (body != null && body.Length > 0)
    //    {
    //        _nnn.body = body;
    //    }

    //    //放在消息队列里面发
    //    SendPBMsg smsg = new SendPBMsg();
    //    smsg.dest = dest;
    //    smsg.cmd = cmd;
    //    smsg.sendBody = PBParseManage.getSerialize<CMsg>(_nnn);

    //    NetWorkManage.getInstance().PushSendDataQueue(smsg);

    //    return null;

    //}

    public void SerializeData(SendDataStruct data)
    {
        MemoryStream memStream = new MemoryStream();
        ProtoBuf.Serializer.Serialize(memStream, data.instance);

        byte[] body = memStream.ToArray();
        CMsg _nnn = new CMsg();
        _nnn.dest = data.dest;
        _nnn.cmd = data.cmd;
        if (body != null && body.Length > 0)
        {
            _nnn.body = body;
        }

        //放在消息队列里面发
        SendPBMsg smsg = new SendPBMsg();
        smsg.dest = data.dest;
        smsg.cmd = data.cmd;
        smsg.sendBody = PBParseManage.getSerialize<CMsg>(_nnn);

        NetWorkManage.getInstance().PushSendDataQueue(smsg);
    }

    public object DeserializeData(object source)
    {
        Debug.Log("DeserializeData");

        if (source == null) return null;

        Stream stream = (Stream)source;

        CMsg cmsg = ProtoBuf.Serializer.Deserialize<CMsg>(stream);
        int cmd = cmsg.cmd;
        int dest = cmsg.dest;
        long serverTime = cmsg.serverTime;
        byte[] body = cmsg.body;


        //消息号保存进队列
        PBNO _pb = new PBNO();
        _pb.msg = cmsg;

        //分发协议去解析
        PBParseManage.getInstance().ParseData(dest, cmd, body);

        if (NetWorkManage.getInstance().IsOftenData(dest, cmd))
        {
            NetWorkManage.getInstance().PushReceDataScene(_pb);
        }
        else
        {
            NetWorkManage.getInstance().PushReceDataQueue(_pb);
        }

        Debug.Log("收到消息 dest=" + dest + ",cmd=" + cmd);

        return null;
    }

}
