using UnityEngine;
using System.Collections;

interface IProtocolFactory
{
    IProtocolType1 createProtocolType1();
    IProtocolType2 createProtocolType2();  
}
