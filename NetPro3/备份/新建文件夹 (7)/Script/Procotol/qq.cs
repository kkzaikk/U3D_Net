//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: qq.proto
namespace com.protobuf
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"Msg_42_1")]
  public partial class Msg_42_1 : global::ProtoBuf.IExtensible
  {
    public Msg_42_1() {}
    
    private int _yuanbao = default(int);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"yuanbao", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int yuanbao
    {
      get { return _yuanbao; }
      set { _yuanbao = value; }
    }
    private string _key = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"key", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string key
    {
      get { return _key; }
      set { _key = value; }
    }
    private long _nowTime = default(long);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"nowTime", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(long))]
    public long nowTime
    {
      get { return _nowTime; }
      set { _nowTime = value; }
    }
    private int _resultCode = default(int);
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"resultCode", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int resultCode
    {
      get { return _resultCode; }
      set { _resultCode = value; }
    }
    private int _payState = default(int);
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"payState", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int payState
    {
      get { return _payState; }
      set { _payState = value; }
    }
    private int _payChannel = default(int);
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"payChannel", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int payChannel
    {
      get { return _payChannel; }
      set { _payChannel = value; }
    }
    private int _provideState = default(int);
    [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"provideState", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int provideState
    {
      get { return _provideState; }
      set { _provideState = value; }
    }
    private string _resultMsg = "";
    [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"resultMsg", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string resultMsg
    {
      get { return _resultMsg; }
      set { _resultMsg = value; }
    }
    private string _extendInfo = "";
    [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"extendInfo", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string extendInfo
    {
      get { return _extendInfo; }
      set { _extendInfo = value; }
    }
    private int _amt = default(int);
    [global::ProtoBuf.ProtoMember(10, IsRequired = false, Name=@"amt", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int amt
    {
      get { return _amt; }
      set { _amt = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"Msg_42_1_")]
  public partial class Msg_42_1_ : global::ProtoBuf.IExtensible
  {
    public Msg_42_1_() {}
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"Msg_42_2_")]
  public partial class Msg_42_2_ : global::ProtoBuf.IExtensible
  {
    public Msg_42_2_() {}
    
    private string _accessToken = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"accessToken", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string accessToken
    {
      get { return _accessToken; }
      set { _accessToken = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}