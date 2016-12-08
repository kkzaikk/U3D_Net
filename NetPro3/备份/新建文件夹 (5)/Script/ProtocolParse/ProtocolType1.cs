using UnityEngine;
using System.Collections;
using System.IO;
using com.protobuf;


//通讯消息结构(根据后端的CMsg定义)
public class MessageStruct
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

    public void CloneMessage(MessageStruct clone)
    {
        dest = clone.dest;
        cmd = clone.cmd;
        serverTime = clone.serverTime;
        body = clone.body;
    }

}

class ProtocolType1 : IProtocolType1
{
    public void SerializeData(SendDataStruct data)
    {
        MemoryStream memStream = new MemoryStream();
        ProtoBuf.Serializer.Serialize(memStream, data.instance);

        byte[] body = memStream.ToArray();
        CMsg msg = new CMsg();
        msg.dest = data.dest;
        msg.cmd = data.cmd;
        if (body != null && body.Length > 0)
        {
            msg.body = body;
        }

        //放在消息队列里面发
        MessageStruct smsg = new MessageStruct();
        smsg.dest = data.dest;
        smsg.cmd = data.cmd;
        smsg.body = (byte[])Serialize(msg);

        NetWorkManage.getInstance().PushSendDataQueue(smsg);
    }

    public object Serialize(object obj)
    {
        if (obj == null) return null;

        MemoryStream memStream = new MemoryStream();
        ProtoBuf.Serializer.Serialize(memStream, obj);
        return memStream.ToArray();
    }

    public object Deserialize(object data)
    {
        if (data == null) return null;

        byte[] sourse = (byte[])data;
        global::ProtoBuf.IExtensible result = ProtoBuf.Serializer.Deserialize<Msg_2_2_>(new MemoryStream(sourse));
        return result;
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
        MessageStruct message = new MessageStruct();
        message.cmd = cmsg.cmd;
        message.dest = cmsg.cmd;
        message.body = cmsg.body;
        message.serverTime = cmsg.serverTime;

        //分发协议去解析
        PBParseManage.getInstance().DispenseParseData(dest, cmd, body);

        if (IsOftenData(message))
        {
            NetWorkManage.getInstance().PushReceDataScene(message);
        }
        else
        {
            NetWorkManage.getInstance().PushReceDataQueue(message);
        }

        Debug.Log("收到消息 dest=" + dest + ",cmd=" + cmd);

    }

}
