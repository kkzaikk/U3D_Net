using UnityEngine;
using System.Collections;
using System.IO;

public class ProtocolType2 : IProtocolType2
{

    public delegate void OnDispenseMessage(MessageStruct message);
    public event OnDispenseMessage onDispense = null;

    public void SerializeData(SendDataStruct data)
    {
        Debug.Log("SerializeData");

    }

    public void DeserializeData(ReceDataStruct source)
    {
        Debug.Log("DeserializeData");
    }


    public object Serialize(object obj)
    {
        return null;
    }


    public object Deserialize(object data)
    {
        return null;
    }
}
