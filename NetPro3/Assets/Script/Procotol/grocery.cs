//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: grocery.proto
// Note: requires additional types generated from: object.proto
namespace com.protobuf
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"Msg_23_2")]
  public partial class Msg_23_2 : global::ProtoBuf.IExtensible
  {
    public Msg_23_2() {}
    
    private readonly global::System.Collections.Generic.List<long> _idList = new global::System.Collections.Generic.List<long>();
    [global::ProtoBuf.ProtoMember(1, Name=@"idList", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public global::System.Collections.Generic.List<long> idList
    {
      get { return _idList; }
    }
  
    private int _id = default(int);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int id
    {
      get { return _id; }
      set { _id = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"Msg_23_2_")]
  public partial class Msg_23_2_ : global::ProtoBuf.IExtensible
  {
    public Msg_23_2_() {}
    
    private readonly global::System.Collections.Generic.List<com.protobuf.MDropGood> _dropGood = new global::System.Collections.Generic.List<com.protobuf.MDropGood>();
    [global::ProtoBuf.ProtoMember(1, Name=@"dropGood", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<com.protobuf.MDropGood> dropGood
    {
      get { return _dropGood; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"Msg_23_3")]
  public partial class Msg_23_3 : global::ProtoBuf.IExtensible
  {
    public Msg_23_3() {}
    
    private int _id = default(int);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int id
    {
      get { return _id; }
      set { _id = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"Msg_23_3_")]
  public partial class Msg_23_3_ : global::ProtoBuf.IExtensible
  {
    public Msg_23_3_() {}
    
    private com.protobuf.MDropGood _dropGood = null;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"dropGood", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public com.protobuf.MDropGood dropGood
    {
      get { return _dropGood; }
      set { _dropGood = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"Msg_23_4")]
  public partial class Msg_23_4 : global::ProtoBuf.IExtensible
  {
    public Msg_23_4() {}
    
    private int _id = default(int);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int id
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
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"Msg_23_4_")]
  public partial class Msg_23_4_ : global::ProtoBuf.IExtensible
  {
    public Msg_23_4_() {}
    
    private long _qsNextTime = default(long);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"qsNextTime", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(long))]
    public long qsNextTime
    {
      get { return _qsNextTime; }
      set { _qsNextTime = value; }
    }
    private readonly global::System.Collections.Generic.List<com.protobuf.MDropGood> _dropGood = new global::System.Collections.Generic.List<com.protobuf.MDropGood>();
    [global::ProtoBuf.ProtoMember(2, Name=@"dropGood", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<com.protobuf.MDropGood> dropGood
    {
      get { return _dropGood; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"Msg_23_6")]
  public partial class Msg_23_6 : global::ProtoBuf.IExtensible
  {
    public Msg_23_6() {}
    
    private int _id = default(int);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int id
    {
      get { return _id; }
      set { _id = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"Msg_23_6_")]
  public partial class Msg_23_6_ : global::ProtoBuf.IExtensible
  {
    public Msg_23_6_() {}
    
    private com.protobuf.MDropGood _dropGood = null;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"dropGood", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public com.protobuf.MDropGood dropGood
    {
      get { return _dropGood; }
      set { _dropGood = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"Msg_23_7")]
  public partial class Msg_23_7 : global::ProtoBuf.IExtensible
  {
    public Msg_23_7() {}
    
    private int _id = default(int);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int id
    {
      get { return _id; }
      set { _id = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"Msg_23_7_")]
  public partial class Msg_23_7_ : global::ProtoBuf.IExtensible
  {
    public Msg_23_7_() {}
    
    private com.protobuf.MDropGood _dropGood = null;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"dropGood", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public com.protobuf.MDropGood dropGood
    {
      get { return _dropGood; }
      set { _dropGood = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"Msg_23_8")]
  public partial class Msg_23_8 : global::ProtoBuf.IExtensible
  {
    public Msg_23_8() {}
    
    private long _id = default(long);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(long))]
    public long id
    {
      get { return _id; }
      set { _id = value; }
    }
    private int _targetId = default(int);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"targetId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int targetId
    {
      get { return _targetId; }
      set { _targetId = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"Msg_23_8_")]
  public partial class Msg_23_8_ : global::ProtoBuf.IExtensible
  {
    public Msg_23_8_() {}
    
    private readonly global::System.Collections.Generic.List<com.protobuf.MDropGood> _dropGood = new global::System.Collections.Generic.List<com.protobuf.MDropGood>();
    [global::ProtoBuf.ProtoMember(1, Name=@"dropGood", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<com.protobuf.MDropGood> dropGood
    {
      get { return _dropGood; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"Msg_23_9")]
  public partial class Msg_23_9 : global::ProtoBuf.IExtensible
  {
    public Msg_23_9() {}
    
    private int _materialId = default(int);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"materialId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int materialId
    {
      get { return _materialId; }
      set { _materialId = value; }
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
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"Msg_23_9_")]
  public partial class Msg_23_9_ : global::ProtoBuf.IExtensible
  {
    public Msg_23_9_() {}
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"Msg_23_10_")]
  public partial class Msg_23_10_ : global::ProtoBuf.IExtensible
  {
    public Msg_23_10_() {}
    
    private readonly global::System.Collections.Generic.List<com.protobuf.MDropGood> _dropGood = new global::System.Collections.Generic.List<com.protobuf.MDropGood>();
    [global::ProtoBuf.ProtoMember(1, Name=@"dropGood", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<com.protobuf.MDropGood> dropGood
    {
      get { return _dropGood; }
    }
  
    private long _reshTime = default(long);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"reshTime", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(long))]
    public long reshTime
    {
      get { return _reshTime; }
      set { _reshTime = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"Msg_23_11")]
  public partial class Msg_23_11 : global::ProtoBuf.IExtensible
  {
    public Msg_23_11() {}
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"Msg_23_11_")]
  public partial class Msg_23_11_ : global::ProtoBuf.IExtensible
  {
    public Msg_23_11_() {}
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"Msg_23_12")]
  public partial class Msg_23_12 : global::ProtoBuf.IExtensible
  {
    public Msg_23_12() {}
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"Msg_23_12_")]
  public partial class Msg_23_12_ : global::ProtoBuf.IExtensible
  {
    public Msg_23_12_() {}
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"Msg_23_13")]
  public partial class Msg_23_13 : global::ProtoBuf.IExtensible
  {
    public Msg_23_13() {}
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"Msg_23_13_")]
  public partial class Msg_23_13_ : global::ProtoBuf.IExtensible
  {
    public Msg_23_13_() {}
    
    private readonly global::System.Collections.Generic.List<int> _cardIds = new global::System.Collections.Generic.List<int>();
    [global::ProtoBuf.ProtoMember(1, Name=@"cardIds", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public global::System.Collections.Generic.List<int> cardIds
    {
      get { return _cardIds; }
    }
  
    private readonly global::System.Collections.Generic.List<int> _equipIds = new global::System.Collections.Generic.List<int>();
    [global::ProtoBuf.ProtoMember(2, Name=@"equipIds", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public global::System.Collections.Generic.List<int> equipIds
    {
      get { return _equipIds; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"Msg_23_1")]
  public partial class Msg_23_1 : global::ProtoBuf.IExtensible
  {
    public Msg_23_1() {}
    
    private readonly global::System.Collections.Generic.List<long> _idList = new global::System.Collections.Generic.List<long>();
    [global::ProtoBuf.ProtoMember(1, Name=@"idList", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public global::System.Collections.Generic.List<long> idList
    {
      get { return _idList; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"Msg_23_1_")]
  public partial class Msg_23_1_ : global::ProtoBuf.IExtensible
  {
    public Msg_23_1_() {}
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"Msg_23_14")]
  public partial class Msg_23_14 : global::ProtoBuf.IExtensible
  {
    public Msg_23_14() {}
    
    private int _materialId = default(int);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"materialId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int materialId
    {
      get { return _materialId; }
      set { _materialId = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"Msg_23_14_")]
  public partial class Msg_23_14_ : global::ProtoBuf.IExtensible
  {
    public Msg_23_14_() {}
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}