using UnityEngine;
using System.Collections;
using System.IO;

interface IProtocolType2
{
    void SerializeData(SendDataStruct data);

    void DeserializeData(ReceDataStruct source);
}
