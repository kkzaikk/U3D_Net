﻿using UnityEngine;
using System.Collections;
using com.protobuf;

public class UILogin : UIComponent
{
    //名称
    private const string LOGINBTN0 = "loginBtn0";
    private const string LOGINBTN1 = "loginBtn1";
    private const string LOGINBTN2 = "loginBtn2";

    //初始化
    public override void Init() 
    {
        base.Init();

        UIEventListener.Get(objMap[LOGINBTN0]).onClick += preFireBnt;
        UIEventListener.Get(objMap[LOGINBTN1]).onClick += preFireBnt;
        UIEventListener.Get(objMap[LOGINBTN2]).onClick += preFireBnt;
    }


    //void Awake()
    //{
    //    UIComponent netWorkCOM = gameObject.GetComponent<UIComponent>();

    //    netWorkCOM.setCallback(NetResponse, OnEnterkkk, OnExitkkk);

    //    //添加按钮回调
    //    UIEventListener.Get(netWorkCOM.objMap[LOGINBTN0]).onClick += preFireBnt;
    //    UIEventListener.Get(netWorkCOM.objMap[LOGINBTN1]).onClick += preFireBnt;
    //    UIEventListener.Get(netWorkCOM.objMap[LOGINBTN2]).onClick += preFireBnt;
    //}

    //// Use this for initialization
    //void Start()
    //{
    //}

    //加入场景 replace=true 替换上一层。replace=false 直接叠加一层。
    public static UILogin AddNew(bool replace = false)
    {
        UILogin s_UITongtiantaView = (UILogin)UILayerManage.getInstance().CreateAndAdd(new UILogin(), "UILogin", replace);
        return s_UITongtiantaView;
    }
    //加入新一层，替换上一层
    public static UILogin Replace()
    {
        return AddNew(true);
    }

    public void initPanel()
    {

    }

    public void preFireBnt(GameObject obj)
    {
        if (LOGINBTN0 == obj.name)
        {
            Msg_2_2 msg = new Msg_2_2();
            msg.aid = "Test02";//先写死角色名
            msg.zoneId = 1;//先写死1
            //NetWorkManage.SendData<Msg_2_2>(2, 2, msg);
        }
        else if (LOGINBTN1 == obj.name)
        {
            //UILayerManage.getInstance().CreateAndAdd("UIHeroUP", "UIHeroUP", false);
            UIHeroUP.AddNew();
        }
        else if (LOGINBTN2 == obj.name)
        {
            Debug.Log("我我我");
        }
    }

        //网络监听处理
    public override void NetResponse(int dest, int cmd)
    {
        if (dest == 2 && cmd == 2)
        {
            Debug.Log("UILogin 网络返回了，逗比");
        }
    }

    public override void OnEnter()
    {
        base.Init();
        Debug.Log("UILogin 进来了，逗比");
    }

    public override void OnExit()
    {
        base.Init();
        Debug.Log("UILogin 出去了，逗比");
    }

}
