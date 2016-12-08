using System;
using UnityEngine;

class XLogicWorld
{
    #region Propertys
    public NetWorkManage NetManager { get; private set; }
    #endregion

    private static XLogicWorld m_this = new XLogicWorld();
    public static XLogicWorld SP { get { return m_this; } }	
	
    private XLogicWorld()
    {
        m_this = this;

        NetManager = new NetWorkManage();

        //--4>TODO: 此处加载所有配置文𐀤»¥后考虑是否放到进入游戏过程中或者需要用到的时候加
        //this.initAllConfigMgr();
    }

    ~XLogicWorld()
    {
        OnDestroy();
    }

    #region Functions For App
    public void Init()
    {

	}

    public void Breathe()
    {
        NetManager.Breathe();
    }

    // 只在游戏退出的时候执行这个操    
    public void OnDestroy()
    {
        NetManager.DisconnectServer();
    }

    #endregion
}

