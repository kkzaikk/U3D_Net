//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: goodExchange.proto
// Note: requires additional types generated from: object.proto
namespace com.protobuf
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"MGoodExchange")]
  public partial class MGoodExchange : global::ProtoBuf.IExtensible
  {
    public MGoodExchange() {}
    
    private int _exchangeId = default(int);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"exchangeId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int exchangeId
    {
      get { return _exchangeId; }
      set { _exchangeId = value; }
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
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"Msg_39_1")]
  public partial class Msg_39_1 : global::ProtoBuf.IExtensible
  {
    public Msg_39_1() {}
    
    private int _exchangeId = default(int);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"exchangeId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int exchangeId
    {
      get { return _exchangeId; }
      set { _exchangeId = value; }
    }
    private readonly global::System.Collections.Generic.List<long> _targetId = new global::System.Collections.Generic.List<long>();
    [global::ProtoBuf.ProtoMember(2, Name=@"targetId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public global::System.Collections.Generic.List<long> targetId
    {
      get { return _targetId; }
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
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"Msg_39_1_")]
  public partial class Msg_39_1_ : global::ProtoBuf.IExtensible
  {
    public Msg_39_1_() {}
    
    private readonly global::System.Collections.Generic.List<com.protobuf.MDropGood> _goodList = new global::System.Collections.Generic.List<com.protobuf.MDropGood>();
    [global::ProtoBuf.ProtoMember(1, Name=@"goodList", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<com.protobuf.MDropGood> goodList
    {
      get { return _goodList; }
    }
  
    private com.protobuf.MGoodExchange _goodExchange = null;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"goodExchange", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public com.protobuf.MGoodExchange goodExchange
    {
      get { return _goodExchange; }
      set { _goodExchange = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}