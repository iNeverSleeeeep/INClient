// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: client-gate.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from client-gate.proto</summary>
public static partial class ClientGateReflection {

  #region Descriptor
  /// <summary>File descriptor for client-gate.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static ClientGateReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "ChFjbGllbnQtZ2F0ZS5wcm90bxoNY29tbWFuZC5wcm90bxoRZGF0YS5wbGF5",
          "ZXIucHJvdG8aD2RhdGEucm9sZS5wcm90byIoCgtTZXNzaW9uQ2VydBIMCgRV",
          "VUlEGAEgASgJEgsKA0tleRgCIAEoCSIzCg5Db25uZWN0R2F0ZVJlcRIhCgtT",
          "ZXNzaW9uQ2VydBgBIAEoCzIMLlNlc3Npb25DZXJ0IjsKD0Nvbm5lY3RHYXRl",
          "UmVzcBIPCgdTdWNjZXNzGAEgASgIEhcKBlBsYXllchgCIAEoCzIHLlBsYXll",
          "ciIgCgxSb2xlRW50ZXJSZXESEAoIUm9sZVVVSUQYASABKAkiRAoNUm9sZUVu",
          "dGVyUmVzcBIPCgdTdWNjZXNzGAEgASgIEg0KBU1hcElEGAIgASgFEhMKBFJv",
          "bGUYAyABKAsyBS5Sb2xlIlwKDENsaWVudFRvR2F0ZRIZCgdDb21tYW5kGAEg",
          "ASgOMgguQ29tbWFuZBIQCghTZXF1ZW5jZRgCIAEoBBIPCgdSZXF1ZXN0GAMg",
          "ASgMEg4KBk5vdGlmeRgEIAEoDCJLCgxHYXRlVG9DbGllbnQSGQoHQ29tbWFu",
          "ZBgBIAEoDjIILkNvbW1hbmQSEAoIU2VxdWVuY2UYAiABKAQSDgoGQnVmZmVy",
          "GAMgASgMQhhaFklOU2VydmVyL3NyYy9wcm90by9tc2diBnByb3RvMw=="));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { global::CommandReflection.Descriptor, global::DataPlayerReflection.Descriptor, global::DataRoleReflection.Descriptor, },
        new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::SessionCert), global::SessionCert.Parser, new[]{ "UUID", "Key" }, null, null, null),
          new pbr::GeneratedClrTypeInfo(typeof(global::ConnectGateReq), global::ConnectGateReq.Parser, new[]{ "SessionCert" }, null, null, null),
          new pbr::GeneratedClrTypeInfo(typeof(global::ConnectGateResp), global::ConnectGateResp.Parser, new[]{ "Success", "Player" }, null, null, null),
          new pbr::GeneratedClrTypeInfo(typeof(global::RoleEnterReq), global::RoleEnterReq.Parser, new[]{ "RoleUUID" }, null, null, null),
          new pbr::GeneratedClrTypeInfo(typeof(global::RoleEnterResp), global::RoleEnterResp.Parser, new[]{ "Success", "MapID", "Role" }, null, null, null),
          new pbr::GeneratedClrTypeInfo(typeof(global::ClientToGate), global::ClientToGate.Parser, new[]{ "Command", "Sequence", "Request", "Notify" }, null, null, null),
          new pbr::GeneratedClrTypeInfo(typeof(global::GateToClient), global::GateToClient.Parser, new[]{ "Command", "Sequence", "Buffer" }, null, null, null)
        }));
  }
  #endregion

}
#region Messages
public sealed partial class SessionCert : pb::IMessage<SessionCert> {
  private static readonly pb::MessageParser<SessionCert> _parser = new pb::MessageParser<SessionCert>(() => new SessionCert());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pb::MessageParser<SessionCert> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::ClientGateReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public SessionCert() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public SessionCert(SessionCert other) : this() {
    uUID_ = other.uUID_;
    key_ = other.key_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public SessionCert Clone() {
    return new SessionCert(this);
  }

  /// <summary>Field number for the "UUID" field.</summary>
  public const int UUIDFieldNumber = 1;
  private string uUID_ = "";
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public string UUID {
    get { return uUID_; }
    set {
      uUID_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
    }
  }

  /// <summary>Field number for the "Key" field.</summary>
  public const int KeyFieldNumber = 2;
  private string key_ = "";
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public string Key {
    get { return key_; }
    set {
      key_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override bool Equals(object other) {
    return Equals(other as SessionCert);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public bool Equals(SessionCert other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (UUID != other.UUID) return false;
    if (Key != other.Key) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override int GetHashCode() {
    int hash = 1;
    if (UUID.Length != 0) hash ^= UUID.GetHashCode();
    if (Key.Length != 0) hash ^= Key.GetHashCode();
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
    if (UUID.Length != 0) {
      output.WriteRawTag(10);
      output.WriteString(UUID);
    }
    if (Key.Length != 0) {
      output.WriteRawTag(18);
      output.WriteString(Key);
    }
    if (_unknownFields != null) {
      _unknownFields.WriteTo(output);
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public int CalculateSize() {
    int size = 0;
    if (UUID.Length != 0) {
      size += 1 + pb::CodedOutputStream.ComputeStringSize(UUID);
    }
    if (Key.Length != 0) {
      size += 1 + pb::CodedOutputStream.ComputeStringSize(Key);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(SessionCert other) {
    if (other == null) {
      return;
    }
    if (other.UUID.Length != 0) {
      UUID = other.UUID;
    }
    if (other.Key.Length != 0) {
      Key = other.Key;
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
          UUID = input.ReadString();
          break;
        }
        case 18: {
          Key = input.ReadString();
          break;
        }
      }
    }
  }

}

public sealed partial class ConnectGateReq : pb::IMessage<ConnectGateReq> {
  private static readonly pb::MessageParser<ConnectGateReq> _parser = new pb::MessageParser<ConnectGateReq>(() => new ConnectGateReq());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pb::MessageParser<ConnectGateReq> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::ClientGateReflection.Descriptor.MessageTypes[1]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public ConnectGateReq() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public ConnectGateReq(ConnectGateReq other) : this() {
    sessionCert_ = other.sessionCert_ != null ? other.sessionCert_.Clone() : null;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public ConnectGateReq Clone() {
    return new ConnectGateReq(this);
  }

  /// <summary>Field number for the "SessionCert" field.</summary>
  public const int SessionCertFieldNumber = 1;
  private global::SessionCert sessionCert_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public global::SessionCert SessionCert {
    get { return sessionCert_; }
    set {
      sessionCert_ = value;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override bool Equals(object other) {
    return Equals(other as ConnectGateReq);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public bool Equals(ConnectGateReq other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (!object.Equals(SessionCert, other.SessionCert)) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override int GetHashCode() {
    int hash = 1;
    if (sessionCert_ != null) hash ^= SessionCert.GetHashCode();
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
    if (sessionCert_ != null) {
      output.WriteRawTag(10);
      output.WriteMessage(SessionCert);
    }
    if (_unknownFields != null) {
      _unknownFields.WriteTo(output);
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public int CalculateSize() {
    int size = 0;
    if (sessionCert_ != null) {
      size += 1 + pb::CodedOutputStream.ComputeMessageSize(SessionCert);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(ConnectGateReq other) {
    if (other == null) {
      return;
    }
    if (other.sessionCert_ != null) {
      if (sessionCert_ == null) {
        SessionCert = new global::SessionCert();
      }
      SessionCert.MergeFrom(other.SessionCert);
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
          if (sessionCert_ == null) {
            SessionCert = new global::SessionCert();
          }
          input.ReadMessage(SessionCert);
          break;
        }
      }
    }
  }

}

public sealed partial class ConnectGateResp : pb::IMessage<ConnectGateResp> {
  private static readonly pb::MessageParser<ConnectGateResp> _parser = new pb::MessageParser<ConnectGateResp>(() => new ConnectGateResp());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pb::MessageParser<ConnectGateResp> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::ClientGateReflection.Descriptor.MessageTypes[2]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public ConnectGateResp() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public ConnectGateResp(ConnectGateResp other) : this() {
    success_ = other.success_;
    player_ = other.player_ != null ? other.player_.Clone() : null;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public ConnectGateResp Clone() {
    return new ConnectGateResp(this);
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

  /// <summary>Field number for the "Player" field.</summary>
  public const int PlayerFieldNumber = 2;
  private global::Player player_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public global::Player Player {
    get { return player_; }
    set {
      player_ = value;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override bool Equals(object other) {
    return Equals(other as ConnectGateResp);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public bool Equals(ConnectGateResp other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (Success != other.Success) return false;
    if (!object.Equals(Player, other.Player)) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override int GetHashCode() {
    int hash = 1;
    if (Success != false) hash ^= Success.GetHashCode();
    if (player_ != null) hash ^= Player.GetHashCode();
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
    if (player_ != null) {
      output.WriteRawTag(18);
      output.WriteMessage(Player);
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
    if (player_ != null) {
      size += 1 + pb::CodedOutputStream.ComputeMessageSize(Player);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(ConnectGateResp other) {
    if (other == null) {
      return;
    }
    if (other.Success != false) {
      Success = other.Success;
    }
    if (other.player_ != null) {
      if (player_ == null) {
        Player = new global::Player();
      }
      Player.MergeFrom(other.Player);
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
        case 18: {
          if (player_ == null) {
            Player = new global::Player();
          }
          input.ReadMessage(Player);
          break;
        }
      }
    }
  }

}

public sealed partial class RoleEnterReq : pb::IMessage<RoleEnterReq> {
  private static readonly pb::MessageParser<RoleEnterReq> _parser = new pb::MessageParser<RoleEnterReq>(() => new RoleEnterReq());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pb::MessageParser<RoleEnterReq> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::ClientGateReflection.Descriptor.MessageTypes[3]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public RoleEnterReq() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public RoleEnterReq(RoleEnterReq other) : this() {
    roleUUID_ = other.roleUUID_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public RoleEnterReq Clone() {
    return new RoleEnterReq(this);
  }

  /// <summary>Field number for the "RoleUUID" field.</summary>
  public const int RoleUUIDFieldNumber = 1;
  private string roleUUID_ = "";
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public string RoleUUID {
    get { return roleUUID_; }
    set {
      roleUUID_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override bool Equals(object other) {
    return Equals(other as RoleEnterReq);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public bool Equals(RoleEnterReq other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (RoleUUID != other.RoleUUID) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override int GetHashCode() {
    int hash = 1;
    if (RoleUUID.Length != 0) hash ^= RoleUUID.GetHashCode();
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
    if (RoleUUID.Length != 0) {
      output.WriteRawTag(10);
      output.WriteString(RoleUUID);
    }
    if (_unknownFields != null) {
      _unknownFields.WriteTo(output);
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public int CalculateSize() {
    int size = 0;
    if (RoleUUID.Length != 0) {
      size += 1 + pb::CodedOutputStream.ComputeStringSize(RoleUUID);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(RoleEnterReq other) {
    if (other == null) {
      return;
    }
    if (other.RoleUUID.Length != 0) {
      RoleUUID = other.RoleUUID;
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
          RoleUUID = input.ReadString();
          break;
        }
      }
    }
  }

}

public sealed partial class RoleEnterResp : pb::IMessage<RoleEnterResp> {
  private static readonly pb::MessageParser<RoleEnterResp> _parser = new pb::MessageParser<RoleEnterResp>(() => new RoleEnterResp());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pb::MessageParser<RoleEnterResp> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::ClientGateReflection.Descriptor.MessageTypes[4]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public RoleEnterResp() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public RoleEnterResp(RoleEnterResp other) : this() {
    success_ = other.success_;
    mapID_ = other.mapID_;
    role_ = other.role_ != null ? other.role_.Clone() : null;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public RoleEnterResp Clone() {
    return new RoleEnterResp(this);
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

  /// <summary>Field number for the "MapID" field.</summary>
  public const int MapIDFieldNumber = 2;
  private int mapID_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public int MapID {
    get { return mapID_; }
    set {
      mapID_ = value;
    }
  }

  /// <summary>Field number for the "Role" field.</summary>
  public const int RoleFieldNumber = 3;
  private global::Role role_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public global::Role Role {
    get { return role_; }
    set {
      role_ = value;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override bool Equals(object other) {
    return Equals(other as RoleEnterResp);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public bool Equals(RoleEnterResp other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (Success != other.Success) return false;
    if (MapID != other.MapID) return false;
    if (!object.Equals(Role, other.Role)) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override int GetHashCode() {
    int hash = 1;
    if (Success != false) hash ^= Success.GetHashCode();
    if (MapID != 0) hash ^= MapID.GetHashCode();
    if (role_ != null) hash ^= Role.GetHashCode();
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
    if (MapID != 0) {
      output.WriteRawTag(16);
      output.WriteInt32(MapID);
    }
    if (role_ != null) {
      output.WriteRawTag(26);
      output.WriteMessage(Role);
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
    if (MapID != 0) {
      size += 1 + pb::CodedOutputStream.ComputeInt32Size(MapID);
    }
    if (role_ != null) {
      size += 1 + pb::CodedOutputStream.ComputeMessageSize(Role);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(RoleEnterResp other) {
    if (other == null) {
      return;
    }
    if (other.Success != false) {
      Success = other.Success;
    }
    if (other.MapID != 0) {
      MapID = other.MapID;
    }
    if (other.role_ != null) {
      if (role_ == null) {
        Role = new global::Role();
      }
      Role.MergeFrom(other.Role);
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
        case 16: {
          MapID = input.ReadInt32();
          break;
        }
        case 26: {
          if (role_ == null) {
            Role = new global::Role();
          }
          input.ReadMessage(Role);
          break;
        }
      }
    }
  }

}

public sealed partial class ClientToGate : pb::IMessage<ClientToGate> {
  private static readonly pb::MessageParser<ClientToGate> _parser = new pb::MessageParser<ClientToGate>(() => new ClientToGate());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pb::MessageParser<ClientToGate> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::ClientGateReflection.Descriptor.MessageTypes[5]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public ClientToGate() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public ClientToGate(ClientToGate other) : this() {
    command_ = other.command_;
    sequence_ = other.sequence_;
    request_ = other.request_;
    notify_ = other.notify_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public ClientToGate Clone() {
    return new ClientToGate(this);
  }

  /// <summary>Field number for the "Command" field.</summary>
  public const int CommandFieldNumber = 1;
  private global::Command command_ = global::Command.KeepAlive;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public global::Command Command {
    get { return command_; }
    set {
      command_ = value;
    }
  }

  /// <summary>Field number for the "Sequence" field.</summary>
  public const int SequenceFieldNumber = 2;
  private ulong sequence_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public ulong Sequence {
    get { return sequence_; }
    set {
      sequence_ = value;
    }
  }

  /// <summary>Field number for the "Request" field.</summary>
  public const int RequestFieldNumber = 3;
  private pb::ByteString request_ = pb::ByteString.Empty;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public pb::ByteString Request {
    get { return request_; }
    set {
      request_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
    }
  }

  /// <summary>Field number for the "Notify" field.</summary>
  public const int NotifyFieldNumber = 4;
  private pb::ByteString notify_ = pb::ByteString.Empty;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public pb::ByteString Notify {
    get { return notify_; }
    set {
      notify_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override bool Equals(object other) {
    return Equals(other as ClientToGate);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public bool Equals(ClientToGate other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (Command != other.Command) return false;
    if (Sequence != other.Sequence) return false;
    if (Request != other.Request) return false;
    if (Notify != other.Notify) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override int GetHashCode() {
    int hash = 1;
    if (Command != global::Command.KeepAlive) hash ^= Command.GetHashCode();
    if (Sequence != 0UL) hash ^= Sequence.GetHashCode();
    if (Request.Length != 0) hash ^= Request.GetHashCode();
    if (Notify.Length != 0) hash ^= Notify.GetHashCode();
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
    if (Command != global::Command.KeepAlive) {
      output.WriteRawTag(8);
      output.WriteEnum((int) Command);
    }
    if (Sequence != 0UL) {
      output.WriteRawTag(16);
      output.WriteUInt64(Sequence);
    }
    if (Request.Length != 0) {
      output.WriteRawTag(26);
      output.WriteBytes(Request);
    }
    if (Notify.Length != 0) {
      output.WriteRawTag(34);
      output.WriteBytes(Notify);
    }
    if (_unknownFields != null) {
      _unknownFields.WriteTo(output);
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public int CalculateSize() {
    int size = 0;
    if (Command != global::Command.KeepAlive) {
      size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Command);
    }
    if (Sequence != 0UL) {
      size += 1 + pb::CodedOutputStream.ComputeUInt64Size(Sequence);
    }
    if (Request.Length != 0) {
      size += 1 + pb::CodedOutputStream.ComputeBytesSize(Request);
    }
    if (Notify.Length != 0) {
      size += 1 + pb::CodedOutputStream.ComputeBytesSize(Notify);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(ClientToGate other) {
    if (other == null) {
      return;
    }
    if (other.Command != global::Command.KeepAlive) {
      Command = other.Command;
    }
    if (other.Sequence != 0UL) {
      Sequence = other.Sequence;
    }
    if (other.Request.Length != 0) {
      Request = other.Request;
    }
    if (other.Notify.Length != 0) {
      Notify = other.Notify;
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
          Command = (global::Command) input.ReadEnum();
          break;
        }
        case 16: {
          Sequence = input.ReadUInt64();
          break;
        }
        case 26: {
          Request = input.ReadBytes();
          break;
        }
        case 34: {
          Notify = input.ReadBytes();
          break;
        }
      }
    }
  }

}

public sealed partial class GateToClient : pb::IMessage<GateToClient> {
  private static readonly pb::MessageParser<GateToClient> _parser = new pb::MessageParser<GateToClient>(() => new GateToClient());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pb::MessageParser<GateToClient> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::ClientGateReflection.Descriptor.MessageTypes[6]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public GateToClient() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public GateToClient(GateToClient other) : this() {
    command_ = other.command_;
    sequence_ = other.sequence_;
    buffer_ = other.buffer_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public GateToClient Clone() {
    return new GateToClient(this);
  }

  /// <summary>Field number for the "Command" field.</summary>
  public const int CommandFieldNumber = 1;
  private global::Command command_ = global::Command.KeepAlive;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public global::Command Command {
    get { return command_; }
    set {
      command_ = value;
    }
  }

  /// <summary>Field number for the "Sequence" field.</summary>
  public const int SequenceFieldNumber = 2;
  private ulong sequence_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public ulong Sequence {
    get { return sequence_; }
    set {
      sequence_ = value;
    }
  }

  /// <summary>Field number for the "Buffer" field.</summary>
  public const int BufferFieldNumber = 3;
  private pb::ByteString buffer_ = pb::ByteString.Empty;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public pb::ByteString Buffer {
    get { return buffer_; }
    set {
      buffer_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override bool Equals(object other) {
    return Equals(other as GateToClient);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public bool Equals(GateToClient other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (Command != other.Command) return false;
    if (Sequence != other.Sequence) return false;
    if (Buffer != other.Buffer) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override int GetHashCode() {
    int hash = 1;
    if (Command != global::Command.KeepAlive) hash ^= Command.GetHashCode();
    if (Sequence != 0UL) hash ^= Sequence.GetHashCode();
    if (Buffer.Length != 0) hash ^= Buffer.GetHashCode();
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
    if (Command != global::Command.KeepAlive) {
      output.WriteRawTag(8);
      output.WriteEnum((int) Command);
    }
    if (Sequence != 0UL) {
      output.WriteRawTag(16);
      output.WriteUInt64(Sequence);
    }
    if (Buffer.Length != 0) {
      output.WriteRawTag(26);
      output.WriteBytes(Buffer);
    }
    if (_unknownFields != null) {
      _unknownFields.WriteTo(output);
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public int CalculateSize() {
    int size = 0;
    if (Command != global::Command.KeepAlive) {
      size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Command);
    }
    if (Sequence != 0UL) {
      size += 1 + pb::CodedOutputStream.ComputeUInt64Size(Sequence);
    }
    if (Buffer.Length != 0) {
      size += 1 + pb::CodedOutputStream.ComputeBytesSize(Buffer);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(GateToClient other) {
    if (other == null) {
      return;
    }
    if (other.Command != global::Command.KeepAlive) {
      Command = other.Command;
    }
    if (other.Sequence != 0UL) {
      Sequence = other.Sequence;
    }
    if (other.Buffer.Length != 0) {
      Buffer = other.Buffer;
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
          Command = (global::Command) input.ReadEnum();
          break;
        }
        case 16: {
          Sequence = input.ReadUInt64();
          break;
        }
        case 26: {
          Buffer = input.ReadBytes();
          break;
        }
      }
    }
  }

}

#endregion


#endregion Designer generated code
