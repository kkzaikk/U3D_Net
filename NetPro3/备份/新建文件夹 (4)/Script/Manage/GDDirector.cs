using UnityEngine;
using System.Collections;
using com.protobuf;

public class GDDirector
{
    private static GDDirector s_GDDirector=null;
    public static GDDirector getInstance()
    {
        if (s_GDDirector == null)
        {
            s_GDDirector = new GDDirector();
        }
        return s_GDDirector;
    }

    //连接过网络
    public static bool acceptNet = false;
    //游戏运行时间
    private float _runtime = 0.0f;
    //帧时间
    private float _deltaTime = 0.0f;

    ////网络连接状态 0普通，1已连接，2断开
    //private int netStatus = 0;

    //网络
    private NetWorkManage s_NetWorkManage = NetWorkManage.getInstance();
    //UI层 管理
    private UILayerManage s_UILayerManage = UILayerManage.getInstance();

    public float Runtime
    {
        get { return _runtime;}
    }
    public float DeltaTime
    {
        get { return _deltaTime; }
    }
    //初始化
    public void Init(Transform uiRoot)
    {
    }

    //每一帧调用
    public void UpdatePerFrame(float dt)
    {
        _runtime += dt;
        _deltaTime = dt;
        //网络 是否有消息过来
        int dest = NetWorkManage.NETACCEPTED;
        int cmd = 0;

        //获取协议号
        s_NetWorkManage.getCMsg(ref dest, ref cmd);

        //传递给UI
        s_UILayerManage.UpdatePerFrame(dt, dest, cmd);

    }
 
}
