//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: horse.proto
namespace com.protobuf
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"MHorse")]
  public partial class MHorse : global::ProtoBuf.IExtensible
  {
    public MHorse() {}
    
    private int _level = default(int);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"level", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int level
    {
      get { return _level; }
      set { _level = value; }
    }
    private int _exp = default(int);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"exp", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int exp
    {
      get { return _exp; }
      set { _exp = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"Msg_33_0_")]
  public partial class Msg_33_0_ : global::ProtoBuf.IExtensible
  {
    public Msg_33_0_() {}
    
    private com.protobuf.MHorse _horse = null;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"horse", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public com.protobuf.MHorse horse
    {
      get { return _horse; }
      set { _horse = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"Msg_33_1")]
  public partial class Msg_33_1 : global::ProtoBuf.IExtensible
  {
    public Msg_33_1() {}
    
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
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"Msg_33_1_")]
  public partial class Msg_33_1_ : global::ProtoBuf.IExtensible
  {
    public Msg_33_1_() {}
    
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
  
}