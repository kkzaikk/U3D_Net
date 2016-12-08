using UnityEngine;
using System.Collections;
using System.IO;
using com.protobuf;

public class ProtocolType1 : IProtocolType1
{
    //分发协议数据委托
    public delegate void OnDispenseMessage(MessageStruct message);
    public event OnDispenseMessage onDispense = null;

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

        MessageQueueManage.getInstance().PushWillSendData(smsg);
    }

    public object Serialize(object obj)
    {
        if (obj == null) return null;

        MemoryStream memStream = new MemoryStream();
        ProtoBuf.Serializer.Serialize(memStream, obj);
        return memStream.ToArray();
    }

    public T Deserialize<T>(object data)
    {
        if (data == null) return default(T);

        byte[] sourse = (byte[])data;
        T result = ProtoBuf.Serializer.Deserialize<T>(new MemoryStream(sourse));//ProtoBuf.Serializer.Deserialize<Msg_2_2_>(new MemoryStream(sourse));
        return result;
    }

    public void DeserializeData(ReceDataStruct source)
    {
        if (source == null) return;

        Stream stream = new MemoryStream(source.data, 0, source.datalen);

        CMsg cmsg = ProtoBuf.Serializer.Deserialize<CMsg>(stream);

        //消息号保存进队列
        MessageStruct message = new MessageStruct();
        message.cmd = cmsg.cmd;
        message.dest = cmsg.dest;
        message.body = cmsg.body;
        message.serverTime = cmsg.serverTime;

        //分发协议去解析
        if (onDispense != null)
        {
            onDispense(message);
        }

        //放到消息队列
        MessageQueueManage.getInstance().PushYetReceData(message);

        Debug.Log("收到消息 dest=" + cmsg.dest + ",cmd=" + cmsg.cmd);

    }

}
