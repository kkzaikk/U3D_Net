using UnityEngine;
using System.Collections;

class ProtocolFactory : IProtocolFactory
{
    private IProtocolType1 nowUserProtocol = null;

    public IProtocolType1 createProtocolType1()
    {
        if (nowUserProtocol == null)
        {
            nowUserProtocol = new ProtocolType1();
        }
        return nowUserProtocol;
    }

    public IProtocolType2 createProtocolType2()
    {
        return new ProtocolType2();
    }

}
