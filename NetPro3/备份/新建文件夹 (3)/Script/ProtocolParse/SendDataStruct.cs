using UnityEngine;
using System.Collections;
using System.IO;

public class SendDataStruct : ISendDataStruct
{
    public int dest;
    public int cmd;
    public global::ProtoBuf.IExtensible instance;
}
