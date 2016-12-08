using UnityEngine;
using System.Collections;
using com.protobuf;

public class UIAdditionTip : UIComponent {


    //初始化
    public override void Init()
    {
        base.Init();
        UIEventListener.Get(objMap["closeBnt"]).onClick += preFireBnt;
        UIEventListener.Get(objMap["netBnt"]).onClick += preFireBnt;
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

    //    UIEventListener.Get(netWork.objMap["closeBnt"]).onClick += preFireBnt;
    //    UIEventListener.Get(netWork.objMap["netBnt"]).onClick += preFireBnt;

    //    netWork.onNetWord = NetResponse;

    //    netWork.onEnter = OnEnterkkk;

    //    netWork.onExit = OnExitkkk;
    //}

    //加入场景 replace=true 替换上一层。replace=false 直接叠加一层。
    public static UIAdditionTip AddNew(bool replace = false)
    {
        UIAdditionTip s_UIHeroUP = (UIAdditionTip)UILayerManage.getInstance().CreateAndAdd(new UIAdditionTip(), "UIAdditionTip", replace);
        return s_UIHeroUP;
    }
    //加入新一层，替换上一层
    public static UIAdditionTip Replace()
    {
        return AddNew(true);
    }

    public void preFireBnt(GameObject obj)
    {
        if ("netBnt" == obj.name)
        {

            Msg_100_1 msg = new Msg_100_1();
            msg.type = 1;//先写死角色名
            msg.chatData = "卡死大家分开了 所带来房价";

            ////协议结构
            //SendDataStruct data = new SendDataStruct(100, 1, msg);
            ////序列化
            //MessageStruct message = CurrProtocolManage.getInstance().SerializeData(data);
            ////放到消息队列
            //MessageQueueManage.getInstance().PushWillSendData(message);


            /*
            Msg_2_2 msg = new Msg_2_2();
            msg.aid = "Test24";//先写死角色名
            msg.zoneId = 1;//先写死1

            //协议结构
            SendDataStruct data = new SendDataStruct(2, 2, msg);
            //序列化
            MessageStruct message = CurrProtocolManage.getInstance().SerializeData(data);
            //放到消息队列
            MessageQueueManage.getInstance().PushWillSendData(message);
            */
        }
        else
        {
            Msg_4_1 msg = new Msg_4_1();
            msg.type = 1;//先写死角色名
            msg.chatData = "卡死大家分开了 所带来房价";

            ////协议结构
            //SendDataStruct data = new SendDataStruct(4, 1, msg);
            ////序列化
            //MessageStruct message = CurrProtocolManage.getInstance().SerializeData(data);
            ////放到消息队列
            //MessageQueueManage.getInstance().PushWillSendData(message);
            ////UILayerManage.getInstance().RemoveLayer(this);
        }
    }

    public override void OnEnter()
    {
        base.OnEnter();
        Debug.Log("UIAdditionTip 进来了，逗比");
    }

    public override void OnExit()
    {
        base.OnExit();
        Debug.Log("UIAdditionTip 出去了，逗比");
    }

    //网络监听处理
    public override void NetResponse(int dest, int cmd)
    {
        if (dest == 2 && cmd == 2)
        {
            Debug.Log("2-2UIAdditionTip 网络返回了，逗比");
        }
        else if (dest == 2 && cmd == 3)
        {
            Debug.Log("2-3UIAdditionTip 网络返回了，逗比");
        }
        else if (dest == 3 && cmd == 3)
        {
            Debug.Log("3-3UIAdditionTip 网络返回了，逗比");
        }
        else if (dest == 6 && cmd == 1)
        {
            Debug.Log("3-3UIAdditionTip 网络返回了，逗比");
        }
        else if (dest == 100 && cmd == 1)
        {
            Debug.Log("老杜的测试返回了");
        }
    }

}
