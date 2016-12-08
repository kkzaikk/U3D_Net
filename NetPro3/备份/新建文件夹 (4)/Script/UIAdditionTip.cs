using UnityEngine;
using System.Collections;
using com.protobuf;

public class UIAdditionTip : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void Awake()
    {
        UIComponent netWork = gameObject.GetComponent<UIComponent>();

        UIEventListener.Get(netWork.objMap["closeBnt"]).onClick += preFireBnt;
        UIEventListener.Get(netWork.objMap["netBnt"]).onClick += preFireBnt;

        netWork.onNetWord = NetResponse;

        netWork.onEnter = OnEnterkkk;

        netWork.onExit = OnExitkkk;
    }

    public void preFireBnt(GameObject obj)
    {
        if ("netBnt" == obj.name)
        {
            Msg_2_2 msg = new Msg_2_2();
            msg.aid = "Test02";//先写死角色名
            msg.zoneId = 1;//先写死1
            //NetWorkManage.SendData<Msg_2_2>(2, 2, msg);
        }
        else
        {
            UILayerManage.getInstance().RemoveLayer(gameObject);
        }
    }

    public void OnEnterkkk()
    {
        Debug.Log("UIAdditionTip 进来了，逗比");
    }

    public void OnExitkkk()
    {
        Debug.Log("UIAdditionTip 出去了，逗比");
    }

    //网络监听处理
    public void NetResponse(int dest, int cmd)
    {
        if (dest == 2 && cmd == 2)
        {
            Debug.Log("UIAdditionTip 网络返回了，逗比");
        }
    }

}
