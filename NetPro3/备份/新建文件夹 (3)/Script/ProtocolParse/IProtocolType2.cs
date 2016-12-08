using UnityEngine;
using System.Collections;
using System.IO;

interface IProtocolType2
{
    object SerializeData(object instance);

    object DeserializeData(object source);
}
