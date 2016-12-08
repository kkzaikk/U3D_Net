using UnityEngine;
using System.Collections;

public class PBParseBasic
{
    //初始化
    public virtual void Init() { }
    public virtual void Destroy() { }
    public virtual void ParseData(string msgIndex, byte[] _data) { }

}
