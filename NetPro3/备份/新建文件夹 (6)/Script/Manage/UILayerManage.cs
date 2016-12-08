using UnityEngine;
//using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

//加一层界面时，上层界面活动和网络监听状态。
public enum LastLayerStatus
{
    Active_N_Net_N,//上一层处于非活动状态，不可以接受网络（默认这个状态）
    Active_Y_Net_N,//上一层处于活动状态，不可以接受网络
    Active_Y_Net_Y//上一层处于活动状态，并且可以接受网络
}

//UI界面管理器
class UILayerManage
{
    private static UILayerManage s_UILayerManage = null;

    //ui根节点
    private Transform uiRoot = null;

    //层次 在NGUI是用depthl来管理渲染深度，所以这里暂时没起作用用。
    private int currOrder=0;

    //当前层
    private UIComponent currLayerComp = null;

    //按时间释放资源
    private float unloadTime = 0;

    //所有添加进来的界面。
    private List<UIComponent> layerCompList = new List<UIComponent>();

    public static UILayerManage getInstance()
    {
        if (s_UILayerManage == null)
        {
            s_UILayerManage = new UILayerManage();
        }
        return s_UILayerManage;
    }


    //jf add 20150722//////////////////////////////////////////////////////////////////////////////////////////

    //（原来是GD.cs文件）/////////////////////////////////////////////////////////////////////////////////////
    //实例化一个预设，必须用这个，因为操作失败可以用默认模型代替。避免程序闪退。
    //keepInfo=true保持位置与角度信息
    public static GameObject Instantiate(Object obj, bool keepInfo = true)
    {
        if (obj == null)
        {
            Debug.LogError("加载资源失败！使用默认Cube代替");
            return CreateCube(0.1f);
        }
        GameObject _gobj = null;
        if (keepInfo == false)
        {
            _gobj = GameObject.Instantiate(obj, Vector3.zero, Quaternion.Euler(Vector3.zero)) as GameObject;
        }
        else
        {
            _gobj = GameObject.Instantiate(obj) as GameObject;
        }
        return _gobj;
    }
    //根据预设资源路径创建一个gameobject  //keepInfo=true保持位置与角度信息
    public static GameObject Instantiate(string prefabName, bool keepInfo = false)
    {
        GameObject go = null;
        UnityEngine.Object obj = Load(prefabName);
        if (obj)
        {
            go = Instantiate(obj, keepInfo);
        }
        else
        {
            Debug.LogError("加载资源" + prefabName + "失败！");
        }
        return go;
    }
    //根据预设资源路径创建一个gameobject。可传位置、缩放、方向信息。
    public static GameObject Instantiate(string prefabName, Vector3 pos, Vector3 rot, Vector3 sca)
    {
        GameObject go = null;
        UnityEngine.Object obj = Load(prefabName);
        if (obj)
        {
            go = Instantiate(obj, pos, rot, sca);
        }
        return go;
    }
    //实例化一个预设。可传位置、缩放、方向信息。
    public static GameObject Instantiate(Object obj, Vector3 pos, Vector3 rot, Vector3 sca)
    {
        if (obj == null)
        {
            Debug.LogError("加载资源失败！使用默认Cube代替");
            return CreateCube(0.1f);
        }
        GameObject _gobj = GameObject.Instantiate(obj, pos, Quaternion.Euler(rot)) as GameObject;
        _gobj.transform.localScale = sca;
        return _gobj;
    }

    //创建一个半径为r的cude。参数removeCollider表示是否删除碰撞器。
    public static GameObject CreateCube(float r, bool removeCollider = true)
    {
        GameObject obj = GameObject.CreatePrimitive(PrimitiveType.Cube);
        obj.transform.localScale = new Vector3(r, r, r);
        if (removeCollider)
        {
            BoxCollider coll = obj.GetComponent<BoxCollider>();
            //去掉碰撞
            GameObject.DestroyImmediate(coll);
        }
#if !(UNITY_STANDALONE||UNITY_EDITOR)
        obj.renderer.enabled = false;
#endif
        return obj;
    }

    //（原来ResourceManage.cs文件）/////////////////////////////////////////////////////////////////////

    //资源同步加载。注意：同一份资源，异步加载与同步不能同时发生。
    public static Object Load(string filename, System.Type types = null)
    {
        return Load(filename, false, types);
    }

    private static Object Load(string filename, bool fromChild, System.Type types = null)
    {
        Object obj = null;

        if (types == null)
        {
            obj = Resources.Load(filename);
        }
        else
        {
            obj = Resources.Load(filename, types);
        }

        if (obj == null) Debug.LogError("资源文件：" + filename + "不存在！");

        return obj;
    }

    //end///////////////////////////////////////////////////////////////////////////////////////////////////////////////////


    //实例化一个ui预设节点
    public static GameObject InstantiateUIPre(string _uiname)
    {
        UnityEngine.Object obj = Load(_uiname);
        if (obj != null)
        {
            GameObject _tran = Instantiate(obj);
            if (_tran == null)
            {
                Debug.Log(_uiname + "实例化出错!");
                return null;
            }

            return _tran;
        }
        else
        {
            Debug.Log(_uiname + "资源没找到！");
        }
        return null;
    }

    //给ui根节点赋值
    public Transform UiRoot
    {
        set { uiRoot = value; }
        get { return uiRoot; }
    }

    //每帧更新。
    public void UpdatePerFrame(float dt, int dest, int cmd)
    {
        int _size = layerCompList.Count;
        int _proto = dest;
        for (int i = _size - 1; i >= 0; i--)
        {
            UIComponent layerComp = layerCompList[i];
            if (layerComp != null && layerComp.UpdatePerFrame(dt, ref _proto, cmd))
            {
                _proto = MessageStruct.NETACCEPTED;
            }
        }
    }

    //创建第一层界面
    public GameObject CreateRoot(string uiname, string scriptName)
    {
        while (currLayerComp != null)
        {
            RemoveLayer(currLayerComp.gameObject, true);
        }

        GameObject s_obj = UILayerManage.InstantiateUIPre(uiname);

        //添加组件
        s_obj.AddComponent<UIComponent>();

        s_obj.AddComponent(scriptName);
        
        if (s_obj != null)
        {
            AddNewLayer(s_obj, LastLayerStatus.Active_N_Net_N);
        }

        DisposeRes();

        return s_obj;
    }

    //新建一层，叠加或覆盖 如果replace=true 则s_LLStatus的值无效
    public GameObject CreateAndAdd(string uiLayer, string uiname, bool replace = true, LastLayerStatus s_LLStatus = LastLayerStatus.Active_N_Net_N)
    {
        if (currLayerComp != null)
        {
            if (currLayerComp.name == uiname)
            {
                Debug.Log("T CreateAndAdd 同样的界面不要连续加两次！" + uiname);
                return currLayerComp.gameObject;
            }
        }

        //实例化
        GameObject s_UILayer = UILayerManage.InstantiateUIPre(uiname);

        //添加通用组件
        s_UILayer.AddComponent<UIComponent>();

        //添加本身组件
        s_UILayer.AddComponent(uiLayer);

        //
        if (s_UILayer != null)
        {
            if (replace)
            {
                ReplaceLayer(s_UILayer);
            }
            else
            {
                AddNewLayer(s_UILayer, s_LLStatus);
            }
        }
        return s_UILayer;
    }

    //增加一层界面
    private void AddNewLayer(GameObject obj,LastLayerStatus s_LLStatus)
    {
        if (uiRoot == null)
        {
            uiRoot = GameObject.Find("UI Root").transform;
        }

        obj.transform.parent = uiRoot;
        obj.transform.localScale = new Vector3(1, 1, 1);

        UIComponent layerComp = obj.GetComponent<UIComponent>();

        if (currLayerComp != null)
        {
            layerComp.PrevLayer = currLayerComp;

            UIComponent currUILayer = currLayerComp;

            currUILayer.s_LastLayerStatus = s_LLStatus;

            switch (s_LLStatus)
            {
                case LastLayerStatus.Active_N_Net_N:
                    currUILayer.OnExit();
                    break;
                case LastLayerStatus.Active_Y_Net_N:
                    currUILayer.AcceptNet = false;
                    break;
                case LastLayerStatus.Active_Y_Net_Y:
                    break;
                default:
                    break;
            }
        }

        layerCompList.Add(layerComp);

        currLayerComp = layerComp;
        layerComp.Init();
        layerComp.OnEnter();
        
    }

    //用新层替换当前层
    private void ReplaceLayer(GameObject obj)
    {
        if (uiRoot == null)
        {
            uiRoot = GameObject.Find("UI Root").transform;
        }

        if (currLayerComp == null)
        {
            AddNewLayer(obj, LastLayerStatus.Active_N_Net_N);
            return;
        }

        int _count = layerCompList.Count;

        if (_count == 0)
        {
            currLayerComp = null;
            AddNewLayer(obj, LastLayerStatus.Active_N_Net_N);
        }
        else
        {
            UIComponent layerComp = obj.GetComponent<UIComponent>();

            layerComp.PrevLayer = currLayerComp.PrevLayer;

            layerCompList.Remove(currLayerComp);

            //释放资源
            UIComponent js_currLayer = currLayerComp;
            if (js_currLayer != null)
            {
                js_currLayer.OnExit();
                js_currLayer.Dispose();
            }


            obj.transform.parent = uiRoot;
            obj.transform.localScale = new Vector3(1, 1, 1);

            layerCompList.Add(layerComp);

            layerComp.Init();

            layerComp.OnEnter();

            currLayerComp = layerComp;
        }
    }

    //删除一层
    public void RemoveLayer(GameObject layer,bool jsremove = false)
    {
        if (layer != null) currLayerComp = layer.GetComponent<UIComponent>();

        UIComponent currUILayer = currLayerComp;

        UIComponent lastLayer = currUILayer.PrevLayer;

        layerCompList.Remove(currLayerComp);

        //释放资源
        currUILayer.OnExit();

        currUILayer.Dispose();

        currLayerComp = lastLayer;

        if (!jsremove)
        {
            if (lastLayer != null)
            {
                switch (lastLayer.s_LastLayerStatus)
                {
                    case LastLayerStatus.Active_N_Net_N:
                        lastLayer.OnEnter();
                        break;
                    case LastLayerStatus.Active_Y_Net_N:
                        lastLayer.AcceptNet = true;
                        break;
                    case LastLayerStatus.Active_Y_Net_Y:
                        break;
                    default:
                        lastLayer.OnEnter();
                        break;
                }
            }

            DisposeRes();

            if (currLayerComp != null) currUILayer.RemoveEnd();
        }
    }

    //释放资源
    private void DisposeRes()
    {
        //GDABLoadManage.getInstance().CheckUnload();
        UIDrawCall.ReleaseInactive();
        Resources.UnloadUnusedAssets();
        if (Time.time - unloadTime > 5)
        {
            System.GC.Collect();
            unloadTime = Time.time;
        }
    }

    //删除最顶层
    public void RemoveTopLayer()
    {
        RemoveLayer(null);
    }

    //获取当前层
    public GameObject getCurrLayer()
    {
        return currLayerComp.gameObject;
    }

    //判断当前层是否是第一层
    public bool IsRootLayer()
    {
        UIComponent uiLayer = currLayerComp;

        if (currLayerComp == null) return true;
        if (uiLayer.PrevLayer == null) return true;
        return false;
    }

    //设置当前层显示状态
    public void SetCurrLayer(bool show)
    {
        if (currLayerComp != null)
        {
            currLayerComp.gameObject.SetActive(show);
        }
    }

    //显示当前层
    public void ShowCurrLayer()
    {
        if (currLayerComp != null)
        {
            currLayerComp.gameObject.SetActive(true);
            currLayerComp.OnEnter();
        }
    }
    
}
