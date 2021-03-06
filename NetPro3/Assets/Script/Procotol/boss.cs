//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: boss.proto
// Note: requires additional types generated from: object.proto
namespace com.protobuf
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"MBoss")]
  public partial class MBoss : global::ProtoBuf.IExtensible
  {
    public MBoss() {}
    
    private int _monsterId = default(int);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"monsterId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int monsterId
    {
      get { return _monsterId; }
      set { _monsterId = value; }
    }
    private long _hp = default(long);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"hp", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(long))]
    public long hp
    {
      get { return _hp; }
      set { _hp = value; }
    }
    private int _status = default(int);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"status", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int status
    {
      get { return _status; }
      set { _status = value; }
    }
    private string _killerName = "";
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"killerName", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string killerName
    {
      get { return _killerName; }
      set { _killerName = value; }
    }
    private string _name = "";
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string name
    {
      get { return _name; }
      set { _name = value; }
    }
    private int _cardId = default(int);
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"cardId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int cardId
    {
      get { return _cardId; }
      set { _cardId = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"MDamageOrder")]
  public partial class MDamageOrder : global::ProtoBuf.IExtensible
  {
    public MDamageOrder() {}
    
    private string _name = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string name
    {
      get { return _name; }
      set { _name = value; }
    }
    private long _damage = default(long);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"damage", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(long))]
    public long damage
    {
      get { return _damage; }
      set { _damage = value; }
    }
    private int _order = default(int);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"order", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int order
    {
      get { return _order; }
      set { _order = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"MBossRecord")]
  public partial class MBossRecord : global::ProtoBuf.IExtensible
  {
    public MBossRecord() {}
    
    private long _damage = default(long);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"damage", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(long))]
    public long damage
    {
      get { return _damage; }
      set { _damage = value; }
    }
    private long _reliveTime = default(long);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"reliveTime", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(long))]
    public long reliveTime
    {
      get { return _reliveTime; }
      set { _reliveTime = value; }
    }
    private int _order = default(int);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"order", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int order
    {
      get { return _order; }
      set { _order = value; }
    }
    private int _auto = default(int);
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"auto", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int auto
    {
      get { return _auto; }
      set { _auto = value; }
    }
    private int _rewardOrder = default(int);
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"rewardOrder", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int rewardOrder
    {
      get { return _rewardOrder; }
      set { _rewardOrder = value; }
    }
    private readonly global::System.Collections.Generic.List<com.protobuf.MDropGood> _killReward = new global::System.Collections.Generic.List<com.protobuf.MDropGood>();
    [global::ProtoBuf.ProtoMember(6, Name=@"killReward", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<com.protobuf.MDropGood> killReward
    {
      get { return _killReward; }
    }
  
    private int _killRewardStatus = default(int);
    [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"killRewardStatus", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int killRewardStatus
    {
      get { return _killRewardStatus; }
      set { _killRewardStatus = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"Msg_21_0")]
  public partial class Msg_21_0 : global::ProtoBuf.IExtensible
  {
    public Msg_21_0() {}
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"Msg_21_0_")]
  public partial class Msg_21_0_ : global::ProtoBuf.IExtensible
  {
    public Msg_21_0_() {}
    
    private readonly global::System.Collections.Generic.List<com.protobuf.MDamageOrder> _damageOrder = new global::System.Collections.Generic.List<com.protobuf.MDamageOrder>();
    [global::ProtoBuf.ProtoMember(1, Name=@"damageOrder", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<com.protobuf.MDamageOrder> damageOrder
    {
      get { return _damageOrder; }
    }
  
    private com.protobuf.MBoss _boss = null;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"boss", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public com.protobuf.MBoss boss
    {
      get { return _boss; }
      set { _boss = value; }
    }
    private com.protobuf.MBossRecord _bossRecord = null;
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"bossRecord", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public com.protobuf.MBossRecord bossRecord
    {
      get { return _bossRecord; }
      set { _bossRecord = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"Msg_21_1")]
  public partial class Msg_21_1 : global::ProtoBuf.IExtensible
  {
    public Msg_21_1() {}
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"Msg_21_1_")]
  public partial class Msg_21_1_ : global::ProtoBuf.IExtensible
  {
    public Msg_21_1_() {}
    
    private long _damage = default(long);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"damage", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(long))]
    public long damage
    {
      get { return _damage; }
      set { _damage = value; }
    }
    private int _isDead = default(int);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"isDead", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int isDead
    {
      get { return _isDead; }
      set { _isDead = value; }
    }
    private long _reliveTime = default(long);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"reliveTime", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(long))]
    public long reliveTime
    {
      get { return _reliveTime; }
      set { _reliveTime = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"Msg_21_2")]
  public partial class Msg_21_2 : global::ProtoBuf.IExtensible
  {
    public Msg_21_2() {}
    
    private int _type = default(int);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int type
    {
      get { return _type; }
      set { _type = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"Msg_21_2_")]
  public partial class Msg_21_2_ : global::ProtoBuf.IExtensible
  {
    public Msg_21_2_() {}
    
    private int _type = default(int);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int type
    {
      get { return _type; }
      set { _type = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"Msg_21_4")]
  public partial class Msg_21_4 : global::ProtoBuf.IExtensible
  {
    public Msg_21_4() {}
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"Msg_21_4_")]
  public partial class Msg_21_4_ : global::ProtoBuf.IExtensible
  {
    public Msg_21_4_() {}
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"Msg_21_5_")]
  public partial class Msg_21_5_ : global::ProtoBuf.IExtensible
  {
    public Msg_21_5_() {}
    
    private readonly global::System.Collections.Generic.List<com.protobuf.MDamageOrder> _damageOrder = new global::System.Collections.Generic.List<com.protobuf.MDamageOrder>();
    [global::ProtoBuf.ProtoMember(1, Name=@"damageOrder", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<com.protobuf.MDamageOrder> damageOrder
    {
      get { return _damageOrder; }
    }
  
    private long _hp = default(long);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"hp", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(long))]
    public long hp
    {
      get { return _hp; }
      set { _hp = value; }
    }
    private long _damage = default(long);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"damage", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(long))]
    public long damage
    {
      get { return _damage; }
      set { _damage = value; }
    }
    private int _order = default(int);
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"order", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int order
    {
      get { return _order; }
      set { _order = value; }
    }
    private string _name = "";
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string name
    {
      get { return _name; }
      set { _name = value; }
    }
    private int _color = default(int);
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"color", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int color
    {
      get { return _color; }
      set { _color = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"Msg_21_6_")]
  public partial class Msg_21_6_ : global::ProtoBuf.IExtensible
  {
    public Msg_21_6_() {}
    
    private string _killerName = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"killerName", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string killerName
    {
      get { return _killerName; }
      set { _killerName = value; }
    }
    private int _rewardOrder = default(int);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"rewardOrder", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int rewardOrder
    {
      get { return _rewardOrder; }
      set { _rewardOrder = value; }
    }
    private readonly global::System.Collections.Generic.List<com.protobuf.MDropGood> _killReward = new global::System.Collections.Generic.List<com.protobuf.MDropGood>();
    [global::ProtoBuf.ProtoMember(3, Name=@"killReward", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<com.protobuf.MDropGood> killReward
    {
      get { return _killReward; }
    }
  
    private int _auto = default(int);
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"auto", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int auto
    {
      get { return _auto; }
      set { _auto = value; }
    }
    private int _monsterId = default(int);
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"monsterId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int monsterId
    {
      get { return _monsterId; }
      set { _monsterId = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"Msg_21_7")]
  public partial class Msg_21_7 : global::ProtoBuf.IExtensible
  {
    public Msg_21_7() {}
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"Msg_21_7_")]
  public partial class Msg_21_7_ : global::ProtoBuf.IExtensible
  {
    public Msg_21_7_() {}
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"Msg_21_8_")]
  public partial class Msg_21_8_ : global::ProtoBuf.IExtensible
  {
    public Msg_21_8_() {}
    
    private string _name = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string name
    {
      get { return _name; }
      set { _name = value; }
    }
    private string _killerName = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"killerName", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string killerName
    {
      get { return _killerName; }
      set { _killerName = value; }
    }
    private int _cardId = default(int);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"cardId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int cardId
    {
      get { return _cardId; }
      set { _cardId = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}