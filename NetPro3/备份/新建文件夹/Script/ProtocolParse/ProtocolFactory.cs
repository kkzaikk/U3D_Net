using UnityEngine;
using System.Collections;

class ProtocolFactory : IProtocolFactory
{
    public IProtocolType1 createProtocolType1()
    {
        return new ProtocolType1();
    }

    public IProtocolType2 createProtocolType2()
    {
        return new ProtocolType2();
    }

}
