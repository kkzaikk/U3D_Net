//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: equip.proto
// Note: requires additional types generated from: object.proto
namespace com.protobuf
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"MEquip")]
  public partial class MEquip : global::ProtoBuf.IExtensible
  {
    public MEquip() {}
    
    private long _id = default(long);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(long))]
    public long id
    {
      get { return _id; }
      set { _id = value; }
    }
    private int _sysId = default(int);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"sysId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int sysId
    {
      get { return _sysId; }
      set { _sysId = value; }
    }
    private int _strength = default(int);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"strength", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int strength
    {
      get { return _strength; }
      set { _strength = value; }
    }
    private int _starLevel = default(int);
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"starLevel", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int starLevel
    {
      get { return _starLevel; }
      set { _starLevel = value; }
    }
    private int _location = default(int);
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"location", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int location
    {
      get { return _location; }
      set { _location = value; }
    }
    private int _strengthLevel = default(int);
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"strengthLevel", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int strengthLevel
    {
      get { return _strengthLevel; }
      set { _strengthLevel = value; }
    }
    private com.protobuf.MFightAttr _fightAttr = null;
    [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"fightAttr", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public com.protobuf.MFightAttr fightAttr
    {
      get { return _fightAttr; }
      set { _fightAttr = value; }
    }
    private readonly global::System.Collections.Generic.List<com.protobuf.MEquipXiLian> _equipXiLian = new global::System.Collections.Generic.List<com.protobuf.MEquipXiLian>();
    [global::ProtoBuf.ProtoMember(8, Name=@"equipXiLian", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<com.protobuf.MEquipXiLian> equipXiLian
    {
      get { return _equipXiLian; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"MEquipXiLian")]
  public partial class MEquipXiLian : global::ProtoBuf.IExtensible
  {
    public MEquipXiLian() {}
    
    private int _type = default(int);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int type
    {
      get { return _type; }
      set { _type = value; }
    }
    private float _value = default(float);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"value", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    [global::System.ComponentModel.DefaultValue(default(float))]
    public float value
    {
      get { return _value; }
      set { _value = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"MEquipShard")]
  public partial class MEquipShard : global::ProtoBuf.IExtensible
  {
    public MEquipShard() {}
    
    private int _sysId = default(int);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"sysId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int sysId
    {
      get { return _sysId; }
      set { _sysId = value; }
    }
    private int _number = default(int);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"number", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int number
    {
      get { return _number; }
      set { _number = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"Msg_8_0_")]
  public partial class Msg_8_0_ : global::ProtoBuf.IExtensible
  {
    public Msg_8_0_() {}
    
    private readonly global::System.Collections.Generic.List<com.protobuf.MEquip> _equip = new global::System.Collections.Generic.List<com.protobuf.MEquip>();
    [global::ProtoBuf.ProtoMember(1, Name=@"equip", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<com.protobuf.MEquip> equip
    {
      get { return _equip; }
    }
  
    private int _tipRes = default(int);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"tipRes", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int tipRes
    {
      get { return _tipRes; }
      set { _tipRes = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"Msg_8_1_")]
  public partial class Msg_8_1_ : global::ProtoBuf.IExtensible
  {
    public Msg_8_1_() {}
    
    private readonly global::System.Collections.Generic.List<long> _id = new global::System.Collections.Generic.List<long>();
    [global::ProtoBuf.ProtoMember(1, Name=@"id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public global::System.Collections.Generic.List<long> id
    {
      get { return _id; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"Msg_8_2_")]
  public partial class Msg_8_2_ : global::ProtoBuf.IExtensible
  {
    public Msg_8_2_() {}
    
    private readonly global::System.Collections.Generic.List<com.protobuf.MEquipShard> _equipShard = new global::System.Collections.Generic.List<com.protobuf.MEquipShard>();
    [global::ProtoBuf.ProtoMember(1, Name=@"equipShard", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<com.protobuf.MEquipShard> equipShard
    {
      get { return _equipShard; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"Msg_8_3")]
  public partial class Msg_8_3 : global::ProtoBuf.IExtensible
  {
    public Msg_8_3() {}
    
    private long _id = default(long);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(long))]
    public long id
    {
      get { return _id; }
      set { _id = value; }
    }
    private int _formationIndex = default(int);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"formationIndex", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int formationIndex
    {
      get { return _formationIndex; }
      set { _formationIndex = value; }
    }
    private int _type = default(int);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"Msg_8_3_")]
  public partial class Msg_8_3_ : global::ProtoBuf.IExtensible
  {
    public Msg_8_3_() {}
    
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
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"Msg_8_4")]
  public partial class Msg_8_4 : global::ProtoBuf.IExtensible
  {
    public Msg_8_4() {}
    
    private long _id = default(long);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(long))]
    public long id
    {
      get { return _id; }
      set { _id = value; }
    }
    private int _count = default(int);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"count", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int count
    {
      get { return _count; }
      set { _count = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"Msg_8_4_")]
  public partial class Msg_8_4_ : global::ProtoBuf.IExtensible
  {
    public Msg_8_4_() {}
    
    private int _bombCount = default(int);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"bombCount", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int bombCount
    {
      get { return _bombCount; }
      set { _bombCount = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"Msg_8_5")]
  public partial class Msg_8_5 : global::ProtoBuf.IExtensible
  {
    public Msg_8_5() {}
    
    private long _id = default(long);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(long))]
    public long id
    {
      get { return _id; }
      set { _id = value; }
    }
    private readonly global::System.Collections.Generic.List<long> _idList = new global::System.Collections.Generic.List<long>();
    [global::ProtoBuf.ProtoMember(2, Name=@"idList", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public global::System.Collections.Generic.List<long> idList
    {
      get { return _idList; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"Msg_8_5_")]
  public partial class Msg_8_5_ : global::ProtoBuf.IExtensible
  {
    public Msg_8_5_() {}
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"Msg_8_6")]
  public partial class Msg_8_6 : global::ProtoBuf.IExtensible
  {
    public Msg_8_6() {}
    
    private long _id = default(long);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(long))]
    public long id
    {
      get { return _id; }
      set { _id = value; }
    }
    private int _type = default(int);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int type
    {
      get { return _type; }
      set { _type = value; }
    }
    private int _count = default(int);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"count", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int count
    {
      get { return _count; }
      set { _count = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"Msg_8_6_")]
  public partial class Msg_8_6_ : global::ProtoBuf.IExtensible
  {
    public Msg_8_6_() {}
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}