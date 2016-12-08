using UnityEngine;
using System.Collections;
using System.IO;
using com.protobuf;


//通讯消息结构(根据后端的CMsg定义)
public class messageStruct
{
    public int dest;
    public int cmd;
    public byte[] body;
    public long serverTime;

    public void setNull()
    {
        dest = 0;
        cmd = 0;
        serverTime = 0;
        body = null;
    }
}

class ProtocolType1 : IProtocolType1
{
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
        messageStruct smsg = new messageStruct();
        smsg.dest = data.dest;
        smsg.cmd = data.cmd;
        smsg.body = PBParseManage.getSerialize<CMsg>(_nnn);

        NetWorkManage.getInstance().PushSendDataQueue(smsg);
    }

    public void DeserializeData(ReceDataStruct source)
    {
        if (source == null) return;

        Stream stream = new MemoryStream(source.data, 0, source.datalen);

        CMsg cmsg = ProtoBuf.Serializer.Deserialize<CMsg>(stream);
        int cmd = cmsg.cmd;
        int dest = cmsg.dest;
        long serverTime = cmsg.serverTime;
        byte[] body = cmsg.body;

        //消息号保存进队列
        messageStruct _pb = new messageStruct();
        _pb.cmd = cmsg.cmd;
        _pb.dest = cmsg.cmd;
        _pb.body = cmsg.body;
        _pb.serverTime = cmsg.serverTime;

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

    }

}
