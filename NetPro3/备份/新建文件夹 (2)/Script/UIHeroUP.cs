using UnityEngine;
using System.Collections;

public class UIHeroUP : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void Awake()
    {
        UIComponent netWork = gameObject.GetComponent<UIComponent>();

        netWork.onEnter = OnEnterkkk;

        netWork.onExit = OnExitkkk;

        //
        UIEventListener.Get(netWork.objMap["getTestBnt0"]).onClick += preFireBnt;
        UIEventListener.Get(netWork.objMap["getTestBnt1"]).onClick += preFireBnt;
        UIEventListener.Get(netWork.objMap["getTestBnt2"]).onClick += preFireBnt;
    }

    public void OnEnterkkk()
    {
        Debug.Log("UIHeroUP 进来了，逗比");
    }

    public void OnExitkkk()
    {
        Debug.Log("UIHeroUP 出去了，逗比");
    }

    public void preFireBnt(GameObject obj)
    {
        if ("getTestBnt0" == obj.name)
        {
            UILayerManage.getInstance().RemoveLayer(gameObject);
        }
        else if ("getTestBnt1" == obj.name)
        {
            UILayerManage.getInstance().CreateAndAdd("UIAdditionTip", "UIAdditionTip", false);
        }
        else if ("getTestBnt2" == obj.name)
        {
            UILayerManage.getInstance().CreateAndAdd("UIAdditionTip", "UIAdditionTip", true);
        }
    }

}
