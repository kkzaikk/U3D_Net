using System.Collections;

//通讯消息结构(根据后端的CMsg定义)
public class MessageStruct
{
    //网络响应已处理（原来在GD.cs文件）
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

}