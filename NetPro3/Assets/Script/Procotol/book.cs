//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: book.proto
namespace com.protobuf
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"MBook")]
  public partial class MBook : global::ProtoBuf.IExtensible
  {
    public MBook() {}
    
    private int _id = default(int);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int id
    {
      get { return _id; }
      set { _id = value; }
    }
    private int _level = default(int);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"level", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int level
    {
      get { return _level; }
      set { _level = value; }
    }
    private long _exp = default(long);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"exp", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(long))]
    public long exp
    {
      get { return _exp; }
      set { _exp = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"MRoleBookShard")]
  public partial class MRoleBookShard : global::ProtoBuf.IExtensible
  {
    public MRoleBookShard() {}
    
    private int _sharId = default(int);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"sharId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int sharId
    {
      get { return _sharId; }
      set { _sharId = value; }
    }
    private int _cardId = default(int);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"cardId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int cardId
    {
      get { return _cardId; }
      set { _cardId = value; }
    }
    private string _name = "";
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string name
    {
      get { return _name; }
      set { _name = value; }
    }
    private int _rate = default(int);
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"rate", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int rate
    {
      get { return _rate; }
      set { _rate = value; }
    }
    private int _index = default(int);
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"index", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int index
    {
      get { return _index; }
      set { _index = value; }
    }
    private int _targerLevel = default(int);
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"targerLevel", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int targerLevel
    {
      get { return _targerLevel; }
      set { _targerLevel = value; }
    }
    private int _color = default(int);
    [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"color", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int color
    {
      get { return _color; }
      set { _color = value; }
    }
    private int _strength = default(int);
    [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"strength", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int strength
    {
      get { return _strength; }
      set { _strength = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"MBookRecord")]
  public partial class MBookRecord : global::ProtoBuf.IExtensible
  {
    public MBookRecord() {}
    
    private long _targetId = default(long);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"targetId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(long))]
    public long targetId
    {
      get { return _targetId; }
      set { _targetId = value; }
    }
    private string _targetName = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"targetName", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string targetName
    {
      get { return _targetName; }
      set { _targetName = value; }
    }
    private int _bookSharId = default(int);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"bookSharId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int bookSharId
    {
      get { return _bookSharId; }
      set { _bookSharId = value; }
    }
    private int _number = default(int);
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"number", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int number
    {
      get { return _number; }
      set { _number = value; }
    }
    private int _result = default(int);
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"result", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int result
    {
      get { return _result; }
      set { _result = value; }
    }
    private long _time = default(long);
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"time", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(long))]
    public long time
    {
      get { return _time; }
      set { _time = value; }
    }
    private long _battleId = default(long);
    [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"battleId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(long))]
    public long battleId
    {
      get { return _battleId; }
      set { _battleId = value; }
    }
    private int _success = default(int);
    [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"success", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int success
    {
      get { return _success; }
      set { _success = value; }
    }
    private int _color = default(int);
    [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"color", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"Msg_16_0_")]
  public partial class Msg_16_0_ : global::ProtoBuf.IExtensible
  {
    public Msg_16_0_() {}
    
    private readonly global::System.Collections.Generic.List<com.protobuf.MRoleBookShard> _roleBookShard = new global::System.Collections.Generic.List<com.protobuf.MRoleBookShard>();
    [global::ProtoBuf.ProtoMember(1, Name=@"roleBookShard", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<com.protobuf.MRoleBookShard> roleBookShard
    {
      get { return _roleBookShard; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"Msg_16_1")]
  public partial class Msg_16_1 : global::ProtoBuf.IExtensible
  {
    public Msg_16_1() {}
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"Msg_16_1_")]
  public partial class Msg_16_1_ : global::ProtoBuf.IExtensible
  {
    public Msg_16_1_() {}
    
    private readonly global::System.Collections.Generic.List<com.protobuf.MBook> _book = new global::System.Collections.Generic.List<com.protobuf.MBook>();
    [global::ProtoBuf.ProtoMember(1, Name=@"book", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<com.protobuf.MBook> book
    {
      get { return _book; }
    }
  
    private long _guardTime = default(long);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"guardTime", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(long))]
    public long guardTime
    {
      get { return _guardTime; }
      set { _guardTime = value; }
    }
    private readonly global::System.Collections.Generic.List<com.protobuf.MBookRecord> _bookRecordList = new global::System.Collections.Generic.List<com.protobuf.MBookRecord>();
    [global::ProtoBuf.ProtoMember(3, Name=@"bookRecordList", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<com.protobuf.MBookRecord> bookRecordList
    {
      get { return _bookRecordList; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"Msg_16_2")]
  public partial class Msg_16_2 : global::ProtoBuf.IExtensible
  {
    public Msg_16_2() {}
    
    private int _bookId = default(int);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"bookId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int bookId
    {
      get { return _bookId; }
      set { _bookId = value; }
    }
    private int _bookShardId = default(int);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"bookShardId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int bookShardId
    {
      get { return _bookShardId; }
      set { _bookShardId = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"Msg_16_2_")]
  public partial class Msg_16_2_ : global::ProtoBuf.IExtensible
  {
    public Msg_16_2_() {}
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"Msg_16_3")]
  public partial class Msg_16_3 : global::ProtoBuf.IExtensible
  {
    public Msg_16_3() {}
    
    private int _bookId = default(int);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"bookId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int bookId
    {
      get { return _bookId; }
      set { _bookId = value; }
    }
    private int _bookShardId = default(int);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"bookShardId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int bookShardId
    {
      get { return _bookShardId; }
      set { _bookShardId = value; }
    }
    private int _index = default(int);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"index", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"Msg_16_3_")]
  public partial class Msg_16_3_ : global::ProtoBuf.IExtensible
  {
    public Msg_16_3_() {}
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"Msg_16_4")]
  public partial class Msg_16_4 : global::ProtoBuf.IExtensible
  {
    public Msg_16_4() {}
    
    private int _bookId = default(int);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"bookId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int bookId
    {
      get { return _bookId; }
      set { _bookId = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"Msg_16_4_")]
  public partial class Msg_16_4_ : global::ProtoBuf.IExtensible
  {
    public Msg_16_4_() {}
    
    private com.protobuf.MBook _book = null;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"book", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public com.protobuf.MBook book
    {
      get { return _book; }
      set { _book = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"Msg_16_5")]
  public partial class Msg_16_5 : global::ProtoBuf.IExtensible
  {
    public Msg_16_5() {}
    
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
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"Msg_16_5_")]
  public partial class Msg_16_5_ : global::ProtoBuf.IExtensible
  {
    public Msg_16_5_() {}
    
    private long _guardTime = default(long);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"guardTime", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(long))]
    public long guardTime
    {
      get { return _guardTime; }
      set { _guardTime = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"Msg_16_6")]
  public partial class Msg_16_6 : global::ProtoBuf.IExtensible
  {
    public Msg_16_6() {}
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"Msg_16_6_")]
  public partial class Msg_16_6_ : global::ProtoBuf.IExtensible
  {
    public Msg_16_6_() {}
    
    private readonly global::System.Collections.Generic.List<com.protobuf.MBookRecord> _bookRecordList = new global::System.Collections.Generic.List<com.protobuf.MBookRecord>();
    [global::ProtoBuf.ProtoMember(1, Name=@"bookRecordList", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<com.protobuf.MBookRecord> bookRecordList
    {
      get { return _bookRecordList; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"Msg_16_7_")]
  public partial class Msg_16_7_ : global::ProtoBuf.IExtensible
  {
    public Msg_16_7_() {}
    
    private com.protobuf.MBookRecord _bookRecordList = null;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"bookRecordList", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public com.protobuf.MBookRecord bookRecordList
    {
      get { return _bookRecordList; }
      set { _bookRecordList = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"Msg_16_9")]
  public partial class Msg_16_9 : global::ProtoBuf.IExtensible
  {
    public Msg_16_9() {}
    
    private int _bookId = default(int);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"bookId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int bookId
    {
      get { return _bookId; }
      set { _bookId = value; }
    }
    private int _bookShardId = default(int);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"bookShardId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int bookShardId
    {
      get { return _bookShardId; }
      set { _bookShardId = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"Msg_16_9_")]
  public partial class Msg_16_9_ : global::ProtoBuf.IExtensible
  {
    public Msg_16_9_() {}
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"Msg_16_10")]
  public partial class Msg_16_10 : global::ProtoBuf.IExtensible
  {
    public Msg_16_10() {}
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"Msg_16_10_")]
  public partial class Msg_16_10_ : global::ProtoBuf.IExtensible
  {
    public Msg_16_10_() {}
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}