﻿using UnityEngine;
using System.Collections;
using System.IO;

public class ProtocolType2 : IProtocolType2
{
    public void SerializeData(SendDataStruct data)
    {
        Debug.Log("SerializeData");

    }

    public void DeserializeData(ReceDataStruct source)
    {
        Debug.Log("DeserializeData");
    }
}
