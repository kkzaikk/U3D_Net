using UnityEngine;
using System.Collections;

public class UIHeroUP : UIComponent {



    //初始化
    public override void Init()
    {
        base.Init();
        UIEventListener.Get(objMap["getTestBnt0"]).onClick += preFireBnt;
        UIEventListener.Get(objMap["getTestBnt1"]).onClick += preFireBnt;
        UIEventListener.Get(objMap["getTestBnt2"]).onClick += preFireBnt;
    }

    //// Use this for initialization
    //void Start () {
	
    //}
	
    //// Update is called once per frame
    //void Update () {
	
    //}

    //void Awake()
    //{
    //    UIComponent netWork = gameObject.GetComponent<UIComponent>();

    //    netWork.onEnter = OnEnterkkk;

    //    netWork.onExit = OnExitkkk;

    //    //
    //    UIEventListener.Get(netWork.objMap["getTestBnt0"]).onClick += preFireBnt;
    //    UIEventListener.Get(netWork.objMap["getTestBnt1"]).onClick += preFireBnt;
    //    UIEventListener.Get(netWork.objMap["getTestBnt2"]).onClick += preFireBnt;
    //}

    //加入场景 replace=true 替换上一层。replace=false 直接叠加一层。
    public static UIHeroUP AddNew(bool replace = false)
    {
        UIHeroUP s_UIHeroUP = (UIHeroUP)UILayerManage.getInstance().CreateAndAdd(new UIHeroUP(), "UIHeroUP", replace);
        return s_UIHeroUP;
    }
    //加入新一层，替换上一层
    public static UIHeroUP Replace()
    {
        return AddNew(true);
    }

    public override void OnEnter()
    {
        base.OnEnter();
        Debug.Log("UIHeroUP 进来了，逗比");
    }

    public override void OnExit()
    {
        base.OnExit();
        Debug.Log("UIHeroUP 出去了，逗比");
    }

    public void preFireBnt(GameObject obj)
    {
        if ("getTestBnt0" == obj.name)
        {
            UILayerManage.getInstance().RemoveLayer(this);
        }
        else if ("getTestBnt1" == obj.name)
        {
            //UILayerManage.getInstance().CreateAndAdd("UIAdditionTip", "UIAdditionTip", false);
            UIAdditionTip.AddNew();
        }
        else if ("getTestBnt2" == obj.name)
        {
            //UILayerManage.getInstance().CreateAndAdd("UIAdditionTip", "UIAdditionTip", true);
            UIAdditionTip.Replace();
        }
    }

}
