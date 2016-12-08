using UnityEngine;
using System.Collections;
using System.IO;

public class ReceDataStruct
{
    public byte[] data = null;
    public int datalen = 0;

    public ReceDataStruct(byte[] d, int len)
    {
        data = d;
        datalen = len;
    }
}
