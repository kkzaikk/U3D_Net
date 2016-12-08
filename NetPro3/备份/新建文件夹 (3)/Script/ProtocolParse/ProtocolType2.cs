using UnityEngine;
using System.Collections;
using System.IO;

public class ProtocolType2 : IProtocolType2
{
    public object SerializeData(object instance)
    {
        Debug.Log("SerializeData");

        return null;
    }

    public object DeserializeData(object source)
    {
        Debug.Log("DeserializeData");

        return null;
    }
}
