// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: role.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from role.proto</summary>
public static partial class RoleReflection {

  #region Descriptor
  /// <summary>File descriptor for role.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static RoleReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "Cgpyb2xlLnByb3RvGgxlbnRpdHkucHJvdG8iYgoPUm9sZVN1bW1hcnlEYXRh",
          "EgwKBE5hbWUYASABKAkSDAoEWm9uZRgCIAEoBRIQCghSb2xlVVVJRBgDIAEo",
          "CRIPCgdNYXBVVUlEGAQgASgJEhAKCE1haWxVVUlEGAUgASgJIjEKDlJvbGVP",
          "bmxpbmVEYXRhEh8KCkVudGl0eURhdGEYASABKAsyCy5FbnRpdHlEYXRhIi0K",
          "EFJvbGVSZWFsdGltZURhdGESGQoRTGFzdFN0YXRpY01hcFVVSUQYASABKAki",
          "UgoEUm9sZRIlCgtTdW1tYXJ5RGF0YRgBIAEoCzIQLlJvbGVTdW1tYXJ5RGF0",
          "YRIjCgpPbmxpbmVEYXRhGAIgASgLMg8uUm9sZU9ubGluZURhdGFCGVoXSU5T",
          "ZXJ2ZXIvc3JjL3Byb3RvL2RhdGFiBnByb3RvMw=="));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { global::EntityReflection.Descriptor, },
        new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::RoleSummaryData), global::RoleSummaryData.Parser, new[]{ "Name", "Zone", "RoleUUID", "MapUUID", "MailUUID" }, null, null, null),
          new pbr::GeneratedClrTypeInfo(typeof(global::RoleOnlineData), global::RoleOnlineData.Parser, new[]{ "EntityData" }, null, null, null),
          new pbr::GeneratedClrTypeInfo(typeof(global::RoleRealtimeData), global::RoleRealtimeData.Parser, new[]{ "LastStaticMapUUID" }, null, null, null),
          new pbr::GeneratedClrTypeInfo(typeof(global::Role), global::Role.Parser, new[]{ "SummaryData", "OnlineData" }, null, null, null)
        }));
  }
  #endregion

}
#region Messages
/// <summary>
/// 离线数据
/// </summary>
public sealed partial class RoleSummaryData : pb::IMessage<RoleSummaryData> {
  private static readonly pb::MessageParser<RoleSummaryData> _parser = new pb::MessageParser<RoleSummaryData>(() => new RoleSummaryData());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pb::MessageParser<RoleSummaryData> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::RoleReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public RoleSummaryData() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public RoleSummaryData(RoleSummaryData other) : this() {
    name_ = other.name_;
    zone_ = other.zone_;
    roleUUID_ = other.roleUUID_;
    mapUUID_ = other.mapUUID_;
    mailUUID_ = other.mailUUID_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public RoleSummaryData Clone() {
    return new RoleSummaryData(this);
  }

  /// <summary>Field number for the "Name" field.</summary>
  public const int NameFieldNumber = 1;
  private string name_ = "";
  /// <summary>
  /// 角色名
  /// </summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public string Name {
    get { return name_; }
    set {
      name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
    }
  }

  /// <summary>Field number for the "Zone" field.</summary>
  public const int ZoneFieldNumber = 2;
  private int zone_;
  /// <summary>
  /// 游戏区
  /// </summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public int Zone {
    get { return zone_; }
    set {
      zone_ = value;
    }
  }

  /// <summary>Field number for the "RoleUUID" field.</summary>
  public const int RoleUUIDFieldNumber = 3;
  private string roleUUID_ = "";
  /// <summary>
  /// UUID
  /// </summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public string RoleUUID {
    get { return roleUUID_; }
    set {
      roleUUID_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
    }
  }

  /// <summary>Field number for the "MapUUID" field.</summary>
  public const int MapUUIDFieldNumber = 4;
  private string mapUUID_ = "";
  /// <summary>
  /// 所在地图
  /// </summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public string MapUUID {
    get { return mapUUID_; }
    set {
      mapUUID_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
    }
  }

  /// <summary>Field number for the "MailUUID" field.</summary>
  public const int MailUUIDFieldNumber = 5;
  private string mailUUID_ = "";
  /// <summary>
  /// 邮件地址
  /// </summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public string MailUUID {
    get { return mailUUID_; }
    set {
      mailUUID_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override bool Equals(object other) {
    return Equals(other as RoleSummaryData);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public bool Equals(RoleSummaryData other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (Name != other.Name) return false;
    if (Zone != other.Zone) return false;
    if (RoleUUID != other.RoleUUID) return false;
    if (MapUUID != other.MapUUID) return false;
    if (MailUUID != other.MailUUID) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override int GetHashCode() {
    int hash = 1;
    if (Name.Length != 0) hash ^= Name.GetHashCode();
    if (Zone != 0) hash ^= Zone.GetHashCode();
    if (RoleUUID.Length != 0) hash ^= RoleUUID.GetHashCode();
    if (MapUUID.Length != 0) hash ^= MapUUID.GetHashCode();
    if (MailUUID.Length != 0) hash ^= MailUUID.GetHashCode();
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
    if (Name.Length != 0) {
      output.WriteRawTag(10);
      output.WriteString(Name);
    }
    if (Zone != 0) {
      output.WriteRawTag(16);
      output.WriteInt32(Zone);
    }
    if (RoleUUID.Length != 0) {
      output.WriteRawTag(26);
      output.WriteString(RoleUUID);
    }
    if (MapUUID.Length != 0) {
      output.WriteRawTag(34);
      output.WriteString(MapUUID);
    }
    if (MailUUID.Length != 0) {
      output.WriteRawTag(42);
      output.WriteString(MailUUID);
    }
    if (_unknownFields != null) {
      _unknownFields.WriteTo(output);
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public int CalculateSize() {
    int size = 0;
    if (Name.Length != 0) {
      size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
    }
    if (Zone != 0) {
      size += 1 + pb::CodedOutputStream.ComputeInt32Size(Zone);
    }
    if (RoleUUID.Length != 0) {
      size += 1 + pb::CodedOutputStream.ComputeStringSize(RoleUUID);
    }
    if (MapUUID.Length != 0) {
      size += 1 + pb::CodedOutputStream.ComputeStringSize(MapUUID);
    }
    if (MailUUID.Length != 0) {
      size += 1 + pb::CodedOutputStream.ComputeStringSize(MailUUID);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(RoleSummaryData other) {
    if (other == null) {
      return;
    }
    if (other.Name.Length != 0) {
      Name = other.Name;
    }
    if (other.Zone != 0) {
      Zone = other.Zone;
    }
    if (other.RoleUUID.Length != 0) {
      RoleUUID = other.RoleUUID;
    }
    if (other.MapUUID.Length != 0) {
      MapUUID = other.MapUUID;
    }
    if (other.MailUUID.Length != 0) {
      MailUUID = other.MailUUID;
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
        case 10: {
          Name = input.ReadString();
          break;
        }
        case 16: {
          Zone = input.ReadInt32();
          break;
        }
        case 26: {
          RoleUUID = input.ReadString();
          break;
        }
        case 34: {
          MapUUID = input.ReadString();
          break;
        }
        case 42: {
          MailUUID = input.ReadString();
          break;
        }
      }
    }
  }

}

/// <summary>
/// 在线数据
/// </summary>
public sealed partial class RoleOnlineData : pb::IMessage<RoleOnlineData> {
  private static readonly pb::MessageParser<RoleOnlineData> _parser = new pb::MessageParser<RoleOnlineData>(() => new RoleOnlineData());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pb::MessageParser<RoleOnlineData> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::RoleReflection.Descriptor.MessageTypes[1]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public RoleOnlineData() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public RoleOnlineData(RoleOnlineData other) : this() {
    entityData_ = other.entityData_ != null ? other.entityData_.Clone() : null;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public RoleOnlineData Clone() {
    return new RoleOnlineData(this);
  }

  /// <summary>Field number for the "EntityData" field.</summary>
  public const int EntityDataFieldNumber = 1;
  private global::EntityData entityData_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public global::EntityData EntityData {
    get { return entityData_; }
    set {
      entityData_ = value;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override bool Equals(object other) {
    return Equals(other as RoleOnlineData);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public bool Equals(RoleOnlineData other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (!object.Equals(EntityData, other.EntityData)) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override int GetHashCode() {
    int hash = 1;
    if (entityData_ != null) hash ^= EntityData.GetHashCode();
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
    if (entityData_ != null) {
      output.WriteRawTag(10);
      output.WriteMessage(EntityData);
    }
    if (_unknownFields != null) {
      _unknownFields.WriteTo(output);
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public int CalculateSize() {
    int size = 0;
    if (entityData_ != null) {
      size += 1 + pb::CodedOutputStream.ComputeMessageSize(EntityData);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(RoleOnlineData other) {
    if (other == null) {
      return;
    }
    if (other.entityData_ != null) {
      if (entityData_ == null) {
        EntityData = new global::EntityData();
      }
      EntityData.MergeFrom(other.EntityData);
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
        case 10: {
          if (entityData_ == null) {
            EntityData = new global::EntityData();
          }
          input.ReadMessage(EntityData);
          break;
        }
      }
    }
  }

}

/// <summary>
/// 实时数据 与场景相关的数据
/// </summary>
public sealed partial class RoleRealtimeData : pb::IMessage<RoleRealtimeData> {
  private static readonly pb::MessageParser<RoleRealtimeData> _parser = new pb::MessageParser<RoleRealtimeData>(() => new RoleRealtimeData());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pb::MessageParser<RoleRealtimeData> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::RoleReflection.Descriptor.MessageTypes[2]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public RoleRealtimeData() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public RoleRealtimeData(RoleRealtimeData other) : this() {
    lastStaticMapUUID_ = other.lastStaticMapUUID_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public RoleRealtimeData Clone() {
    return new RoleRealtimeData(this);
  }

  /// <summary>Field number for the "LastStaticMapUUID" field.</summary>
  public const int LastStaticMapUUIDFieldNumber = 1;
  private string lastStaticMapUUID_ = "";
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public string LastStaticMapUUID {
    get { return lastStaticMapUUID_; }
    set {
      lastStaticMapUUID_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override bool Equals(object other) {
    return Equals(other as RoleRealtimeData);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public bool Equals(RoleRealtimeData other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (LastStaticMapUUID != other.LastStaticMapUUID) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override int GetHashCode() {
    int hash = 1;
    if (LastStaticMapUUID.Length != 0) hash ^= LastStaticMapUUID.GetHashCode();
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
    if (LastStaticMapUUID.Length != 0) {
      output.WriteRawTag(10);
      output.WriteString(LastStaticMapUUID);
    }
    if (_unknownFields != null) {
      _unknownFields.WriteTo(output);
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public int CalculateSize() {
    int size = 0;
    if (LastStaticMapUUID.Length != 0) {
      size += 1 + pb::CodedOutputStream.ComputeStringSize(LastStaticMapUUID);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(RoleRealtimeData other) {
    if (other == null) {
      return;
    }
    if (other.LastStaticMapUUID.Length != 0) {
      LastStaticMapUUID = other.LastStaticMapUUID;
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
        case 10: {
          LastStaticMapUUID = input.ReadString();
          break;
        }
      }
    }
  }

}

public sealed partial class Role : pb::IMessage<Role> {
  private static readonly pb::MessageParser<Role> _parser = new pb::MessageParser<Role>(() => new Role());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pb::MessageParser<Role> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::RoleReflection.Descriptor.MessageTypes[3]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public Role() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public Role(Role other) : this() {
    summaryData_ = other.summaryData_ != null ? other.summaryData_.Clone() : null;
    onlineData_ = other.onlineData_ != null ? other.onlineData_.Clone() : null;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public Role Clone() {
    return new Role(this);
  }

  /// <summary>Field number for the "SummaryData" field.</summary>
  public const int SummaryDataFieldNumber = 1;
  private global::RoleSummaryData summaryData_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public global::RoleSummaryData SummaryData {
    get { return summaryData_; }
    set {
      summaryData_ = value;
    }
  }

  /// <summary>Field number for the "OnlineData" field.</summary>
  public const int OnlineDataFieldNumber = 2;
  private global::RoleOnlineData onlineData_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public global::RoleOnlineData OnlineData {
    get { return onlineData_; }
    set {
      onlineData_ = value;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override bool Equals(object other) {
    return Equals(other as Role);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public bool Equals(Role other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (!object.Equals(SummaryData, other.SummaryData)) return false;
    if (!object.Equals(OnlineData, other.OnlineData)) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override int GetHashCode() {
    int hash = 1;
    if (summaryData_ != null) hash ^= SummaryData.GetHashCode();
    if (onlineData_ != null) hash ^= OnlineData.GetHashCode();
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
    if (summaryData_ != null) {
      output.WriteRawTag(10);
      output.WriteMessage(SummaryData);
    }
    if (onlineData_ != null) {
      output.WriteRawTag(18);
      output.WriteMessage(OnlineData);
    }
    if (_unknownFields != null) {
      _unknownFields.WriteTo(output);
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public int CalculateSize() {
    int size = 0;
    if (summaryData_ != null) {
      size += 1 + pb::CodedOutputStream.ComputeMessageSize(SummaryData);
    }
    if (onlineData_ != null) {
      size += 1 + pb::CodedOutputStream.ComputeMessageSize(OnlineData);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(Role other) {
    if (other == null) {
      return;
    }
    if (other.summaryData_ != null) {
      if (summaryData_ == null) {
        SummaryData = new global::RoleSummaryData();
      }
      SummaryData.MergeFrom(other.SummaryData);
    }
    if (other.onlineData_ != null) {
      if (onlineData_ == null) {
        OnlineData = new global::RoleOnlineData();
      }
      OnlineData.MergeFrom(other.OnlineData);
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
        case 10: {
          if (summaryData_ == null) {
            SummaryData = new global::RoleSummaryData();
          }
          input.ReadMessage(SummaryData);
          break;
        }
        case 18: {
          if (onlineData_ == null) {
            OnlineData = new global::RoleOnlineData();
          }
          input.ReadMessage(OnlineData);
          break;
        }
      }
    }
  }

}

#endregion


#endregion Designer generated code
