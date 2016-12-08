using UnityEngine;
using System.Collections;
using System.IO;

interface IProtocolType1 
{
    void SerializeData(SendDataStruct data);

    object Serialize(object obj);

    void DeserializeData(ReceDataStruct source);

    object Deserialize(object data);
}
