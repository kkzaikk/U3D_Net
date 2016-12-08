using System.Collections;

public class CurrProtocolManage
{
    private static ProtocolType1 s_ProtocolType1 = null;
    public static ProtocolType1 getInstance()
    {
        if (s_ProtocolType1 == null)
        {
            s_ProtocolType1 = new ProtocolType1();
        }
        return s_ProtocolType1;
    }
}
