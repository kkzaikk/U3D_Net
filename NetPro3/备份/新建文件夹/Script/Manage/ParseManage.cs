using UnityEngine;
using System.IO;
using System.Collections;
using com.protobuf;

public class ParseManage 
{

    private PBParseManage  pb = PBParseManage.getInstance();

    private NetWorkManage net = NetWorkManage.getInstance();

    public void Parse(Stream source)
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
        _pb.pbInstance = pb.ParseData(dest, cmd, body);

        if (IsOftenData(dest, cmd))
        {

            net.PushDataScene(_pb);
        }
        else
        {
            net.PushDataQueue(_pb);
        }

        Debug.Log("收到消息 dest=" + dest + ",cmd=" + cmd);
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


}
