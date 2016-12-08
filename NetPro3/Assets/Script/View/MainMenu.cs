using UnityEngine;
using System.Collections;
using com.protobuf;

public class MainMenu : MonoBehaviour {

    // Use this for initialization
    void Start () 
    {
	}
	
	// Update is called once per frame
	void Update () 
    {
	}


    void OnGUI()
    {
        if (GUI.Button(new Rect(10, 10, 100, 50), "连接测试"))
        {
            //Debug.Log("开始连接");

            string ip = "120.25.155.188";
            int port = 6000;

            XLogicWorld.SP.NetManager.ConnectServer(ip, port);

        }

        if (GUI.Button(new Rect(150, 10, 100, 50), "登陆"))
        {
            //登录请求
            Debug.Log("登录请求");

            Msg_2_2 msg = new Msg_2_2();
            msg.aid = "kk";//先写死角色名
            msg.zoneId = 1;//先写死1

            MessageStruct message = MessageStruct.SerializeData(2, 2, msg);

            XLogicWorld.SP.NetManager.SendDataToServer(message);

        }

        if (GUI.Button(new Rect(350, 10, 100, 50), "4_1命令"))
        {
            //登录请求

            //UILogin.AddNew();

            Msg_4_1 msg = new Msg_4_1();
            msg.type = 1;//先写死角色名
            msg.chatData = "卡死大家分开了 所带来房价";

            MessageStruct message = MessageStruct.SerializeData(4, 1, msg);

            XLogicWorld.SP.NetManager.SendDataToServer(message);

        }

        if (GUI.Button(new Rect(500, 10, 100, 50), "100_1命令"))
        {
            Msg_100_1 msg = new Msg_100_1();
            msg.type = 1;//先写死角色名
            msg.chatData = "卡死大家分开了 所带来房价";

            MessageStruct message = MessageStruct.SerializeData(100, 1, msg);

            XLogicWorld.SP.NetManager.SendDataToServer(message);
        }

    }

}
