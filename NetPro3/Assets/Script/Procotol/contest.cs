//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: contest.proto
namespace com.protobuf
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"MXuanBoOrder")]
  public partial class MXuanBoOrder : global::ProtoBuf.IExtensible
  {
    public MXuanBoOrder() {}
    
    private string _name = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string name
    {
      get { return _name; }
      set { _name = value; }
    }
    private int _damage = default(int);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"damage", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int damage
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
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"MContestRole")]
  public partial class MContestRole : global::ProtoBuf.IExtensible
  {
    public MContestRole() {}
    
    private long _id = default(long);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(long))]
    public long id
    {
      get { return _id; }
      set { _id = value; }
    }
    private string _name = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string name
    {
      get { return _name; }
      set { _name = value; }
    }
    private int _level = default(int);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"level", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int level
    {
      get { return _level; }
      set { _level = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"MContest")]
  public partial class MContest : global::ProtoBuf.IExtensible
  {
    public MContest() {}
    
    private int _id = default(int);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int id
    {
      get { return _id; }
      set { _id = value; }
    }
    private com.protobuf.MContestRole _role = null;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"role", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public com.protobuf.MContestRole role
    {
      get { return _role; }
      set { _role = value; }
    }
    private com.protobuf.MContestRole _targetRole = null;
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"targetRole", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public com.protobuf.MContestRole targetRole
    {
      get { return _targetRole; }
      set { _targetRole = value; }
    }
    private long _battleId = default(long);
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"battleId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(long))]
    public long battleId
    {
      get { return _battleId; }
      set { _battleId = value; }
    }
    private int _result = default(int);
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"result", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int result
    {
      get { return _result; }
      set { _result = value; }
    }
    private int _stage = default(int);
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"stage", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int stage
    {
      get { return _stage; }
      set { _stage = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"Msg_30_1")]
  public partial class Msg_30_1 : global::ProtoBuf.IExtensible
  {
    public Msg_30_1() {}
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"Msg_30_1_")]
  public partial class Msg_30_1_ : global::ProtoBuf.IExtensible
  {
    public Msg_30_1_() {}
    
    private readonly global::System.Collections.Generic.List<com.protobuf.MContest> _contestList = new global::System.Collections.Generic.List<com.protobuf.MContest>();
    [global::ProtoBuf.ProtoMember(1, Name=@"contestList", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<com.protobuf.MContest> contestList
    {
      get { return _contestList; }
    }
  
    private readonly global::System.Collections.Generic.List<com.protobuf.MContest> _lastContestList = new global::System.Collections.Generic.List<com.protobuf.MContest>();
    [global::ProtoBuf.ProtoMember(2, Name=@"lastContestList", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<com.protobuf.MContest> lastContestList
    {
      get { return _lastContestList; }
    }
  
    private readonly global::System.Collections.Generic.List<com.protobuf.MXuanBoOrder> _xuanBoOrderList = new global::System.Collections.Generic.List<com.protobuf.MXuanBoOrder>();
    [global::ProtoBuf.ProtoMember(3, Name=@"xuanBoOrderList", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<com.protobuf.MXuanBoOrder> xuanBoOrderList
    {
      get { return _xuanBoOrderList; }
    }
  
    private int _damage = default(int);
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"damage", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int damage
    {
      get { return _damage; }
      set { _damage = value; }
    }
    private int _contestRewardId = default(int);
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"contestRewardId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int contestRewardId
    {
      get { return _contestRewardId; }
      set { _contestRewardId = value; }
    }
    private int _order = default(int);
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"order", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int order
    {
      get { return _order; }
      set { _order = value; }
    }
    private int _praiseRewardType = default(int);
    [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"praiseRewardType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int praiseRewardType
    {
      get { return _praiseRewardType; }
      set { _praiseRewardType = value; }
    }
    private int _praiseResult = default(int);
    [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"praiseResult", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int praiseResult
    {
      get { return _praiseResult; }
      set { _praiseResult = value; }
    }
    private int _praiseType = default(int);
    [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"praiseType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int praiseType
    {
      get { return _praiseType; }
      set { _praiseType = value; }
    }
    private long _praiseTargetId = default(long);
    [global::ProtoBuf.ProtoMember(10, IsRequired = false, Name=@"praiseTargetId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(long))]
    public long praiseTargetId
    {
      get { return _praiseTargetId; }
      set { _praiseTargetId = value; }
    }
    private int _contestStatus = default(int);
    [global::ProtoBuf.ProtoMember(11, IsRequired = false, Name=@"contestStatus", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int contestStatus
    {
      get { return _contestStatus; }
      set { _contestStatus = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"Msg_30_2")]
  public partial class Msg_30_2 : global::ProtoBuf.IExtensible
  {
    public Msg_30_2() {}
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"Msg_30_2_")]
  public partial class Msg_30_2_ : global::ProtoBuf.IExtensible
  {
    public Msg_30_2_() {}
    
    private int _damage = default(int);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"damage", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int damage
    {
      get { return _damage; }
      set { _damage = value; }
    }
    private int _order = default(int);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"order", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"Msg_30_3_")]
  public partial class Msg_30_3_ : global::ProtoBuf.IExtensible
  {
    public Msg_30_3_() {}
    
    private readonly global::System.Collections.Generic.List<com.protobuf.MXuanBoOrder> _xuanBoOrderList = new global::System.Collections.Generic.List<com.protobuf.MXuanBoOrder>();
    [global::ProtoBuf.ProtoMember(1, Name=@"xuanBoOrderList", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<com.protobuf.MXuanBoOrder> xuanBoOrderList
    {
      get { return _xuanBoOrderList; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"Msg_30_4_")]
  public partial class Msg_30_4_ : global::ProtoBuf.IExtensible
  {
    public Msg_30_4_() {}
    
    private readonly global::System.Collections.Generic.List<com.protobuf.MContest> _contestList = new global::System.Collections.Generic.List<com.protobuf.MContest>();
    [global::ProtoBuf.ProtoMember(1, Name=@"contestList", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<com.protobuf.MContest> contestList
    {
      get { return _contestList; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"Msg_30_5_")]
  public partial class Msg_30_5_ : global::ProtoBuf.IExtensible
  {
    public Msg_30_5_() {}
    
    private readonly global::System.Collections.Generic.List<com.protobuf.MContest> _lastContestList = new global::System.Collections.Generic.List<com.protobuf.MContest>();
    [global::ProtoBuf.ProtoMember(1, Name=@"lastContestList", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<com.protobuf.MContest> lastContestList
    {
      get { return _lastContestList; }
    }
  
    private int _contestRewardId = default(int);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"contestRewardId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int contestRewardId
    {
      get { return _contestRewardId; }
      set { _contestRewardId = value; }
    }
    private int _praiseRewardType = default(int);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"praiseRewardType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int praiseRewardType
    {
      get { return _praiseRewardType; }
      set { _praiseRewardType = value; }
    }
    private int _praiseResult = default(int);
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"praiseResult", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int praiseResult
    {
      get { return _praiseResult; }
      set { _praiseResult = value; }
    }
    private int _praiseType = default(int);
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"praiseType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int praiseType
    {
      get { return _praiseType; }
      set { _praiseType = value; }
    }
    private long _praiseTargetId = default(long);
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"praiseTargetId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(long))]
    public long praiseTargetId
    {
      get { return _praiseTargetId; }
      set { _praiseTargetId = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"Msg_30_6")]
  public partial class Msg_30_6 : global::ProtoBuf.IExtensible
  {
    public Msg_30_6() {}
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"Msg_30_6_")]
  public partial class Msg_30_6_ : global::ProtoBuf.IExtensible
  {
    public Msg_30_6_() {}
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"Msg_30_7")]
  public partial class Msg_30_7 : global::ProtoBuf.IExtensible
  {
    public Msg_30_7() {}
    
    private long _targetId = default(long);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"targetId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(long))]
    public long targetId
    {
      get { return _targetId; }
      set { _targetId = value; }
    }
    private int _praiseType = default(int);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"praiseType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int praiseType
    {
      get { return _praiseType; }
      set { _praiseType = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"Msg_30_7_")]
  public partial class Msg_30_7_ : global::ProtoBuf.IExtensible
  {
    public Msg_30_7_() {}
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"Msg_30_8")]
  public partial class Msg_30_8 : global::ProtoBuf.IExtensible
  {
    public Msg_30_8() {}
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"Msg_30_8_")]
  public partial class Msg_30_8_ : global::ProtoBuf.IExtensible
  {
    public Msg_30_8_() {}
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"Msg_30_9_")]
  public partial class Msg_30_9_ : global::ProtoBuf.IExtensible
  {
    public Msg_30_9_() {}
    
    private int _contestStatus = default(int);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"contestStatus", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int contestStatus
    {
      get { return _contestStatus; }
      set { _contestStatus = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"Msg_30_10")]
  public partial class Msg_30_10 : global::ProtoBuf.IExtensible
  {
    public Msg_30_10() {}
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"Msg_30_10_")]
  public partial class Msg_30_10_ : global::ProtoBuf.IExtensible
  {
    public Msg_30_10_() {}
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}