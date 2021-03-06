// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: client-chat.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from client-chat.proto</summary>
public static partial class ClientChatReflection {

  #region Descriptor
  /// <summary>File descriptor for client-chat.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static ClientChatReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "ChFjbGllbnQtY2hhdC5wcm90byJSCgxDbGllbnRUb0NoYXQSGwoIQ2hhdFR5",
          "cGUYASABKA4yCS5DaGF0VHlwZRIPCgdNZXNzYWdlGAIgASgJEhQKDFJlY2Vp",
          "dmVyVVVJRBgDIAEoCSJQCgxDaGF0VG9DbGllbnQSGwoIQ2hhdFR5cGUYASAB",
          "KA4yCS5DaGF0VHlwZRIPCgdNZXNzYWdlGAIgASgJEhIKClNlbmRlclVVSUQY",
          "AyABKAkqLQoIQ2hhdFR5cGUSCQoFTE9DQUwQABIJCgVXT1JMRBABEgsKB1BS",
          "SVZBVEUQA0IYWhZJTlNlcnZlci9zcmMvcHJvdG8vbXNnYgZwcm90bzM="));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { },
        new pbr::GeneratedClrTypeInfo(new[] {typeof(global::ChatType), }, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::ClientToChat), global::ClientToChat.Parser, new[]{ "ChatType", "Message", "ReceiverUUID" }, null, null, null),
          new pbr::GeneratedClrTypeInfo(typeof(global::ChatToClient), global::ChatToClient.Parser, new[]{ "ChatType", "Message", "SenderUUID" }, null, null, null)
        }));
  }
  #endregion

}
#region Enums
public enum ChatType {
  [pbr::OriginalName("LOCAL")] Local = 0,
  [pbr::OriginalName("WORLD")] World = 1,
  [pbr::OriginalName("PRIVATE")] Private = 3,
}

#endregion

#region Messages
public sealed partial class ClientToChat : pb::IMessage<ClientToChat> {
  private static readonly pb::MessageParser<ClientToChat> _parser = new pb::MessageParser<ClientToChat>(() => new ClientToChat());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pb::MessageParser<ClientToChat> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::ClientChatReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public ClientToChat() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public ClientToChat(ClientToChat other) : this() {
    chatType_ = other.chatType_;
    message_ = other.message_;
    receiverUUID_ = other.receiverUUID_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public ClientToChat Clone() {
    return new ClientToChat(this);
  }

  /// <summary>Field number for the "ChatType" field.</summary>
  public const int ChatTypeFieldNumber = 1;
  private global::ChatType chatType_ = global::ChatType.Local;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public global::ChatType ChatType {
    get { return chatType_; }
    set {
      chatType_ = value;
    }
  }

  /// <summary>Field number for the "Message" field.</summary>
  public const int MessageFieldNumber = 2;
  private string message_ = "";
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public string Message {
    get { return message_; }
    set {
      message_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
    }
  }

  /// <summary>Field number for the "ReceiverUUID" field.</summary>
  public const int ReceiverUUIDFieldNumber = 3;
  private string receiverUUID_ = "";
  /// <summary>
  /// 私聊的时候需要发接受者ID
  /// </summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public string ReceiverUUID {
    get { return receiverUUID_; }
    set {
      receiverUUID_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override bool Equals(object other) {
    return Equals(other as ClientToChat);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public bool Equals(ClientToChat other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (ChatType != other.ChatType) return false;
    if (Message != other.Message) return false;
    if (ReceiverUUID != other.ReceiverUUID) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override int GetHashCode() {
    int hash = 1;
    if (ChatType != global::ChatType.Local) hash ^= ChatType.GetHashCode();
    if (Message.Length != 0) hash ^= Message.GetHashCode();
    if (ReceiverUUID.Length != 0) hash ^= ReceiverUUID.GetHashCode();
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
    if (ChatType != global::ChatType.Local) {
      output.WriteRawTag(8);
      output.WriteEnum((int) ChatType);
    }
    if (Message.Length != 0) {
      output.WriteRawTag(18);
      output.WriteString(Message);
    }
    if (ReceiverUUID.Length != 0) {
      output.WriteRawTag(26);
      output.WriteString(ReceiverUUID);
    }
    if (_unknownFields != null) {
      _unknownFields.WriteTo(output);
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public int CalculateSize() {
    int size = 0;
    if (ChatType != global::ChatType.Local) {
      size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) ChatType);
    }
    if (Message.Length != 0) {
      size += 1 + pb::CodedOutputStream.ComputeStringSize(Message);
    }
    if (ReceiverUUID.Length != 0) {
      size += 1 + pb::CodedOutputStream.ComputeStringSize(ReceiverUUID);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(ClientToChat other) {
    if (other == null) {
      return;
    }
    if (other.ChatType != global::ChatType.Local) {
      ChatType = other.ChatType;
    }
    if (other.Message.Length != 0) {
      Message = other.Message;
    }
    if (other.ReceiverUUID.Length != 0) {
      ReceiverUUID = other.ReceiverUUID;
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
          ChatType = (global::ChatType) input.ReadEnum();
          break;
        }
        case 18: {
          Message = input.ReadString();
          break;
        }
        case 26: {
          ReceiverUUID = input.ReadString();
          break;
        }
      }
    }
  }

}

public sealed partial class ChatToClient : pb::IMessage<ChatToClient> {
  private static readonly pb::MessageParser<ChatToClient> _parser = new pb::MessageParser<ChatToClient>(() => new ChatToClient());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pb::MessageParser<ChatToClient> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::ClientChatReflection.Descriptor.MessageTypes[1]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public ChatToClient() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public ChatToClient(ChatToClient other) : this() {
    chatType_ = other.chatType_;
    message_ = other.message_;
    senderUUID_ = other.senderUUID_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public ChatToClient Clone() {
    return new ChatToClient(this);
  }

  /// <summary>Field number for the "ChatType" field.</summary>
  public const int ChatTypeFieldNumber = 1;
  private global::ChatType chatType_ = global::ChatType.Local;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public global::ChatType ChatType {
    get { return chatType_; }
    set {
      chatType_ = value;
    }
  }

  /// <summary>Field number for the "Message" field.</summary>
  public const int MessageFieldNumber = 2;
  private string message_ = "";
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public string Message {
    get { return message_; }
    set {
      message_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
    }
  }

  /// <summary>Field number for the "SenderUUID" field.</summary>
  public const int SenderUUIDFieldNumber = 3;
  private string senderUUID_ = "";
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public string SenderUUID {
    get { return senderUUID_; }
    set {
      senderUUID_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override bool Equals(object other) {
    return Equals(other as ChatToClient);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public bool Equals(ChatToClient other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (ChatType != other.ChatType) return false;
    if (Message != other.Message) return false;
    if (SenderUUID != other.SenderUUID) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override int GetHashCode() {
    int hash = 1;
    if (ChatType != global::ChatType.Local) hash ^= ChatType.GetHashCode();
    if (Message.Length != 0) hash ^= Message.GetHashCode();
    if (SenderUUID.Length != 0) hash ^= SenderUUID.GetHashCode();
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
    if (ChatType != global::ChatType.Local) {
      output.WriteRawTag(8);
      output.WriteEnum((int) ChatType);
    }
    if (Message.Length != 0) {
      output.WriteRawTag(18);
      output.WriteString(Message);
    }
    if (SenderUUID.Length != 0) {
      output.WriteRawTag(26);
      output.WriteString(SenderUUID);
    }
    if (_unknownFields != null) {
      _unknownFields.WriteTo(output);
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public int CalculateSize() {
    int size = 0;
    if (ChatType != global::ChatType.Local) {
      size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) ChatType);
    }
    if (Message.Length != 0) {
      size += 1 + pb::CodedOutputStream.ComputeStringSize(Message);
    }
    if (SenderUUID.Length != 0) {
      size += 1 + pb::CodedOutputStream.ComputeStringSize(SenderUUID);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(ChatToClient other) {
    if (other == null) {
      return;
    }
    if (other.ChatType != global::ChatType.Local) {
      ChatType = other.ChatType;
    }
    if (other.Message.Length != 0) {
      Message = other.Message;
    }
    if (other.SenderUUID.Length != 0) {
      SenderUUID = other.SenderUUID;
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
          ChatType = (global::ChatType) input.ReadEnum();
          break;
        }
        case 18: {
          Message = input.ReadString();
          break;
        }
        case 26: {
          SenderUUID = input.ReadString();
          break;
        }
      }
    }
  }

}

#endregion


#endregion Designer generated code
