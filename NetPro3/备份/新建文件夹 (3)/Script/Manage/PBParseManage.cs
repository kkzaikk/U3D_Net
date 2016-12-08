using System;
using System.Collections.Generic;
using System.IO;

//协议解析、打包管理类
public class PBParseManage
{
    private static PBParseManage s_PBParseManage = null;
    public static PBParseManage getInstance()
    {
        if (s_PBParseManage == null)
        {
            s_PBParseManage = new PBParseManage();
            s_PBParseManage.Init();
        }
        return s_PBParseManage;
    }


    private Dictionary<string, PBParseBasic> dictPBParseBasic = new Dictionary<string, PBParseBasic>();

    public Dictionary<string, PBParseBasic> getPBdict()
    {
        return dictPBParseBasic;
    }
    //初始化
    public void Init()
    {
		dictPBParseBasic.Add("Msg_2_1_", MDaccount.getInstance());
		dictPBParseBasic.Add("Msg_2_2_", MDaccount.getInstance());
		dictPBParseBasic.Add("Msg_2_3_", MDaccount.getInstance());
		dictPBParseBasic.Add("Msg_2_6_", MDaccount.getInstance());

        /*
		dictPBParseBasic.Add("Msg_10_0_", MDactive.getInstance());
		dictPBParseBasic.Add("Msg_10_1_", MDactive.getInstance());
		dictPBParseBasic.Add("Msg_10_2_", MDactive.getInstance());
		dictPBParseBasic.Add("Msg_10_3_", MDactive.getInstance());
		dictPBParseBasic.Add("Msg_10_4_", MDactive.getInstance());
		dictPBParseBasic.Add("Msg_10_5_", MDactive.getInstance());
		dictPBParseBasic.Add("Msg_10_6_", MDactive.getInstance());
		dictPBParseBasic.Add("Msg_10_10_", MDactive.getInstance());
		dictPBParseBasic.Add("Msg_5_0_", MDbag.getInstance());
		dictPBParseBasic.Add("Msg_5_2_", MDbag.getInstance());
		dictPBParseBasic.Add("Msg_5_3_", MDbag.getInstance());
		dictPBParseBasic.Add("Msg_5_4_", MDbag.getInstance());
		dictPBParseBasic.Add("Msg_5_5_", MDbag.getInstance());
		dictPBParseBasic.Add("Msg_5_6_", MDbag.getInstance());
		dictPBParseBasic.Add("Msg_5_7_", MDbag.getInstance());
		dictPBParseBasic.Add("Msg_27_1_", MDbagua.getInstance());
		dictPBParseBasic.Add("Msg_27_2_", MDbagua.getInstance());
		dictPBParseBasic.Add("Msg_27_3_", MDbagua.getInstance());
		dictPBParseBasic.Add("Msg_27_4_", MDbagua.getInstance());
		dictPBParseBasic.Add("Msg_27_5_", MDbagua.getInstance());
		dictPBParseBasic.Add("Msg_11_1_", MDbattle.getInstance());
		dictPBParseBasic.Add("Msg_11_2_", MDbattle.getInstance());
		dictPBParseBasic.Add("Msg_11_3_", MDbattle.getInstance());
		dictPBParseBasic.Add("Msg_11_4_", MDbattle.getInstance());
		dictPBParseBasic.Add("Msg_11_5_", MDbattle.getInstance());
		dictPBParseBasic.Add("Msg_11_6_", MDbattle.getInstance());
		dictPBParseBasic.Add("Msg_4_1_", MDchat.getInstance());
		dictPBParseBasic.Add("Msg_4_2_", MDchat.getInstance());
		dictPBParseBasic.Add("Msg_4_3_", MDchat.getInstance());
		dictPBParseBasic.Add("Msg_4_4_", MDchat.getInstance());
		dictPBParseBasic.Add("Msg_4_5_", MDchat.getInstance());
		dictPBParseBasic.Add("Msg_4_6_", MDchat.getInstance());
		dictPBParseBasic.Add("Msg_4_7_", MDchat.getInstance());
		dictPBParseBasic.Add("Msg_4_8_", MDchat.getInstance());
		dictPBParseBasic.Add("Msg_34_1_", MDcheckin.getInstance());
		dictPBParseBasic.Add("Msg_34_2_", MDcheckin.getInstance());
		dictPBParseBasic.Add("Msg_34_3_", MDcheckin.getInstance());
		dictPBParseBasic.Add("Msg_34_4_", MDcheckin.getInstance());
		dictPBParseBasic.Add("Msg_34_5_", MDcheckin.getInstance());
		dictPBParseBasic.Add("Msg_34_6_", MDcheckin.getInstance());
		dictPBParseBasic.Add("Msg_1_1_", MDcommand.getInstance());
		dictPBParseBasic.Add("Msg_1_2_", MDcommand.getInstance());
		dictPBParseBasic.Add("Msg_1_3_", MDcommand.getInstance());
		dictPBParseBasic.Add("Msg_9_2_", MDcompete.getInstance());
		dictPBParseBasic.Add("Msg_9_3_", MDcompete.getInstance());
		dictPBParseBasic.Add("Msg_9_4_", MDcompete.getInstance());
		dictPBParseBasic.Add("Msg_9_5_", MDcompete.getInstance());
		dictPBParseBasic.Add("Msg_9_8_", MDcompete.getInstance());
		dictPBParseBasic.Add("Msg_9_10_", MDcompete.getInstance());
		dictPBParseBasic.Add("Msg_9_11_", MDcompete.getInstance());
		dictPBParseBasic.Add("Msg_13_1_", MDepic.getInstance());
		dictPBParseBasic.Add("Msg_13_2_", MDepic.getInstance());
		dictPBParseBasic.Add("Msg_13_3_", MDepic.getInstance());
		dictPBParseBasic.Add("Msg_13_4_", MDepic.getInstance());
		dictPBParseBasic.Add("Msg_13_5_", MDepic.getInstance());
		dictPBParseBasic.Add("Msg_13_6_", MDepic.getInstance());
		dictPBParseBasic.Add("Msg_13_7_", MDepic.getInstance());
		dictPBParseBasic.Add("Msg_13_8_", MDepic.getInstance());
		dictPBParseBasic.Add("Msg_8_0_", MDequip.getInstance());
		dictPBParseBasic.Add("Msg_8_1_", MDequip.getInstance());
		dictPBParseBasic.Add("Msg_8_2_", MDequip.getInstance());
		dictPBParseBasic.Add("Msg_8_3_", MDequip.getInstance());
		dictPBParseBasic.Add("Msg_8_4_", MDequip.getInstance());
		dictPBParseBasic.Add("Msg_8_5_", MDequip.getInstance());
		dictPBParseBasic.Add("Msg_8_6_", MDequip.getInstance());
		dictPBParseBasic.Add("Msg_8_7_", MDequip.getInstance());
		dictPBParseBasic.Add("Msg_8_8_", MDequip.getInstance());
		dictPBParseBasic.Add("Msg_38_1_", MDexchange.getInstance());
		dictPBParseBasic.Add("Msg_38_2_", MDexchange.getInstance());
		dictPBParseBasic.Add("Msg_38_3_", MDexchange.getInstance());
		dictPBParseBasic.Add("Msg_37_1_", MDfashion.getInstance());
		dictPBParseBasic.Add("Msg_37_2_", MDfashion.getInstance());
		dictPBParseBasic.Add("Msg_37_3_", MDfashion.getInstance());
		dictPBParseBasic.Add("Msg_37_4_", MDfashion.getInstance());
		dictPBParseBasic.Add("Msg_33_1_", MDfixedactive.getInstance());
		dictPBParseBasic.Add("Msg_33_2_", MDfixedactive.getInstance());
		dictPBParseBasic.Add("Msg_33_3_", MDfixedactive.getInstance());
		dictPBParseBasic.Add("Msg_33_4_", MDfixedactive.getInstance());
		dictPBParseBasic.Add("Msg_33_5_", MDfixedactive.getInstance());
		dictPBParseBasic.Add("Msg_33_6_", MDfixedactive.getInstance());
		dictPBParseBasic.Add("Msg_33_7_", MDfixedactive.getInstance());
		dictPBParseBasic.Add("Msg_33_8_", MDfixedactive.getInstance());
		dictPBParseBasic.Add("Msg_33_9_", MDfixedactive.getInstance());
		dictPBParseBasic.Add("Msg_33_10_", MDfixedactive.getInstance());
		dictPBParseBasic.Add("Msg_26_0_", MDformation.getInstance());
		dictPBParseBasic.Add("Msg_26_2_", MDformation.getInstance());
		dictPBParseBasic.Add("Msg_26_3_", MDformation.getInstance());
		dictPBParseBasic.Add("Msg_26_4_", MDformation.getInstance());
		dictPBParseBasic.Add("Msg_26_5_", MDformation.getInstance());
		dictPBParseBasic.Add("Msg_26_6_", MDformation.getInstance());
		dictPBParseBasic.Add("Msg_26_7_", MDformation.getInstance());
		dictPBParseBasic.Add("Msg_26_8_", MDformation.getInstance());
		dictPBParseBasic.Add("Msg_19_1_", MDfriend.getInstance());
		dictPBParseBasic.Add("Msg_19_2_", MDfriend.getInstance());
		dictPBParseBasic.Add("Msg_19_3_", MDfriend.getInstance());
		dictPBParseBasic.Add("Msg_19_4_", MDfriend.getInstance());
		dictPBParseBasic.Add("Msg_19_5_", MDfriend.getInstance());
		dictPBParseBasic.Add("Msg_19_6_", MDfriend.getInstance());
		dictPBParseBasic.Add("Msg_19_7_", MDfriend.getInstance());
		dictPBParseBasic.Add("Msg_19_8_", MDfriend.getInstance());
		dictPBParseBasic.Add("Msg_19_9_", MDfriend.getInstance());
		dictPBParseBasic.Add("Msg_19_10_", MDfriend.getInstance());
		dictPBParseBasic.Add("Msg_19_11_", MDfriend.getInstance());
		dictPBParseBasic.Add("Msg_19_12_", MDfriend.getInstance());
		dictPBParseBasic.Add("Msg_12_1_", MDfuben.getInstance());
		dictPBParseBasic.Add("Msg_12_2_", MDfuben.getInstance());
		dictPBParseBasic.Add("Msg_12_3_", MDfuben.getInstance());
		dictPBParseBasic.Add("Msg_12_4_", MDfuben.getInstance());
		dictPBParseBasic.Add("Msg_12_5_", MDfuben.getInstance());
		dictPBParseBasic.Add("Msg_12_6_", MDfuben.getInstance());
		dictPBParseBasic.Add("Msg_24_1_", MDgang.getInstance());
		dictPBParseBasic.Add("Msg_24_3_", MDgang.getInstance());
		dictPBParseBasic.Add("Msg_24_4_", MDgang.getInstance());
		dictPBParseBasic.Add("Msg_24_5_", MDgang.getInstance());
		dictPBParseBasic.Add("Msg_24_6_", MDgang.getInstance());
		dictPBParseBasic.Add("Msg_24_7_", MDgang.getInstance());
		dictPBParseBasic.Add("Msg_24_8_", MDgang.getInstance());
		dictPBParseBasic.Add("Msg_24_9_", MDgang.getInstance());
		dictPBParseBasic.Add("Msg_24_10_", MDgang.getInstance());
		dictPBParseBasic.Add("Msg_24_11_", MDgang.getInstance());
		dictPBParseBasic.Add("Msg_24_12_", MDgang.getInstance());
		dictPBParseBasic.Add("Msg_24_13_", MDgang.getInstance());
		dictPBParseBasic.Add("Msg_24_14_", MDgang.getInstance());
		dictPBParseBasic.Add("Msg_24_15_", MDgang.getInstance());
		dictPBParseBasic.Add("Msg_24_16_", MDgang.getInstance());
		dictPBParseBasic.Add("Msg_24_17_", MDgang.getInstance());
		dictPBParseBasic.Add("Msg_40_1_", MDgangbase.getInstance());
		dictPBParseBasic.Add("Msg_40_2_", MDgangbase.getInstance());
		dictPBParseBasic.Add("Msg_40_3_", MDgangbase.getInstance());
		dictPBParseBasic.Add("Msg_41_1_", MDgangboss.getInstance());
		dictPBParseBasic.Add("Msg_41_2_", MDgangboss.getInstance());
		dictPBParseBasic.Add("Msg_23_0_", MDgeneral.getInstance());
		dictPBParseBasic.Add("Msg_23_2_", MDgeneral.getInstance());
		dictPBParseBasic.Add("Msg_23_3_", MDgeneral.getInstance());
		dictPBParseBasic.Add("Msg_23_4_", MDgeneral.getInstance());
		dictPBParseBasic.Add("Msg_23_5_", MDgeneral.getInstance());
		dictPBParseBasic.Add("Msg_23_6_", MDgeneral.getInstance());
		dictPBParseBasic.Add("Msg_23_7_", MDgeneral.getInstance());
		dictPBParseBasic.Add("Msg_23_8_", MDgeneral.getInstance());
		dictPBParseBasic.Add("Msg_35_1_", MDhorse.getInstance());
		dictPBParseBasic.Add("Msg_35_2_", MDhorse.getInstance());
		dictPBParseBasic.Add("Msg_35_3_", MDhorse.getInstance());
		dictPBParseBasic.Add("Msg_35_4_", MDhorse.getInstance());
		dictPBParseBasic.Add("Msg_35_5_", MDhorse.getInstance());
		dictPBParseBasic.Add("Msg_35_6_", MDhorse.getInstance());
		dictPBParseBasic.Add("Msg_35_7_", MDhorse.getInstance());
		dictPBParseBasic.Add("Msg_35_8_", MDhorse.getInstance());
		dictPBParseBasic.Add("Msg_35_9_", MDhorse.getInstance());
		dictPBParseBasic.Add("Msg_35_10_", MDhorse.getInstance());
		dictPBParseBasic.Add("Msg_30_0_", MDjiebao.getInstance());
		dictPBParseBasic.Add("Msg_30_1_", MDjiebao.getInstance());
		dictPBParseBasic.Add("Msg_30_2_", MDjiebao.getInstance());
		dictPBParseBasic.Add("Msg_30_3_", MDjiebao.getInstance());
		dictPBParseBasic.Add("Msg_20_0_", MDmail.getInstance());
		dictPBParseBasic.Add("Msg_20_1_", MDmail.getInstance());
		dictPBParseBasic.Add("Msg_20_2_", MDmail.getInstance());
		dictPBParseBasic.Add("Msg_20_3_", MDmail.getInstance());
		dictPBParseBasic.Add("Msg_20_4_", MDmail.getInstance());
		dictPBParseBasic.Add("Msg_20_5_", MDmail.getInstance());
		dictPBParseBasic.Add("Msg_20_6_", MDmail.getInstance());
		dictPBParseBasic.Add("Msg_20_7_", MDmail.getInstance());
		dictPBParseBasic.Add("Msg_25_1_", MDmall.getInstance());
		dictPBParseBasic.Add("Msg_36_0_", MDmarried.getInstance());
		dictPBParseBasic.Add("Msg_36_1_", MDmarried.getInstance());
		dictPBParseBasic.Add("Msg_36_2_", MDmarried.getInstance());
		dictPBParseBasic.Add("Msg_36_3_", MDmarried.getInstance());
		dictPBParseBasic.Add("Msg_36_4_", MDmarried.getInstance());
		dictPBParseBasic.Add("Msg_36_5_", MDmarried.getInstance());
		dictPBParseBasic.Add("Msg_36_6_", MDmarried.getInstance());
		dictPBParseBasic.Add("Msg_36_7_", MDmarried.getInstance());
		dictPBParseBasic.Add("Msg_36_8_", MDmarried.getInstance());
		dictPBParseBasic.Add("Msg_36_9_", MDmarried.getInstance());
		dictPBParseBasic.Add("Msg_36_10_", MDmarried.getInstance());
		dictPBParseBasic.Add("Msg_36_11_", MDmarried.getInstance());
		dictPBParseBasic.Add("Msg_36_12_", MDmarried.getInstance());
		dictPBParseBasic.Add("Msg_36_13_", MDmarried.getInstance());
		dictPBParseBasic.Add("Msg_36_14_", MDmarried.getInstance());
		dictPBParseBasic.Add("Msg_36_15_", MDmarried.getInstance());
		dictPBParseBasic.Add("Msg_36_16_", MDmarried.getInstance());
		dictPBParseBasic.Add("Msg_36_17_", MDmarried.getInstance());
		dictPBParseBasic.Add("Msg_36_18_", MDmarried.getInstance());
		dictPBParseBasic.Add("Msg_36_19_", MDmarried.getInstance());
		dictPBParseBasic.Add("Msg_36_20_", MDmarried.getInstance());
		dictPBParseBasic.Add("Msg_36_21_", MDmarried.getInstance());
		dictPBParseBasic.Add("Msg_36_22_", MDmarried.getInstance());
		dictPBParseBasic.Add("Msg_36_23_", MDmarried.getInstance());
		dictPBParseBasic.Add("Msg_36_24_", MDmarried.getInstance());
		dictPBParseBasic.Add("Msg_36_25_", MDmarried.getInstance());
		dictPBParseBasic.Add("Msg_36_26_", MDmarried.getInstance());
		dictPBParseBasic.Add("Msg_36_27_", MDmarried.getInstance());
		dictPBParseBasic.Add("Msg_36_28_", MDmarried.getInstance());
		dictPBParseBasic.Add("Msg_36_29_", MDmarried.getInstance());
		dictPBParseBasic.Add("Msg_36_30_", MDmarried.getInstance());
		dictPBParseBasic.Add("Msg_36_31_", MDmarried.getInstance());
		dictPBParseBasic.Add("Msg_36_32_", MDmarried.getInstance());
		dictPBParseBasic.Add("Msg_36_33_", MDmarried.getInstance());
		dictPBParseBasic.Add("Msg_42_1_", MDqq.getInstance());
		dictPBParseBasic.Add("Msg_42_2_", MDqq.getInstance());
		dictPBParseBasic.Add("Msg_31_0_", MDrank.getInstance());
		dictPBParseBasic.Add("Msg_31_1_", MDrank.getInstance());
		dictPBParseBasic.Add("Msg_31_2_", MDrank.getInstance());
		dictPBParseBasic.Add("Msg_31_3_", MDrank.getInstance());
		dictPBParseBasic.Add("Msg_31_4_", MDrank.getInstance());
		dictPBParseBasic.Add("Msg_31_5_", MDrank.getInstance());
		dictPBParseBasic.Add("Msg_3_1_", MDrole.getInstance());
		dictPBParseBasic.Add("Msg_3_2_", MDrole.getInstance());
		dictPBParseBasic.Add("Msg_3_3_", MDrole.getInstance());
		dictPBParseBasic.Add("Msg_7_1_", MDscene.getInstance());
		dictPBParseBasic.Add("Msg_7_3_", MDscene.getInstance());
		dictPBParseBasic.Add("Msg_7_4_", MDscene.getInstance());
		dictPBParseBasic.Add("Msg_7_5_", MDscene.getInstance());
		dictPBParseBasic.Add("Msg_7_6_", MDscene.getInstance());
		dictPBParseBasic.Add("Msg_7_7_", MDscene.getInstance());
		dictPBParseBasic.Add("Msg_7_8_", MDscene.getInstance());
		dictPBParseBasic.Add("Msg_7_9_", MDscene.getInstance());
		dictPBParseBasic.Add("Msg_7_10_", MDscene.getInstance());
		dictPBParseBasic.Add("Msg_7_11_", MDscene.getInstance());
		dictPBParseBasic.Add("Msg_29_1_", MDselfboss.getInstance());
		dictPBParseBasic.Add("Msg_29_2_", MDselfboss.getInstance());
		dictPBParseBasic.Add("Msg_29_3_", MDselfboss.getInstance());
		dictPBParseBasic.Add("Msg_29_4_", MDselfboss.getInstance());
		dictPBParseBasic.Add("Msg_43_1_", MDsgml.getInstance());
		dictPBParseBasic.Add("Msg_43_2_", MDsgml.getInstance());
		dictPBParseBasic.Add("Msg_43_3_", MDsgml.getInstance());
		dictPBParseBasic.Add("Msg_22_0_", MDtask.getInstance());
		dictPBParseBasic.Add("Msg_22_1_", MDtask.getInstance());
		dictPBParseBasic.Add("Msg_22_2_", MDtask.getInstance());
		dictPBParseBasic.Add("Msg_6_1_", MDtip.getInstance());
		dictPBParseBasic.Add("Msg_14_1_", MDvip.getInstance());
		dictPBParseBasic.Add("Msg_28_0_", MDwulin.getInstance());
		dictPBParseBasic.Add("Msg_28_7_", MDwulin.getInstance());
		dictPBParseBasic.Add("Msg_28_8_", MDwulin.getInstance());
		dictPBParseBasic.Add("Msg_28_1_", MDwulin.getInstance());
		dictPBParseBasic.Add("Msg_28_2_", MDwulin.getInstance());
		dictPBParseBasic.Add("Msg_28_4_", MDwulin.getInstance());
		dictPBParseBasic.Add("Msg_28_5_", MDwulin.getInstance());
		dictPBParseBasic.Add("Msg_28_6_", MDwulin.getInstance());
		dictPBParseBasic.Add("Msg_32_1_", MDzhaocai.getInstance());
		dictPBParseBasic.Add("Msg_32_2_", MDzhaocai.getInstance());
		dictPBParseBasic.Add("Msg_44_1_", MDfubenExtend.getInstance());
		dictPBParseBasic.Add("Msg_44_2_", MDfubenExtend.getInstance());
		dictPBParseBasic.Add("Msg_44_3_", MDfubenExtend.getInstance());
		dictPBParseBasic.Add("Msg_44_4_", MDfubenExtend.getInstance());
		dictPBParseBasic.Add("Msg_44_5_", MDfubenExtend.getInstance());
		dictPBParseBasic.Add("Msg_22_3_", MDtask.getInstance());
		dictPBParseBasic.Add("Msg_33_11_", MDfixedactive.getInstance());
		dictPBParseBasic.Add("Msg_33_12_", MDfixedactive.getInstance());
		dictPBParseBasic.Add("Msg_45_1_", MDgangWar.getInstance());
		dictPBParseBasic.Add("Msg_45_2_", MDgangWar.getInstance());
		dictPBParseBasic.Add("Msg_45_3_", MDgangWar.getInstance());
		dictPBParseBasic.Add("Msg_45_4_", MDgangWar.getInstance());
		dictPBParseBasic.Add("Msg_7_12_", MDscene.getInstance());*/
		//添加注册
        //初始化
        InitDict();
        
    }

    //初始化
    public void InitDict()
    {
        foreach (var pb in dictPBParseBasic)
        {
            pb.Value.Init();
        }
    }

    //清除数据
    public void DestroyDict()
    {
        foreach (var pb in dictPBParseBasic)
        {
            pb.Value.Destroy();
        }
    }


    ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    //解析协议
    public void ParseData(int dest, int cmd, byte[] _data)
    {
        string msgindex = "Msg_";
        msgindex += dest + "_";
        msgindex += cmd + "_";
        if (dictPBParseBasic.ContainsKey(msgindex))
        {
            dictPBParseBasic[msgindex].ParseData(msgindex, _data);
        }
        else
        {
            // no add!!!!!!!!!!!!!!!
        }
    }

    //打包协议
    public static byte[] getSerialize<T>(T instance) where T : global::ProtoBuf.IExtensible
    {
        MemoryStream memStream = new MemoryStream();
        ProtoBuf.Serializer.Serialize<T>(memStream, instance);
        return memStream.ToArray();
    }
    /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
}