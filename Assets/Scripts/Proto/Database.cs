// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: database.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from database.proto</summary>
public static partial class DatabaseReflection {

  #region Descriptor
  /// <summary>File descriptor for database.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static DatabaseReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "Cg5kYXRhYmFzZS5wcm90bxoOZGF0YS5tYXAucHJvdG8aD2RhdGEucm9sZS5w",
          "cm90byIwChBTYXZlU3RhdGljTWFwUmVxEhwKClN0YXRpY01hcHMYASADKAsy",
          "CC5NYXBEYXRhIiQKEVNhdmVTdGF0aWNNYXBSZXNwEg8KB1N1Y2Nlc3MYASAB",
          "KAgiIwoLU2F2ZVJvbGVSZXESFAoFUm9sZXMYASADKAsyBS5Sb2xlIh8KDFNh",
          "dmVSb2xlUmVzcBIPCgdTdWNjZXNzGAEgASgIIjIKEVNhdmVEeW5hbWljTWFw",
          "UmVxEh0KC0R5bmFtaWNNYXBzGAEgAygLMgguTWFwRGF0YSIlChJTYXZlRHlu",
          "YW1pY01hcFJlc3ASDwoHU3VjY2VzcxgBIAEoCEIYWhZJTlNlcnZlci9zcmMv",
          "cHJvdG8vbXNnYgZwcm90bzM="));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { global::DataMapReflection.Descriptor, global::DataRoleReflection.Descriptor, },
        new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::SaveStaticMapReq), global::SaveStaticMapReq.Parser, new[]{ "StaticMaps" }, null, null, null),
          new pbr::GeneratedClrTypeInfo(typeof(global::SaveStaticMapResp), global::SaveStaticMapResp.Parser, new[]{ "Success" }, null, null, null),
          new pbr::GeneratedClrTypeInfo(typeof(global::SaveRoleReq), global::SaveRoleReq.Parser, new[]{ "Roles" }, null, null, null),
          new pbr::GeneratedClrTypeInfo(typeof(global::SaveRoleResp), global::SaveRoleResp.Parser, new[]{ "Success" }, null, null, null),
          new pbr::GeneratedClrTypeInfo(typeof(global::SaveDynamicMapReq), global::SaveDynamicMapReq.Parser, new[]{ "DynamicMaps" }, null, null, null),
          new pbr::GeneratedClrTypeInfo(typeof(global::SaveDynamicMapResp), global::SaveDynamicMapResp.Parser, new[]{ "Success" }, null, null, null)
        }));
  }
  #endregion

}
#region Messages
public sealed partial class SaveStaticMapReq : pb::IMessage<SaveStaticMapReq> {
  private static readonly pb::MessageParser<SaveStaticMapReq> _parser = new pb::MessageParser<SaveStaticMapReq>(() => new SaveStaticMapReq());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pb::MessageParser<SaveStaticMapReq> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::DatabaseReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public SaveStaticMapReq() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public SaveStaticMapReq(SaveStaticMapReq other) : this() {
    staticMaps_ = other.staticMaps_.Clone();
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public SaveStaticMapReq Clone() {
    return new SaveStaticMapReq(this);
  }

  /// <summary>Field number for the "StaticMaps" field.</summary>
  public const int StaticMapsFieldNumber = 1;
  private static readonly pb::FieldCodec<global::MapData> _repeated_staticMaps_codec
      = pb::FieldCodec.ForMessage(10, global::MapData.Parser);
  private readonly pbc::RepeatedField<global::MapData> staticMaps_ = new pbc::RepeatedField<global::MapData>();
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public pbc::RepeatedField<global::MapData> StaticMaps {
    get { return staticMaps_; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override bool Equals(object other) {
    return Equals(other as SaveStaticMapReq);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public bool Equals(SaveStaticMapReq other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if(!staticMaps_.Equals(other.staticMaps_)) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override int GetHashCode() {
    int hash = 1;
    hash ^= staticMaps_.GetHashCode();
    if (_unknownFields != null) {
      hash ^= _unknownFields.GetHashCode();
    }
    return hash;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override string ToString() {
    return pb::JsonFormatter.ToDiagnosticString(this);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void WriteTo(pb::CodedOutputStream output) {
    staticMaps_.WriteTo(output, _repeated_staticMaps_codec);
    if (_unknownFields != null) {
      _unknownFields.WriteTo(output);
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public int CalculateSize() {
    int size = 0;
    size += staticMaps_.CalculateSize(_repeated_staticMaps_codec);
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(SaveStaticMapReq other) {
    if (other == null) {
      return;
    }
    staticMaps_.Add(other.staticMaps_);
    _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(pb::CodedInputStream input) {
    uint tag;
    while ((tag = input.ReadTag()) != 0) {
      switch(tag) {
        default:
          _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
          break;
        case 10: {
          staticMaps_.AddEntriesFrom(input, _repeated_staticMaps_codec);
          break;
        }
      }
    }
  }

}

public sealed partial class SaveStaticMapResp : pb::IMessage<SaveStaticMapResp> {
  private static readonly pb::MessageParser<SaveStaticMapResp> _parser = new pb::MessageParser<SaveStaticMapResp>(() => new SaveStaticMapResp());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pb::MessageParser<SaveStaticMapResp> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::DatabaseReflection.Descriptor.MessageTypes[1]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public SaveStaticMapResp() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public SaveStaticMapResp(SaveStaticMapResp other) : this() {
    success_ = other.success_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public SaveStaticMapResp Clone() {
    return new SaveStaticMapResp(this);
  }

  /// <summary>Field number for the "Success" field.</summary>
  public const int SuccessFieldNumber = 1;
  private bool success_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public bool Success {
    get { return success_; }
    set {
      success_ = value;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override bool Equals(object other) {
    return Equals(other as SaveStaticMapResp);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public bool Equals(SaveStaticMapResp other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (Success != other.Success) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override int GetHashCode() {
    int hash = 1;
    if (Success != false) hash ^= Success.GetHashCode();
    if (_unknownFields != null) {
      hash ^= _unknownFields.GetHashCode();
    }
    return hash;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override string ToString() {
    return pb::JsonFormatter.ToDiagnosticString(this);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void WriteTo(pb::CodedOutputStream output) {
    if (Success != false) {
      output.WriteRawTag(8);
      output.WriteBool(Success);
    }
    if (_unknownFields != null) {
      _unknownFields.WriteTo(output);
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public int CalculateSize() {
    int size = 0;
    if (Success != false) {
      size += 1 + 1;
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(SaveStaticMapResp other) {
    if (other == null) {
      return;
    }
    if (other.Success != false) {
      Success = other.Success;
    }
    _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(pb::CodedInputStream input) {
    uint tag;
    while ((tag = input.ReadTag()) != 0) {
      switch(tag) {
        default:
          _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
          break;
        case 8: {
          Success = input.ReadBool();
          break;
        }
      }
    }
  }

}

public sealed partial class SaveRoleReq : pb::IMessage<SaveRoleReq> {
  private static readonly pb::MessageParser<SaveRoleReq> _parser = new pb::MessageParser<SaveRoleReq>(() => new SaveRoleReq());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pb::MessageParser<SaveRoleReq> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::DatabaseReflection.Descriptor.MessageTypes[2]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public SaveRoleReq() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public SaveRoleReq(SaveRoleReq other) : this() {
    roles_ = other.roles_.Clone();
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public SaveRoleReq Clone() {
    return new SaveRoleReq(this);
  }

  /// <summary>Field number for the "Roles" field.</summary>
  public const int RolesFieldNumber = 1;
  private static readonly pb::FieldCodec<global::Role> _repeated_roles_codec
      = pb::FieldCodec.ForMessage(10, global::Role.Parser);
  private readonly pbc::RepeatedField<global::Role> roles_ = new pbc::RepeatedField<global::Role>();
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public pbc::RepeatedField<global::Role> Roles {
    get { return roles_; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override bool Equals(object other) {
    return Equals(other as SaveRoleReq);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public bool Equals(SaveRoleReq other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if(!roles_.Equals(other.roles_)) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override int GetHashCode() {
    int hash = 1;
    hash ^= roles_.GetHashCode();
    if (_unknownFields != null) {
      hash ^= _unknownFields.GetHashCode();
    }
    return hash;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override string ToString() {
    return pb::JsonFormatter.ToDiagnosticString(this);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void WriteTo(pb::CodedOutputStream output) {
    roles_.WriteTo(output, _repeated_roles_codec);
    if (_unknownFields != null) {
      _unknownFields.WriteTo(output);
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public int CalculateSize() {
    int size = 0;
    size += roles_.CalculateSize(_repeated_roles_codec);
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(SaveRoleReq other) {
    if (other == null) {
      return;
    }
    roles_.Add(other.roles_);
    _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(pb::CodedInputStream input) {
    uint tag;
    while ((tag = input.ReadTag()) != 0) {
      switch(tag) {
        default:
          _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
          break;
        case 10: {
          roles_.AddEntriesFrom(input, _repeated_roles_codec);
          break;
        }
      }
    }
  }

}

public sealed partial class SaveRoleResp : pb::IMessage<SaveRoleResp> {
  private static readonly pb::MessageParser<SaveRoleResp> _parser = new pb::MessageParser<SaveRoleResp>(() => new SaveRoleResp());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pb::MessageParser<SaveRoleResp> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::DatabaseReflection.Descriptor.MessageTypes[3]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public SaveRoleResp() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public SaveRoleResp(SaveRoleResp other) : this() {
    success_ = other.success_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public SaveRoleResp Clone() {
    return new SaveRoleResp(this);
  }

  /// <summary>Field number for the "Success" field.</summary>
  public const int SuccessFieldNumber = 1;
  private bool success_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public bool Success {
    get { return success_; }
    set {
      success_ = value;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override bool Equals(object other) {
    return Equals(other as SaveRoleResp);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public bool Equals(SaveRoleResp other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (Success != other.Success) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override int GetHashCode() {
    int hash = 1;
    if (Success != false) hash ^= Success.GetHashCode();
    if (_unknownFields != null) {
      hash ^= _unknownFields.GetHashCode();
    }
    return hash;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override string ToString() {
    return pb::JsonFormatter.ToDiagnosticString(this);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void WriteTo(pb::CodedOutputStream output) {
    if (Success != false) {
      output.WriteRawTag(8);
      output.WriteBool(Success);
    }
    if (_unknownFields != null) {
      _unknownFields.WriteTo(output);
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public int CalculateSize() {
    int size = 0;
    if (Success != false) {
      size += 1 + 1;
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(SaveRoleResp other) {
    if (other == null) {
      return;
    }
    if (other.Success != false) {
      Success = other.Success;
    }
    _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(pb::CodedInputStream input) {
    uint tag;
    while ((tag = input.ReadTag()) != 0) {
      switch(tag) {
        default:
          _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
          break;
        case 8: {
          Success = input.ReadBool();
          break;
        }
      }
    }
  }

}

public sealed partial class SaveDynamicMapReq : pb::IMessage<SaveDynamicMapReq> {
  private static readonly pb::MessageParser<SaveDynamicMapReq> _parser = new pb::MessageParser<SaveDynamicMapReq>(() => new SaveDynamicMapReq());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pb::MessageParser<SaveDynamicMapReq> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::DatabaseReflection.Descriptor.MessageTypes[4]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public SaveDynamicMapReq() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public SaveDynamicMapReq(SaveDynamicMapReq other) : this() {
    dynamicMaps_ = other.dynamicMaps_.Clone();
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public SaveDynamicMapReq Clone() {
    return new SaveDynamicMapReq(this);
  }

  /// <summary>Field number for the "DynamicMaps" field.</summary>
  public const int DynamicMapsFieldNumber = 1;
  private static readonly pb::FieldCodec<global::MapData> _repeated_dynamicMaps_codec
      = pb::FieldCodec.ForMessage(10, global::MapData.Parser);
  private readonly pbc::RepeatedField<global::MapData> dynamicMaps_ = new pbc::RepeatedField<global::MapData>();
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public pbc::RepeatedField<global::MapData> DynamicMaps {
    get { return dynamicMaps_; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override bool Equals(object other) {
    return Equals(other as SaveDynamicMapReq);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public bool Equals(SaveDynamicMapReq other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if(!dynamicMaps_.Equals(other.dynamicMaps_)) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override int GetHashCode() {
    int hash = 1;
    hash ^= dynamicMaps_.GetHashCode();
    if (_unknownFields != null) {
      hash ^= _unknownFields.GetHashCode();
    }
    return hash;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override string ToString() {
    return pb::JsonFormatter.ToDiagnosticString(this);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void WriteTo(pb::CodedOutputStream output) {
    dynamicMaps_.WriteTo(output, _repeated_dynamicMaps_codec);
    if (_unknownFields != null) {
      _unknownFields.WriteTo(output);
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public int CalculateSize() {
    int size = 0;
    size += dynamicMaps_.CalculateSize(_repeated_dynamicMaps_codec);
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(SaveDynamicMapReq other) {
    if (other == null) {
      return;
    }
    dynamicMaps_.Add(other.dynamicMaps_);
    _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(pb::CodedInputStream input) {
    uint tag;
    while ((tag = input.ReadTag()) != 0) {
      switch(tag) {
        default:
          _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
          break;
        case 10: {
          dynamicMaps_.AddEntriesFrom(input, _repeated_dynamicMaps_codec);
          break;
        }
      }
    }
  }

}

public sealed partial class SaveDynamicMapResp : pb::IMessage<SaveDynamicMapResp> {
  private static readonly pb::MessageParser<SaveDynamicMapResp> _parser = new pb::MessageParser<SaveDynamicMapResp>(() => new SaveDynamicMapResp());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pb::MessageParser<SaveDynamicMapResp> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::DatabaseReflection.Descriptor.MessageTypes[5]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public SaveDynamicMapResp() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public SaveDynamicMapResp(SaveDynamicMapResp other) : this() {
    success_ = other.success_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public SaveDynamicMapResp Clone() {
    return new SaveDynamicMapResp(this);
  }

  /// <summary>Field number for the "Success" field.</summary>
  public const int SuccessFieldNumber = 1;
  private bool success_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public bool Success {
    get { return success_; }
    set {
      success_ = value;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override bool Equals(object other) {
    return Equals(other as SaveDynamicMapResp);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public bool Equals(SaveDynamicMapResp other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (Success != other.Success) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override int GetHashCode() {
    int hash = 1;
    if (Success != false) hash ^= Success.GetHashCode();
    if (_unknownFields != null) {
      hash ^= _unknownFields.GetHashCode();
    }
    return hash;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override string ToString() {
    return pb::JsonFormatter.ToDiagnosticString(this);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void WriteTo(pb::CodedOutputStream output) {
    if (Success != false) {
      output.WriteRawTag(8);
      output.WriteBool(Success);
    }
    if (_unknownFields != null) {
      _unknownFields.WriteTo(output);
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public int CalculateSize() {
    int size = 0;
    if (Success != false) {
      size += 1 + 1;
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(SaveDynamicMapResp other) {
    if (other == null) {
      return;
    }
    if (other.Success != false) {
      Success = other.Success;
    }
    _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(pb::CodedInputStream input) {
    uint tag;
    while ((tag = input.ReadTag()) != 0) {
      switch(tag) {
        default:
          _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
          break;
        case 8: {
          Success = input.ReadBool();
          break;
        }
      }
    }
  }

}

#endregion


#endregion Designer generated code
