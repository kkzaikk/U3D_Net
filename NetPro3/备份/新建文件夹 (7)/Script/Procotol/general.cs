//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: general.proto
// Note: requires additional types generated from: serverbase.proto
namespace com.protobuf
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"MGeneral")]
  public partial class MGeneral : global::ProtoBuf.IExtensible
  {
    public MGeneral() {}
    
    private long _id = default(long);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(long))]
    public long id
    {
      get { return _id; }
      set { _id = value; }
    }
    private int _sysId = (int)-1;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"sysId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)-1)]
    public int sysId
    {
      get { return _sysId; }
      set { _sysId = value; }
    }
    private int _level = (int)-1;
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"level", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)-1)]
    public int level
    {
      get { return _level; }
      set { _level = value; }
    }
    private long _exp = (long)-1;
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"exp", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((long)-1)]
    public long exp
    {
      get { return _exp; }
      set { _exp = value; }
    }
    private int _strength = (int)-1;
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"strength", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)-1)]
    public int strength
    {
      get { return _strength; }
      set { _strength = value; }
    }
    private com.protobuf.MBaseGeneral _baseGeneral = null;
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"baseGeneral", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public com.protobuf.MBaseGeneral baseGeneral
    {
      get { return _baseGeneral; }
      set { _baseGeneral = value; }
    }
    private readonly global::System.Collections.Generic.List<int> _skill = new global::System.Collections.Generic.List<int>();
    [global::ProtoBuf.ProtoMember(7, Name=@"skill", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public global::System.Collections.Generic.List<int> skill
    {
      get { return _skill; }
    }
  
    private readonly global::System.Collections.Generic.List<int> _fettersSkill = new global::System.Collections.Generic.List<int>();
    [global::ProtoBuf.ProtoMember(8, Name=@"fettersSkill", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public global::System.Collections.Generic.List<int> fettersSkill
    {
      get { return _fettersSkill; }
    }
  
    private readonly global::System.Collections.Generic.List<int> _equip = new global::System.Collections.Generic.List<int>();
    [global::ProtoBuf.ProtoMember(9, Name=@"equip", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public global::System.Collections.Generic.List<int> equip
    {
      get { return _equip; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"Msg_23_0_")]
  public partial class Msg_23_0_ : global::ProtoBuf.IExtensible
  {
    public Msg_23_0_() {}
    
    private readonly global::System.Collections.Generic.List<com.protobuf.MGeneral> _general = new global::System.Collections.Generic.List<com.protobuf.MGeneral>();
    [global::ProtoBuf.ProtoMember(1, Name=@"general", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<com.protobuf.MGeneral> general
    {
      get { return _general; }
    }
  
    private int _tip = (int)0;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"tip", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)0)]
    public int tip
    {
      get { return _tip; }
      set { _tip = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"Msg_23_2")]
  public partial class Msg_23_2 : global::ProtoBuf.IExtensible
  {
    public Msg_23_2() {}
    
    private int _gid = default(int);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"gid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int gid
    {
      get { return _gid; }
      set { _gid = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"Msg_23_2_")]
  public partial class Msg_23_2_ : global::ProtoBuf.IExtensible
  {
    public Msg_23_2_() {}
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"Msg_23_3")]
  public partial class Msg_23_3 : global::ProtoBuf.IExtensible
  {
    public Msg_23_3() {}
    
    private long _id = default(long);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(long))]
    public long id
    {
      get { return _id; }
      set { _id = value; }
    }
    private int _itemId = default(int);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"itemId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int itemId
    {
      get { return _itemId; }
      set { _itemId = value; }
    }
    private int _number = default(int);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"number", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"Msg_23_3_")]
  public partial class Msg_23_3_ : global::ProtoBuf.IExtensible
  {
    public Msg_23_3_() {}
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"Msg_23_4")]
  public partial class Msg_23_4 : global::ProtoBuf.IExtensible
  {
    public Msg_23_4() {}
    
    private long _id = default(long);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(long))]
    public long id
    {
      get { return _id; }
      set { _id = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"Msg_23_4_")]
  public partial class Msg_23_4_ : global::ProtoBuf.IExtensible
  {
    public Msg_23_4_() {}
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"Msg_23_5")]
  public partial class Msg_23_5 : global::ProtoBuf.IExtensible
  {
    public Msg_23_5() {}
    
    private long _id = default(long);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(long))]
    public long id
    {
      get { return _id; }
      set { _id = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"Msg_23_5_")]
  public partial class Msg_23_5_ : global::ProtoBuf.IExtensible
  {
    public Msg_23_5_() {}
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}