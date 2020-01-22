// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: map.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from map.proto</summary>
public static partial class MapReflection {

  #region Descriptor
  /// <summary>File descriptor for map.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static MapReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "CgltYXAucHJvdG8aDGVudGl0eS5wcm90byJPCgdNYXBEYXRhEg8KB01hcFVV",
          "SUQYASABKAkSFAoMTGFzdFRpY2tUaW1lGAIgASgDEh0KCEVudGl0aWVzGAMg",
          "AygLMgsuRW50aXR5RGF0YUIZWhdJTlNlcnZlci9zcmMvcHJvdG8vZGF0YWIG",
          "cHJvdG8z"));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { global::EntityReflection.Descriptor, },
        new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::MapData), global::MapData.Parser, new[]{ "MapUUID", "LastTickTime", "Entities" }, null, null, null)
        }));
  }
  #endregion

}
#region Messages
public sealed partial class MapData : pb::IMessage<MapData> {
  private static readonly pb::MessageParser<MapData> _parser = new pb::MessageParser<MapData>(() => new MapData());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pb::MessageParser<MapData> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::MapReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public MapData() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public MapData(MapData other) : this() {
    mapUUID_ = other.mapUUID_;
    lastTickTime_ = other.lastTickTime_;
    entities_ = other.entities_.Clone();
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public MapData Clone() {
    return new MapData(this);
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

  /// <summary>Field number for the "LastTickTime" field.</summary>
  public const int LastTickTimeFieldNumber = 2;
  private long lastTickTime_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public long LastTickTime {
    get { return lastTickTime_; }
    set {
      lastTickTime_ = value;
    }
  }

  /// <summary>Field number for the "Entities" field.</summary>
  public const int EntitiesFieldNumber = 3;
  private static readonly pb::FieldCodec<global::EntityData> _repeated_entities_codec
      = pb::FieldCodec.ForMessage(26, global::EntityData.Parser);
  private readonly pbc::RepeatedField<global::EntityData> entities_ = new pbc::RepeatedField<global::EntityData>();
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public pbc::RepeatedField<global::EntityData> Entities {
    get { return entities_; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override bool Equals(object other) {
    return Equals(other as MapData);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public bool Equals(MapData other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (MapUUID != other.MapUUID) return false;
    if (LastTickTime != other.LastTickTime) return false;
    if(!entities_.Equals(other.entities_)) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override int GetHashCode() {
    int hash = 1;
    if (MapUUID.Length != 0) hash ^= MapUUID.GetHashCode();
    if (LastTickTime != 0L) hash ^= LastTickTime.GetHashCode();
    hash ^= entities_.GetHashCode();
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
    if (LastTickTime != 0L) {
      output.WriteRawTag(16);
      output.WriteInt64(LastTickTime);
    }
    entities_.WriteTo(output, _repeated_entities_codec);
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
    if (LastTickTime != 0L) {
      size += 1 + pb::CodedOutputStream.ComputeInt64Size(LastTickTime);
    }
    size += entities_.CalculateSize(_repeated_entities_codec);
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(MapData other) {
    if (other == null) {
      return;
    }
    if (other.MapUUID.Length != 0) {
      MapUUID = other.MapUUID;
    }
    if (other.LastTickTime != 0L) {
      LastTickTime = other.LastTickTime;
    }
    entities_.Add(other.entities_);
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
        case 16: {
          LastTickTime = input.ReadInt64();
          break;
        }
        case 26: {
          entities_.AddEntriesFrom(input, _repeated_entities_codec);
          break;
        }
      }
    }
  }

}

#endregion


#endregion Designer generated code
