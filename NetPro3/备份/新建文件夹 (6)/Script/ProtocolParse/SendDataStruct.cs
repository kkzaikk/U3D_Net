using UnityEngine;
using System.Collections;
using System.IO;

public class SendDataStruct
{

    public int dest;
    public int cmd;
    public global::ProtoBuf.IExtensible instance;

    public SendDataStruct(int d, int c, global::ProtoBuf.IExtensible i)
    {
        dest = d;
        cmd = c;
        instance = i;
    }
}
