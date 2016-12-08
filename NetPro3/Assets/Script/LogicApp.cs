using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


class LogicApp : MonoBehaviour
{
	//test:
	public bool						TestScene = false;
	public GameObject				TestBlock = null;
	public GameObject				TestRoad = null;
	//------

	public Camera					MainCamera = null;
	public Camera					UICamera = null;
	
	public string					ApacheServer = "0.0.0.0:0";
	public string					LoginServer = "0.0.0.0:0";
	
    public static LogicApp SP { get; private set; }

	public void Start()
	{
		LogicApp.SP = this;

        DontDestroyOnLoad(this);

        InitGameMgr();

	}

	private void InitGameMgr()
	{
		// 逻辑初始化
		XLogicWorld.SP.Init();
	}

	public void Update()
	{
        XLogicWorld.SP.Breathe();
	}
	
	void LateUpdate() {
    }
	
	void OnGUI() {
    }
	
    public void OnApplicationQuit()
    {
        //--4>TODO: 目前是单个场景, 离开直接退出
        XLogicWorld.SP.OnDestroy();
    }
	
	private static string DumpApplication()
    {
        StringBuilder builder = new StringBuilder();
        builder.AppendFormat("DumpApplication\n", new object[0]);
        builder.AppendFormat("  isWebPlayer: {0}\n", Application.isWebPlayer);
        builder.AppendFormat("  isPlaying: {0}\n", Application.isPlaying);
        builder.AppendFormat("  isLoadingLevel: {0}\n", Application.isLoadingLevel);
        builder.AppendFormat("  isEditor: {0}\n", Application.isEditor);
        builder.AppendFormat("  platform: {0}\n", Application.platform);
        builder.AppendFormat("  absoluteURL: {0}\n", Application.absoluteURL);
        builder.AppendFormat("  dataPath: {0}\n", Application.dataPath);
        builder.AppendFormat("  persistentDataPath: {0}\n", Application.persistentDataPath);
        builder.AppendFormat("  temporaryCachePath: {0}\n", Application.temporaryCachePath);
        builder.AppendFormat("  webSecurityHostUrl: {0}\n", Application.webSecurityHostUrl);
        builder.AppendFormat("  webSecurityEnabled: {0}\n", Application.webSecurityEnabled);
        builder.AppendFormat("  srcValue: {0}\n", Application.srcValue);
        builder.AppendFormat("  targetFrameRate: {0}\n", Application.targetFrameRate);
        builder.AppendFormat("  unityVersion: {0}\n", Application.unityVersion);
        return builder.ToString();
    }
}
