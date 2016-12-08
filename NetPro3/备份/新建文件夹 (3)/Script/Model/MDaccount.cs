using System;
using System.Collections.Generic;
using com.protobuf;
using System.IO;
using UnityEngine;

public class MDaccount : PBParseBasic
{
    private static MDaccount s_MDaccount = null;
    public int cityId = 1;
    public long startServerZeroTime = 1;

    public static MDaccount getInstance()
    {
        if (s_MDaccount == null)
        {
            s_MDaccount = new MDaccount();
            s_MDaccount.Init();
        }
        return s_MDaccount;
    }

    //初始化
    public override void Init() 
    {

    }
    //清除数据
    public override void Destroy()
    {

    }
    //解析protocol 协议
    public override void ParseData(string msgIndex, byte[] _data)
    {
        Debug.Log("解析了MDaccount");
        global::ProtoBuf.IExtensible retIE=null;
        switch (msgIndex)
        {
			case "Msg_2_1_":
			{
				Msg_2_1_ cmsg = null;
				if(_data!=null) cmsg = ProtoBuf.Serializer.Deserialize<Msg_2_1_>(new MemoryStream(_data));
				Fun_Msg_2_1_(cmsg);
				retIE=cmsg;
				break;
			}
			case "Msg_2_2_":
			{
				Msg_2_2_ cmsg = null;
				if(_data!=null) cmsg = ProtoBuf.Serializer.Deserialize<Msg_2_2_>(new MemoryStream(_data));
				Fun_Msg_2_2_(cmsg);
				retIE=cmsg;
				break;
			}
			case "Msg_2_3_":
			{
                //Msg_2_3_ cmsg = null;
                //if(_data!=null) cmsg = ProtoBuf.Serializer.Deserialize<Msg_2_3_>(new MemoryStream(_data));
                //Fun_Msg_2_3_(cmsg);
                //retIE=cmsg;
                break;
			}
			case "Msg_2_6_":
			{
				Msg_2_6_ cmsg = null;
				if(_data!=null) cmsg = ProtoBuf.Serializer.Deserialize<Msg_2_6_>(new MemoryStream(_data));
				Fun_Msg_2_6_(cmsg);
				retIE=cmsg;
				break;
			}
			//添加case 自动生成需要这行注释，不能删,不能改。  
        }
        //return retIE;
    }

    //下面部分手动处理
    //具体函数实现
    
    private void Fun_Msg_2_1_(Msg_2_1_ msg)
	{

	}

	private void Fun_Msg_2_2_(Msg_2_2_ msg)
	{
        //Msg_2_2_ testmsg = NetWorkManage.getInstance().getCurrMsg<Msg_2_2_>(dest, cmd);

    	//required int32 state = 1; //0-成功登录 1-为没有创建角色,2为已经登录在游戏中,3服务器查找角色失败,客户端强制退回到服务器选择界面  4 登录验证失败
	}

	
    //private void Fun_Msg_2_3_(Msg_2_3_ msg)
    //{
    //    /*
    //    //重置一些数据
    //    PBParseManage.getInstance().DestroyDict();
    //    MDrole.getInstance().Fun_Msg_3_1_(new Msg_3_1_());
    //    //
    //    //optional MLoginData loginData=1;
    //    MDrole.getInstance().setMrole(msg.loginData.role);
    //    MDgeneral.getInstance().updateGeneralInfo (msg.loginData.generalList);
    //    MDformation.getInstance().updateFormationInfo(msg.loginData.formation);
    //    MDbag.getInstance().updateBagInfo(msg.loginData.bagList);
    //    MDequip.getInstance().updateEquipInfo(msg.loginData.equipList);
    //    MDfuben.getInstance().updateFubenDataDict(msg.loginData.fubenList);
        
    //    //任务功能开启ID
    //    MDtask.getInstance().UpdateTaskDict(msg.loginData.taskList);
        
    //    MDepic.getInstance().UpdateEpicData(msg.loginData.epic);
    //    MDepic.getInstance().UpdateEpicScore(msg.loginData.epicScoreRecord);
    //    MDfashion.getInstance().updateFashionListInfo(msg.loginData.fashion);
    //    MDhorse.getInstance().updateHorseDictInfo(msg.loginData.horse);
    //    MDhorse.getInstance().updateCurrentHorseId(msg.loginData.currentHorseId);
    //    MDhorse.getInstance().updateTotalAttr(msg.loginData.horseTotalAttr);
    //    MDfixedactive.getInstance().SetHuaRongDaoData(msg.loginData.huaRongDao);
    //    //MDhorse.getInstance().updateTotalAttr(msg.loginData.horseTotalAttr);
    //    //帮会
    //    MDgang.getInstance().UpdateGangData(msg.loginData.mGang);
    //    MDactive.getInstance().UpdateActive(msg.loginData.activeData);
    //    MDactive.getInstance().UpdateActiveAward(msg.loginData.activeAwardData);
    //    MDactive.getInstance().UpdateGiftData(msg.loginData.activeGiftData);

    //    MDzhaocai.getInstance().setMZhaoCai(msg.loginData.zhaocai);
    //    //如果战斗没打完
    //    MDbattle.getInstance().LastBattleData = msg.loginData.battle;
    //    MDjiebao.getInstance().updateBox(msg.loginData.jieBaoObject);
    //    MDjiebao.getInstance().updateRoleJB(msg.loginData.roleJieBao);
    //    MDcompete.getInstance().SetScoreList(msg.loginData.competeScoreReward);
    //    MDvip.getInstance().SetVipReward(msg.loginData.vipReward);
    //    MDcheckin.getInstance().SetCheckInData(msg.loginData.checkin);
    //    startServerZeroTime = msg.loginData.startServerZeroTime;
    //    //登录成功主城id与位置
    //    if (msg.loginData.cityId != GD.PBDefault) cityId = msg.loginData.cityId;
    //    if (msg.loginData.cityLocation!=null)
    //    {
    //        mLocation.x = msg.loginData.cityLocation.x;
    //        mLocation.y = msg.loginData.cityLocation.y;
    //        //Debug.Log("mLocation==(" + mLocation.x + "," + mLocation.y+")");
    //    }
    //    //GDDebug.LogError("主城iddddd===" + cityId);

    //    MDfriend.getInstance().addFriendList(msg.loginData.goodFriends);
    //    MDfriend.getInstance().addApplyList(msg.loginData.applyFriends);
    //    MDmarried.getInstance().updateMarriageInfo(msg.loginData.married,false);
    //    MDmarried.getInstance().updateWeddingList(msg.loginData.worldWedding);
    //    MDmarried.getInstance().addBanquetList(msg.loginData.banquet);
    //    MDmail.getInstance().setUnreadMailCount(msg.loginData.mailCount);
    //    MDbagua.getInstance().SetBaguaData(msg.loginData.baGua);
        
    //    MDselfboss.getInstance().updateBoss(msg.loginData.selfboss);
    //    MDfixedactive.getInstance().updateTiliIdList(msg.loginData.tiliReward);
    //    MDmail.getInstance().updateGMMail(msg.loginData.isGMMail);
    //    MDfixedactive.getInstance().updateHongbao(msg.loginData.worldHongBao);

    //    MDgangbase.getInstance().setLianFuCount(msg.loginData.gangLianFuCount);
    //    MDgangbase.getInstance().setTurntableCount(msg.loginData.gangZPCount);
    //    MDgangboss.getInstance().setBossCount(msg.loginData.gangBossCount);
    //    MDsgml.getInstance().updateSgmlList(msg.loginData.sgmlDoor);

    //    MDfriend.getInstance().updateTiliFriendList(msg.loginData.friendTiLi);
    //    MDfriend.getInstance().setReceivableTili(msg.loginData.haveFriTiLi);
    //    MDfriend.getInstance().setReceivedTili(msg.loginData.receFriTiLi);
    //    MDtask.getInstance().SetShenQiInt(msg.loginData.sheQi);
    //     */
    //}

	private void Fun_Msg_2_6_(Msg_2_6_ msg)
	{
	}

	//添加Fun_函数 自动生成需要这行注释，不能删,不能改。
}