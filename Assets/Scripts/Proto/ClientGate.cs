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
          "ChFjbGllbnQtZ2F0ZS5wcm90bxoNY29tbWFuZC5wcm90bxoMcGxheWVyLnBy",
          "b3RvIigKC1Nlc3Npb25DZXJ0EgwKBFVVSUQYASABKAkSCwoDS2V5GAIgASgJ",
          "IjsKDkNHVHJhbnNtaXNzaW9uEhkKB0NvbW1hbmQYASABKA4yCC5Db21tYW5k",
          "Eg4KBkJ1ZmZlchgCIAEoDCJFCg5Db25uZWN0R2F0ZVJlcRIhCgtTZXNzaW9u",
          "Q2VydBgBIAEoCzIMLlNlc3Npb25DZXJ0EhAKCFNlcXVlbmNlGAIgASgEIjsK",
          "D0Nvbm5lY3RHYXRlUmVzcBIPCgdTdWNjZXNzGAEgASgIEhcKBlBsYXllchgC",
          "IAEoCzIHLlBsYXllciIgCgxSb2xlRW50ZXJSZXESEAoIUm9sZVVVSUQYASAB",
          "KAkiIAoNUm9sZUVudGVyUmVzcBIPCgdTdWNjZXNzGAEgASgIIpUBCgxDbGll",
          "bnRUb0dhdGUSIAoHQ29ubmVjdBgBIAEoCzIPLkNvbm5lY3RHYXRlUmVxEiAK",
          "CVJvbGVFbnRlchgCIAEoCzINLlJvbGVFbnRlclJlcRIgCgdSZXF1ZXN0GAMg",
          "ASgLMg8uQ0dUcmFuc21pc3Npb24SHwoGTm90aWZ5GAQgASgLMg8uQ0dUcmFu",
          "c21pc3Npb25CGFoWSU5TZXJ2ZXIvc3JjL3Byb3RvL21zZ2IGcHJvdG8z"));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { global::CommandReflection.Descriptor, global::PlayerReflection.Descriptor, },
        new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::SessionCert), global::SessionCert.Parser, new[]{ "UUID", "Key" }, null, null, null),
          new pbr::GeneratedClrTypeInfo(typeof(global::CGTransmission), global::CGTransmission.Parser, new[]{ "Command", "Buffer" }, null, null, null),
          new pbr::GeneratedClrTypeInfo(typeof(global::ConnectGateReq), global::ConnectGateReq.Parser, new[]{ "SessionCert", "Sequence" }, null, null, null),
          new pbr::GeneratedClrTypeInfo(typeof(global::ConnectGateResp), global::ConnectGateResp.Parser, new[]{ "Success", "Player" }, null, null, null),
          new pbr::GeneratedClrTypeInfo(typeof(global::RoleEnterReq), global::RoleEnterReq.Parser, new[]{ "RoleUUID" }, null, null, null),
          new pbr::GeneratedClrTypeInfo(typeof(global::RoleEnterResp), global::RoleEnterResp.Parser, new[]{ "Success" }, null, null, null),
          new pbr::GeneratedClrTypeInfo(typeof(global::ClientToGate), global::ClientToGate.Parser, new[]{ "Connect", "RoleEnter", "Request", "Notify" }, null, null, null)
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

public sealed partial class CGTransmission : pb::IMessage<CGTransmission> {
  private static readonly pb::MessageParser<CGTransmission> _parser = new pb::MessageParser<CGTransmission>(() => new CGTransmission());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pb::MessageParser<CGTransmission> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::ClientGateReflection.Descriptor.MessageTypes[1]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public CGTransmission() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public CGTransmission(CGTransmission other) : this() {
    command_ = other.command_;
    buffer_ = other.buffer_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public CGTransmission Clone() {
    return new CGTransmission(this);
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

  /// <summary>Field number for the "Buffer" field.</summary>
  public const int BufferFieldNumber = 2;
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
    return Equals(other as CGTransmission);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public bool Equals(CGTransmission other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (Command != other.Command) return false;
    if (Buffer != other.Buffer) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override int GetHashCode() {
    int hash = 1;
    if (Command != global::Command.KeepAlive) hash ^= Command.GetHashCode();
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
    if (Buffer.Length != 0) {
      output.WriteRawTag(18);
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
    if (Buffer.Length != 0) {
      size += 1 + pb::CodedOutputStream.ComputeBytesSize(Buffer);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(CGTransmission other) {
    if (other == null) {
      return;
    }
    if (other.Command != global::Command.KeepAlive) {
      Command = other.Command;
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
        case 18: {
          Buffer = input.ReadBytes();
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
    get { return global::ClientGateReflection.Descriptor.MessageTypes[2]; }
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
    sequence_ = other.sequence_;
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
    if (Sequence != other.Sequence) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override int GetHashCode() {
    int hash = 1;
    if (sessionCert_ != null) hash ^= SessionCert.GetHashCode();
    if (Sequence != 0UL) hash ^= Sequence.GetHashCode();
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
    if (Sequence != 0UL) {
      output.WriteRawTag(16);
      output.WriteUInt64(Sequence);
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
    if (Sequence != 0UL) {
      size += 1 + pb::CodedOutputStream.ComputeUInt64Size(Sequence);
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
    if (other.Sequence != 0UL) {
      Sequence = other.Sequence;
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
        case 16: {
          Sequence = input.ReadUInt64();
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
    get { return global::ClientGateReflection.Descriptor.MessageTypes[3]; }
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
    get { return global::ClientGateReflection.Descriptor.MessageTypes[4]; }
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
    get { return global::ClientGateReflection.Descriptor.MessageTypes[5]; }
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
  public void MergeFrom(RoleEnterResp other) {
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

public sealed partial class ClientToGate : pb::IMessage<ClientToGate> {
  private static readonly pb::MessageParser<ClientToGate> _parser = new pb::MessageParser<ClientToGate>(() => new ClientToGate());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pb::MessageParser<ClientToGate> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::ClientGateReflection.Descriptor.MessageTypes[6]; }
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
    connect_ = other.connect_ != null ? other.connect_.Clone() : null;
    roleEnter_ = other.roleEnter_ != null ? other.roleEnter_.Clone() : null;
    request_ = other.request_ != null ? other.request_.Clone() : null;
    notify_ = other.notify_ != null ? other.notify_.Clone() : null;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public ClientToGate Clone() {
    return new ClientToGate(this);
  }

  /// <summary>Field number for the "Connect" field.</summary>
  public const int ConnectFieldNumber = 1;
  private global::ConnectGateReq connect_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public global::ConnectGateReq Connect {
    get { return connect_; }
    set {
      connect_ = value;
    }
  }

  /// <summary>Field number for the "RoleEnter" field.</summary>
  public const int RoleEnterFieldNumber = 2;
  private global::RoleEnterReq roleEnter_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public global::RoleEnterReq RoleEnter {
    get { return roleEnter_; }
    set {
      roleEnter_ = value;
    }
  }

  /// <summary>Field number for the "Request" field.</summary>
  public const int RequestFieldNumber = 3;
  private global::CGTransmission request_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public global::CGTransmission Request {
    get { return request_; }
    set {
      request_ = value;
    }
  }

  /// <summary>Field number for the "Notify" field.</summary>
  public const int NotifyFieldNumber = 4;
  private global::CGTransmission notify_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public global::CGTransmission Notify {
    get { return notify_; }
    set {
      notify_ = value;
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
    if (!object.Equals(Connect, other.Connect)) return false;
    if (!object.Equals(RoleEnter, other.RoleEnter)) return false;
    if (!object.Equals(Request, other.Request)) return false;
    if (!object.Equals(Notify, other.Notify)) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override int GetHashCode() {
    int hash = 1;
    if (connect_ != null) hash ^= Connect.GetHashCode();
    if (roleEnter_ != null) hash ^= RoleEnter.GetHashCode();
    if (request_ != null) hash ^= Request.GetHashCode();
    if (notify_ != null) hash ^= Notify.GetHashCode();
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
    if (connect_ != null) {
      output.WriteRawTag(10);
      output.WriteMessage(Connect);
    }
    if (roleEnter_ != null) {
      output.WriteRawTag(18);
      output.WriteMessage(RoleEnter);
    }
    if (request_ != null) {
      output.WriteRawTag(26);
      output.WriteMessage(Request);
    }
    if (notify_ != null) {
      output.WriteRawTag(34);
      output.WriteMessage(Notify);
    }
    if (_unknownFields != null) {
      _unknownFields.WriteTo(output);
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public int CalculateSize() {
    int size = 0;
    if (connect_ != null) {
      size += 1 + pb::CodedOutputStream.ComputeMessageSize(Connect);
    }
    if (roleEnter_ != null) {
      size += 1 + pb::CodedOutputStream.ComputeMessageSize(RoleEnter);
    }
    if (request_ != null) {
      size += 1 + pb::CodedOutputStream.ComputeMessageSize(Request);
    }
    if (notify_ != null) {
      size += 1 + pb::CodedOutputStream.ComputeMessageSize(Notify);
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
    if (other.connect_ != null) {
      if (connect_ == null) {
        Connect = new global::ConnectGateReq();
      }
      Connect.MergeFrom(other.Connect);
    }
    if (other.roleEnter_ != null) {
      if (roleEnter_ == null) {
        RoleEnter = new global::RoleEnterReq();
      }
      RoleEnter.MergeFrom(other.RoleEnter);
    }
    if (other.request_ != null) {
      if (request_ == null) {
        Request = new global::CGTransmission();
      }
      Request.MergeFrom(other.Request);
    }
    if (other.notify_ != null) {
      if (notify_ == null) {
        Notify = new global::CGTransmission();
      }
      Notify.MergeFrom(other.Notify);
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
          if (connect_ == null) {
            Connect = new global::ConnectGateReq();
          }
          input.ReadMessage(Connect);
          break;
        }
        case 18: {
          if (roleEnter_ == null) {
            RoleEnter = new global::RoleEnterReq();
          }
          input.ReadMessage(RoleEnter);
          break;
        }
        case 26: {
          if (request_ == null) {
            Request = new global::CGTransmission();
          }
          input.ReadMessage(Request);
          break;
        }
        case 34: {
          if (notify_ == null) {
            Notify = new global::CGTransmission();
          }
          input.ReadMessage(Notify);
          break;
        }
      }
    }
  }

}

#endregion


#endregion Designer generated code
