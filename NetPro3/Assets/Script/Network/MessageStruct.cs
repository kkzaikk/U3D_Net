using System.Collections;
using System.IO;
using com.protobuf;

//通讯消息结构(根据后端的CMsg定义)
public class MessageStruct
{
    public const int NETACCEPTED = -100000;

    public int dest;
    public int cmd;
    public byte[] body;
    public long serverTime;

    public MessageStruct()
    {
        dest = NETACCEPTED;
        cmd = 0;
        body = null;
        serverTime = 0;
    }

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

    public string getHeadCommand()
    {
        return "Msg_"+ dest + "_"+ cmd + "_";
    }

    public static MessageStruct SerializeData(int dest,int cmd,global::ProtoBuf.IExtensible instance)
    {
        MemoryStream memStream = new MemoryStream();

        ProtoBuf.Serializer.Serialize(memStream, instance);

        byte[] body = memStream.ToArray();
        CMsg msg = new CMsg();
        msg.dest = dest;
        msg.cmd = cmd;
        if (body != null && body.Length > 0)
        {
            msg.body = body;
        }

        //放在消息队列里面发
        MessageStruct smsg = new MessageStruct();
        smsg.dest = dest;
        smsg.cmd = cmd;
        smsg.body = (byte[])Serialize(msg);

        return smsg;
    }

    private static object Serialize(object obj)
    {
        if (obj == null) return null;

        MemoryStream memStream = new MemoryStream();
        ProtoBuf.Serializer.Serialize(memStream, obj);
        return memStream.ToArray();
    }

    public static MessageStruct DeserializeData(byte[] data, int datalen)
    {
        if (data == null) return null;

        Stream stream = new MemoryStream(data, 0, datalen);

        CMsg cmsg = ProtoBuf.Serializer.Deserialize<CMsg>(stream);

        //消息号保存进队列
        MessageStruct message = new MessageStruct();
        message.cmd = cmsg.cmd;
        message.dest = cmsg.dest;
        message.body = cmsg.body;
        message.serverTime = cmsg.serverTime;

        return message;
    }

}