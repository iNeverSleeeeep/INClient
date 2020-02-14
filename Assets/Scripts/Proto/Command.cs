// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: command.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from command.proto</summary>
public static partial class CommandReflection {

  #region Descriptor
  /// <summary>File descriptor for command.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static CommandReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "Cg1jb21tYW5kLnByb3RvKscGCgNDTUQSDgoKS0VFUF9BTElWRRAAEggKBFJF",
          "U1AQARIICgRHQVRFEAISFAoQQ09OTkVDVF9HQVRFX1JFURAGEhQKEFNFU1NJ",
          "T05fQ0VSVF9OVEYQBxIOCgpDQ0hBVF9DSEFUEAgSDAoIRElTUEFUQ0gQCRIY",
          "ChRMRF9DUkVBVEVfUExBWUVSX1JFURAKEhYKEkdEX0xPQURfUExBWUVSX1JF",
          "URALEhkKFUdEX1JFTEVBU0VfUExBWUVSX05URhAMEhYKEkdEX0NSRUFURV9S",
          "T0xFX1JFURANEhQKEEdEX0xPQURfUk9MRV9SRVEQDhISCg5SRUxPQURfRVRD",
          "X1JFURAPEgwKCE1PVkVfTlRGEBESFQoRTkVBUl9FTlRJVElFU19OVEYQEhIT",
          "Cg9FTlRJVFlfREFUQV9SRVEQExIOCgpST0xFX0VOVEVSEBQSGwoXVVBEQVRF",
          "X1JPTEVfQUREUkVTU19OVEYQFRIbChdSRU1PVkVfUk9MRV9BRERSRVNTX05U",
          "RhAWEhoKFlVQREFURV9NQVBfQUREUkVTU19OVEYQFxIaChZSRU1PVkVfTUFQ",
          "X0FERFJFU1NfTlRGEBgSFwoTR0VUX01BUF9BRERSRVNTX1JFURAZEhcKE0xP",
          "QURfU1RBVElDX01BUF9SRVEQGhIYChRMT0FEX0RZTkFNSUNfTUFQX1JFURAb",
          "Eh4KGlVQREFURV9TVEFUSUNfTUFQX1VVSURfTlRGEBwSGwoXR0VUX1NUQVRJ",
          "Q19NQVBfVVVJRF9SRVEQHRIXChNTQVZFX1NUQVRJQ19NQVBfUkVREB4SGAoU",
          "U0FWRV9EWU5BTUlDX01BUF9SRVEQHxIRCg1TQVZFX1JPTEVfUkVRECASDgoK",
          "R0VUX01BUF9JRBAhEgwKCE1PVkVfSU5GECISGgoWRk9SV0FSRF9QTEFZRVJf",
          "TUVTU0FHRRAjEhEKDVNUT1BfTU9WRV9JTkYQJBITCg5OT0RFX1NUQVJUX05U",
          "RhDoBxIRCgxFVENfU1lOQ19OVEYQ6QcSEwoOTk9ERVNfSU5GT19OVEYQ6gcS",
          "GQoUUkVTRVRfQ09OTkVDVElPTl9OVEYQ6wcSEwoOUk9MRV9MRUFWRV9SRVEQ",
          "7AdCGFoWSU5TZXJ2ZXIvc3JjL3Byb3RvL21zZ2IGcHJvdG8z"));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { },
        new pbr::GeneratedClrTypeInfo(new[] {typeof(global::CMD), }, null));
  }
  #endregion

}
#region Enums
public enum CMD {
  /// <summary>
  /// any -> center
  /// </summary>
  [pbr::OriginalName("KEEP_ALIVE")] KeepAlive = 0,
  [pbr::OriginalName("RESP")] Resp = 1,
  /// <summary>
  /// client -> gate -> any
  /// </summary>
  [pbr::OriginalName("GATE")] Gate = 2,
  /// <summary>
  /// client -> gate
  /// </summary>
  [pbr::OriginalName("CONNECT_GATE_REQ")] ConnectGateReq = 6,
  /// <summary>
  /// gate -> client
  /// </summary>
  [pbr::OriginalName("SESSION_CERT_NTF")] SessionCertNtf = 7,
  /// <summary>
  /// client -> chat
  /// </summary>
  [pbr::OriginalName("CCHAT_CHAT")] CchatChat = 8,
  /// <summary>
  /// any -> dispatcher
  /// </summary>
  [pbr::OriginalName("DISPATCH")] Dispatch = 9,
  /// <summary>
  /// login -> database
  /// </summary>
  [pbr::OriginalName("LD_CREATE_PLAYER_REQ")] LdCreatePlayerReq = 10,
  /// <summary>
  /// gate -> database
  /// </summary>
  [pbr::OriginalName("GD_LOAD_PLAYER_REQ")] GdLoadPlayerReq = 11,
  /// <summary>
  /// gate -> database
  /// </summary>
  [pbr::OriginalName("GD_RELEASE_PLAYER_NTF")] GdReleasePlayerNtf = 12,
  /// <summary>
  /// gate -> database
  /// </summary>
  [pbr::OriginalName("GD_CREATE_ROLE_REQ")] GdCreateRoleReq = 13,
  /// <summary>
  /// gate -> database
  /// </summary>
  [pbr::OriginalName("GD_LOAD_ROLE_REQ")] GdLoadRoleReq = 14,
  /// <summary>
  /// web -> center
  /// </summary>
  [pbr::OriginalName("RELOAD_ETC_REQ")] ReloadEtcReq = 15,
  /// <summary>
  /// world -> client
  /// </summary>
  [pbr::OriginalName("MOVE_NTF")] MoveNtf = 17,
  /// <summary>
  /// world -> client
  /// </summary>
  [pbr::OriginalName("NEAR_ENTITIES_NTF")] NearEntitiesNtf = 18,
  /// <summary>
  /// client -> world
  /// </summary>
  [pbr::OriginalName("ENTITY_DATA_REQ")] EntityDataReq = 19,
  /// <summary>
  /// client -> gate; any -> world
  /// </summary>
  [pbr::OriginalName("ROLE_ENTER")] RoleEnter = 20,
  /// <summary>
  /// any -> gps
  /// </summary>
  [pbr::OriginalName("UPDATE_ROLE_ADDRESS_NTF")] UpdateRoleAddressNtf = 21,
  /// <summary>
  /// gate -> gps
  /// </summary>
  [pbr::OriginalName("REMOVE_ROLE_ADDRESS_NTF")] RemoveRoleAddressNtf = 22,
  /// <summary>
  /// world -> gps
  /// </summary>
  [pbr::OriginalName("UPDATE_MAP_ADDRESS_NTF")] UpdateMapAddressNtf = 23,
  /// <summary>
  /// world -> gps
  /// </summary>
  [pbr::OriginalName("REMOVE_MAP_ADDRESS_NTF")] RemoveMapAddressNtf = 24,
  /// <summary>
  /// database -> gps
  /// </summary>
  [pbr::OriginalName("GET_MAP_ADDRESS_REQ")] GetMapAddressReq = 25,
  /// <summary>
  /// world -> database
  /// </summary>
  [pbr::OriginalName("LOAD_STATIC_MAP_REQ")] LoadStaticMapReq = 26,
  /// <summary>
  /// world -> database
  /// </summary>
  [pbr::OriginalName("LOAD_DYNAMIC_MAP_REQ")] LoadDynamicMapReq = 27,
  /// <summary>
  /// world -> gps
  /// </summary>
  [pbr::OriginalName("UPDATE_STATIC_MAP_UUID_NTF")] UpdateStaticMapUuidNtf = 28,
  /// <summary>
  /// any -> gps
  /// </summary>
  [pbr::OriginalName("GET_STATIC_MAP_UUID_REQ")] GetStaticMapUuidReq = 29,
  /// <summary>
  /// any -> database
  /// </summary>
  [pbr::OriginalName("SAVE_STATIC_MAP_REQ")] SaveStaticMapReq = 30,
  /// <summary>
  /// any -> database
  /// </summary>
  [pbr::OriginalName("SAVE_DYNAMIC_MAP_REQ")] SaveDynamicMapReq = 31,
  /// <summary>
  /// any -> database
  /// </summary>
  [pbr::OriginalName("SAVE_ROLE_REQ")] SaveRoleReq = 32,
  /// <summary>
  /// gate -> world
  /// </summary>
  [pbr::OriginalName("GET_MAP_ID")] GetMapId = 33,
  /// <summary>
  /// client -> world
  /// </summary>
  [pbr::OriginalName("MOVE_INF")] MoveInf = 34,
  /// <summary>
  /// any -> gate -> client
  /// </summary>
  [pbr::OriginalName("FORWARD_PLAYER_MESSAGE")] ForwardPlayerMessage = 35,
  /// <summary>
  /// client -> world
  /// </summary>
  [pbr::OriginalName("STOP_MOVE_INF")] StopMoveInf = 36,
  /// <summary>
  /// any -> center
  /// </summary>
  [pbr::OriginalName("NODE_START_NTF")] NodeStartNtf = 1000,
  /// <summary>
  /// center -> any
  /// </summary>
  [pbr::OriginalName("ETC_SYNC_NTF")] EtcSyncNtf = 1001,
  /// <summary>
  /// any &lt;-> center
  /// </summary>
  [pbr::OriginalName("NODES_INFO_NTF")] NodesInfoNtf = 1002,
  /// <summary>
  /// center -> any
  /// </summary>
  [pbr::OriginalName("RESET_CONNECTION_NTF")] ResetConnectionNtf = 1003,
  /// <summary>
  /// gate -> any
  /// </summary>
  [pbr::OriginalName("ROLE_LEAVE_REQ")] RoleLeaveReq = 1004,
}

#endregion


#endregion Designer generated code
