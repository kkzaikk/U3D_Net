using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class UIComponent : MonoBehaviour
{

    public Dictionary<string, GameObject> objMap = new Dictionary<string, GameObject>();

    //本层状态，在激活状态下可接受网络消息，与按钮点击。
    protected bool layerActive = false;

    //启用
    public void Resume()
    {
    }
    //暂停
    public void Pause()
    {
    }

    //初始化
    public virtual void Init() { }

    //解析变量
    public void ParseNode(GameObject obj) 
    {
    }

    // Use this for initialization
    void Start()
    {
    }

    void Awake()
    {
        Transform[] arrobj = gameObject.GetComponentsInChildren<Transform>(true);
        foreach (Transform ttt in arrobj)
        {
            objMap[ttt.gameObject.name] = ttt.gameObject;
        }
    }

    //如果本层是活动层，则调用。子类可override 重载这个函数
    public virtual void LogicUpdate(float dt) { }

    //自己添加
    public delegate void OnNetWordResponse(int dest, int cmd);
    public OnNetWordResponse onNetWord = null;

    public delegate void OnEnterResponse();
    public OnEnterResponse onEnter = null;

    public delegate void OnExitResponse();
    public OnExitResponse onExit = null;

    public void setCallback(OnNetWordResponse net, OnEnterResponse enter, OnExitResponse exit)
    {
        onNetWord = net;
        onEnter = enter;
        onExit = exit;
    }

    //end//////////////////////////////////////////////////////////////////////////////////////////////

    //是否可以处理网络响应
    private bool acceptNet = true;
    //层次，默认为0;
    private int order = 0;
    //子节点Panel最大深度
    public int maxPanelOrder = 0;
    //名字
    private string uiName = "";

    private UIComponent prevLayer = null;

    //网络与活动状态
    public LastLayerStatus s_LastLayerStatus = LastLayerStatus.Active_N_Net_N;
    //加背景盖住地图
    public bool overMap = false;

    //释放资源
    public void Dispose()
    {
        if (transform)transform.parent = null;
        if (gameObject) GameObject.Destroy(gameObject);
    }
    ///////////////////////////////////////////////////////////////////////////
    //设置网络状态
    public bool AcceptNet
    {
        get { return acceptNet; }
        set { acceptNet = value; }
    }
    //名字
    public string UiName
    {
        get { return uiName; }
        set { uiName = value; }
    }
    //层次
    public int Order
    {
        get { return order; }
        set { order = value; }
    }
    //前一节点
    public UIComponent PrevLayer
    {
        get { return prevLayer; }
        set { prevLayer = value; }
    }

    /////////////////////////////////////////////////////////////////////
    //层界面进入激活状态
    public void OnEnter()
    {
        if (onEnter != null)
        {
            onEnter();
        }

        layerActive = true;
        Resume();
    }

    //层界面退出激活状态
    public void OnExit()
    {
        if (onExit != null)
        {
            onExit();
        }

        layerActive = false;
        Pause();
    }

    //删除结束
    public virtual void RemoveEnd()
    {
    }

    //每帧更新
    public bool UpdatePerFrame(float dt, ref int dest, int cmd)
    {
        if (layerActive)
        {
            LogicUpdate(dt);
            if (acceptNet && dest != NetWorkManage.NETACCEPTED)
            {
                if (onNetWord != null)
                {
                    onNetWord(dest, cmd);
                }

                return true;
            }
        }
        return false;
    }
    ///////////////////////////////////////////////////////////////////
}
