//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: bag.proto
// Note: requires additional types generated from: object.proto
namespace com.protobuf
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"MMingGe")]
  public partial class MMingGe : global::ProtoBuf.IExtensible
  {
    public MMingGe() {}
    
    private int _id = default(int);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int id
    {
      get { return _id; }
      set { _id = value; }
    }
    private int _mingGeId = default(int);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"mingGeId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int mingGeId
    {
      get { return _mingGeId; }
      set { _mingGeId = value; }
    }
    private long _exp = default(long);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"exp", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(long))]
    public long exp
    {
      get { return _exp; }
      set { _exp = value; }
    }
    private int _location = default(int);
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"location", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int location
    {
      get { return _location; }
      set { _location = value; }
    }
    private int _index = default(int);
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"index", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int index
    {
      get { return _index; }
      set { _index = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"MGrid")]
  public partial class MGrid : global::ProtoBuf.IExtensible
  {
    public MGrid() {}
    
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
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"MBag")]
  public partial class MBag : global::ProtoBuf.IExtensible
  {
    public MBag() {}
    
    private readonly global::System.Collections.Generic.List<com.protobuf.MGrid> _articleList = new global::System.Collections.Generic.List<com.protobuf.MGrid>();
    [global::ProtoBuf.ProtoMember(1, Name=@"articleList", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<com.protobuf.MGrid> articleList
    {
      get { return _articleList; }
    }
  
    private int _articleCount = default(int);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"articleCount", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int articleCount
    {
      get { return _articleCount; }
      set { _articleCount = value; }
    }
    private int _equipCount = default(int);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"equipCount", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int equipCount
    {
      get { return _equipCount; }
      set { _equipCount = value; }
    }
    private int _cardCount = default(int);
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"cardCount", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int cardCount
    {
      get { return _cardCount; }
      set { _cardCount = value; }
    }
    private readonly global::System.Collections.Generic.List<com.protobuf.MGrid> _materialList = new global::System.Collections.Generic.List<com.protobuf.MGrid>();
    [global::ProtoBuf.ProtoMember(5, Name=@"materialList", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<com.protobuf.MGrid> materialList
    {
      get { return _materialList; }
    }
  
    private readonly global::System.Collections.Generic.List<com.protobuf.MGrid> _bookShardList = new global::System.Collections.Generic.List<com.protobuf.MGrid>();
    [global::ProtoBuf.ProtoMember(6, Name=@"bookShardList", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<com.protobuf.MGrid> bookShardList
    {
      get { return _bookShardList; }
    }
  
    private int _mingGeCount = default(int);
    [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"mingGeCount", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int mingGeCount
    {
      get { return _mingGeCount; }
      set { _mingGeCount = value; }
    }
    private readonly global::System.Collections.Generic.List<com.protobuf.MMingGe> _mingGeList = new global::System.Collections.Generic.List<com.protobuf.MMingGe>();
    [global::ProtoBuf.ProtoMember(8, Name=@"mingGeList", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<com.protobuf.MMingGe> mingGeList
    {
      get { return _mingGeList; }
    }
  
    private readonly global::System.Collections.Generic.List<com.protobuf.MMingGe> _tempMingGeList = new global::System.Collections.Generic.List<com.protobuf.MMingGe>();
    [global::ProtoBuf.ProtoMember(9, Name=@"tempMingGeList", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<com.protobuf.MMingGe> tempMingGeList
    {
      get { return _tempMingGeList; }
    }
  
    private int _tempMingGeCount = default(int);
    [global::ProtoBuf.ProtoMember(10, IsRequired = false, Name=@"tempMingGeCount", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int tempMingGeCount
    {
      get { return _tempMingGeCount; }
      set { _tempMingGeCount = value; }
    }
    private int _mingGeSharCount = default(int);
    [global::ProtoBuf.ProtoMember(11, IsRequired = false, Name=@"mingGeSharCount", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int mingGeSharCount
    {
      get { return _mingGeSharCount; }
      set { _mingGeSharCount = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"Msg_5_1_")]
  public partial class Msg_5_1_ : global::ProtoBuf.IExtensible
  {
    public Msg_5_1_() {}
    
    private com.protobuf.MBag _bag = null;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"bag", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public com.protobuf.MBag bag
    {
      get { return _bag; }
      set { _bag = value; }
    }
    private int _tip = default(int);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"tip", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int tip
    {
      get { return _tip; }
      set { _tip = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"Msg_5_2")]
  public partial class Msg_5_2 : global::ProtoBuf.IExtensible
  {
    public Msg_5_2() {}
    
    private int _type = default(int);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int type
    {
      get { return _type; }
      set { _type = value; }
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
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"Msg_5_2_")]
  public partial class Msg_5_2_ : global::ProtoBuf.IExtensible
  {
    public Msg_5_2_() {}
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"Msg_5_3")]
  public partial class Msg_5_3 : global::ProtoBuf.IExtensible
  {
    public Msg_5_3() {}
    
    private int _id = default(int);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int id
    {
      get { return _id; }
      set { _id = value; }
    }
    private int _num = default(int);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"num", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int num
    {
      get { return _num; }
      set { _num = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"Msg_5_3_")]
  public partial class Msg_5_3_ : global::ProtoBuf.IExtensible
  {
    public Msg_5_3_() {}
    
    private readonly global::System.Collections.Generic.List<com.protobuf.MDropGood> _rewardList = new global::System.Collections.Generic.List<com.protobuf.MDropGood>();
    [global::ProtoBuf.ProtoMember(1, Name=@"rewardList", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<com.protobuf.MDropGood> rewardList
    {
      get { return _rewardList; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"Msg_5_4")]
  public partial class Msg_5_4 : global::ProtoBuf.IExtensible
  {
    public Msg_5_4() {}
    
    private int _id = default(int);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int id
    {
      get { return _id; }
      set { _id = value; }
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
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"Msg_5_4_")]
  public partial class Msg_5_4_ : global::ProtoBuf.IExtensible
  {
    public Msg_5_4_() {}
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}