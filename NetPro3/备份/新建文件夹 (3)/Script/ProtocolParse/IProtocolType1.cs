using UnityEngine;
using System.Collections;
using System.IO;

interface IProtocolType1 
{
    //object SerializeData(int dest, int cmd, object instance);
    void SerializeData(SendDataStruct data);

    object DeserializeData(object source);
}
