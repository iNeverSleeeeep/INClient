// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: gate-world.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from gate-world.proto</summary>
public static partial class GateWorldReflection {

  #region Descriptor
  /// <summary>File descriptor for gate-world.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static GateWorldReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "ChBnYXRlLXdvcmxkLnByb3RvIh4KC0dldE1hcElEUmVxEg8KB01hcFVVSUQY",
          "ASABKAkiHQoMR2V0TWFwSURSZXNwEg0KBU1hcElEGAEgASgFQhhaFklOU2Vy",
          "dmVyL3NyYy9wcm90by9tc2diBnByb3RvMw=="));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { },
        new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::GetMapIDReq), global::GetMapIDReq.Parser, new[]{ "MapUUID" }, null, null, null),
          new pbr::GeneratedClrTypeInfo(typeof(global::GetMapIDResp), global::GetMapIDResp.Parser, new[]{ "MapID" }, null, null, null)
        }));
  }
  #endregion

}
#region Messages
public sealed partial class GetMapIDReq : pb::IMessage<GetMapIDReq> {
  private static readonly pb::MessageParser<GetMapIDReq> _parser = new pb::MessageParser<GetMapIDReq>(() => new GetMapIDReq());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pb::MessageParser<GetMapIDReq> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::GateWorldReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public GetMapIDReq() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public GetMapIDReq(GetMapIDReq other) : this() {
    mapUUID_ = other.mapUUID_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public GetMapIDReq Clone() {
    return new GetMapIDReq(this);
  }

  /// <summary>Field number for the "MapUUID" field.</summary>
  public const int MapUUIDFieldNumber = 1;
  private string mapUUID_ = "";
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public string MapUUID {
    get { return mapUUID_; }
    set {
      mapUUID_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override bool Equals(object other) {
    return Equals(other as GetMapIDReq);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public bool Equals(GetMapIDReq other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (MapUUID != other.MapUUID) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override int GetHashCode() {
    int hash = 1;
    if (MapUUID.Length != 0) hash ^= MapUUID.GetHashCode();
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
    if (MapUUID.Length != 0) {
      output.WriteRawTag(10);
      output.WriteString(MapUUID);
    }
    if (_unknownFields != null) {
      _unknownFields.WriteTo(output);
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public int CalculateSize() {
    int size = 0;
    if (MapUUID.Length != 0) {
      size += 1 + pb::CodedOutputStream.ComputeStringSize(MapUUID);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(GetMapIDReq other) {
    if (other == null) {
      return;
    }
    if (other.MapUUID.Length != 0) {
      MapUUID = other.MapUUID;
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
          MapUUID = input.ReadString();
          break;
        }
      }
    }
  }

}

public sealed partial class GetMapIDResp : pb::IMessage<GetMapIDResp> {
  private static readonly pb::MessageParser<GetMapIDResp> _parser = new pb::MessageParser<GetMapIDResp>(() => new GetMapIDResp());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pb::MessageParser<GetMapIDResp> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::GateWorldReflection.Descriptor.MessageTypes[1]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public GetMapIDResp() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public GetMapIDResp(GetMapIDResp other) : this() {
    mapID_ = other.mapID_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public GetMapIDResp Clone() {
    return new GetMapIDResp(this);
  }

  /// <summary>Field number for the "MapID" field.</summary>
  public const int MapIDFieldNumber = 1;
  private int mapID_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public int MapID {
    get { return mapID_; }
    set {
      mapID_ = value;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override bool Equals(object other) {
    return Equals(other as GetMapIDResp);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public bool Equals(GetMapIDResp other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (MapID != other.MapID) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override int GetHashCode() {
    int hash = 1;
    if (MapID != 0) hash ^= MapID.GetHashCode();
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
    if (MapID != 0) {
      output.WriteRawTag(8);
      output.WriteInt32(MapID);
    }
    if (_unknownFields != null) {
      _unknownFields.WriteTo(output);
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public int CalculateSize() {
    int size = 0;
    if (MapID != 0) {
      size += 1 + pb::CodedOutputStream.ComputeInt32Size(MapID);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(GetMapIDResp other) {
    if (other == null) {
      return;
    }
    if (other.MapID != 0) {
      MapID = other.MapID;
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
          MapID = input.ReadInt32();
          break;
        }
      }
    }
  }

}

#endregion


#endregion Designer generated code
