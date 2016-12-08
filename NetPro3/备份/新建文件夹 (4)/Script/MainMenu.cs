using UnityEngine;
using System.Collections;
using com.protobuf;

public class MainMenu : MonoBehaviour {

    private GDDirector s_GDDirector = GDDirector.getInstance();

	// Use this for initialization
	void Start () 
    {
	}
	
	// Update is called once per frame
	void Update () 
    {
        s_GDDirector.UpdatePerFrame(Time.deltaTime);
	}


    void OnGUI()
    {
        if (GUI.Button(new Rect(10, 10, 100, 50), "连接测试"))
        {
            Debug.Log("开始连接");

            string ip = "192.168.0.43";
            int port = 6000;

            NetWorkManage s_NetWorkManage = NetWorkManage.getInstance();
            s_NetWorkManage.setHostPort(ip, port);
            if (!s_NetWorkManage.Connect())
            {
                Debug.Log("服务器连接失败，请检查网络！");
                return;
            }

        }

        if (GUI.Button(new Rect(150, 10, 100, 50), "登陆"))
        {
            //登录请求
            Debug.Log("登录请求");

            Msg_2_2 msg = new Msg_2_2();
            msg.aid = "Test02";//先写死角色名
            msg.zoneId = 1;//先写死1

            SendDataStruct data = new SendDataStruct();
            data.cmd = 2;
            data.dest = 2;
            data.instance = msg;

            //NetWorkManage.SendData(2, 2, msg);
            NetWorkManage.SendData(data);
            
        }

        if (GUI.Button(new Rect(350, 10, 100, 50), "login"))
        {
            //登录请求
            Debug.Log("login界面");
            GameObject obj = UILayerManage.getInstance().CreateRoot("UILogin", "UILogin");
        }

        if (GUI.Button(new Rect(500, 10, 100, 50), "抽象工厂模式"))
        {
            IProtocolFactory factory = new ProtocolFactory();

            factory.createProtocolType1().DeserializeData(null);
            factory.createProtocolType2().DeserializeData(null);

        }

    }

}
