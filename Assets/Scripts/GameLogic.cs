using Google.Protobuf;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class GameLogic : MonoBehaviour
{
    public static Role Role;
    public static Dictionary<string, EntityData> EntitiesData = new Dictionary<string, EntityData>();
    public static Dictionary<string, GameObject> Entities = new Dictionary<string, GameObject>();

    public CinemachineVirtualCamera VirtualCamera;

    private GameObject m_RoleObject;
    private bool m_InMove;
    private UnityEngine.Vector3 m_MoveTargetPosition;
    private UnityEngine.Vector3 m_MoveTargetDirection;

    private void OnEnable()
    {
        var transformComponent = Role.OnlineData.EntityData.Components[(int)ComponentType.Transofrm].Transform;
        var obj = Instantiate(Resources.Load("Prefabs/Boy"), transformComponent.Position, transformComponent.Rotation);
        m_RoleObject = obj as GameObject;
        VirtualCamera.Follow = m_RoleObject.transform;
        VirtualCamera.LookAt = m_RoleObject.transform;

        NetworkMgr.Instance.Listen(CMD.NearEntitiesNtf, NearEntitiesNtf);
    }

    private void Update()
    {
        HandleRoleMove();
        UpdateRolePosition();
    }

    private void HandleRoleMove()
    {
        var dir = UnityEngine.Vector3.zero;
        if (Input.GetKey(KeyCode.A))
            dir.x = -1;
        if (Input.GetKey(KeyCode.W))
            dir.z = 1;
        if (Input.GetKey(KeyCode.S))
            dir.z = -1;
        if (Input.GetKey(KeyCode.D))
            dir.x = 1;

        var oldDirection = m_MoveTargetDirection;
        m_MoveTargetDirection = dir;
        if (m_InMove && dir == UnityEngine.Vector3.zero)
        {
            m_InMove = false;
            SendStopMove();
        }
        else if (m_InMove == false && dir != UnityEngine.Vector3.zero)
        {
            m_InMove = true;
            m_MoveTargetPosition = m_RoleObject.transform.position + dir * 10;
            SendMove();
        }
        else if (m_InMove)
        {
            if (oldDirection != dir)
            {
                m_MoveTargetPosition = m_RoleObject.transform.position + dir * 10;
                SendMove();
            }
            else
            {
                var targetPosition = m_RoleObject.transform.position + dir * 10;
                if ((targetPosition - m_MoveTargetPosition).magnitude > 9)
                {
                    m_MoveTargetPosition = m_RoleObject.transform.position + dir * 10;
                    SendMove();
                }
            }
        }
        m_RoleObject.GetComponent<Animator>().SetBool("move", m_InMove);
        if (m_InMove)
        {
            m_RoleObject.transform.forward = m_MoveTargetDirection;
        }
    }

    private void UpdateRolePosition()
    {
        if (m_InMove)
        {
            var physicsComponent = Role.OnlineData.EntityData.Components[(int)ComponentType.Physics].Physics;
            UnityEngine.Vector3 deltaPosition = (physicsComponent.RawSpeed + physicsComponent.PassiveSpeed) * Time.deltaTime;
            m_RoleObject.transform.position += deltaPosition;
        }
    }

    private void SendStopMove()
    {
        var physicsComponent = Role.OnlineData.EntityData.Components[(int)ComponentType.Physics].Physics;
        physicsComponent.RawSpeed = UnityEngine.Vector3.zero;
        var stop = new StopMoveINF();
        stop.Position = m_RoleObject.transform.position;
        NetworkMgr.Instance.Notify(CMD.StopMoveInf, stop.ToByteString());
    }

    private void SendMove()
    {
        var physicsComponent = Role.OnlineData.EntityData.Components[(int)ComponentType.Physics].Physics;
        var attributeComponent = Role.OnlineData.EntityData.Components[(int)ComponentType.Attribute].Attribute;
        physicsComponent.RawSpeed = m_MoveTargetDirection.normalized * attributeComponent.Speed;
        var move = new MoveINF();
        move.Position = m_RoleObject.transform.position;
        move.To = m_MoveTargetPosition;
        NetworkMgr.Instance.Notify(CMD.MoveInf, move.ToByteString());
    }

    private void NearEntitiesNtf(ByteString bytes)
    {
        var ntf = NearEntitiesNTF.Parser.ParseFrom(bytes);
        if (ntf != null)
        {
            var req = new EntityDataReq();
            foreach (var entity in ntf.Entities)
            {
                if (EntitiesData.ContainsKey(entity.EntityUUID) == false && entity.EntityUUID != Role.SummaryData.RoleUUID)
                {
                    req.EntityUUIDs.Add(entity.EntityUUID);
                }
            }
            var del = new List<string>();
            foreach (var uuid in EntitiesData.Keys)
            {
                var contains = false;
                foreach (var entity in ntf.Entities)
                {
                    if (entity.EntityUUID == uuid)
                    {
                        contains = true;
                        break;
                    }
                }
                if (contains == false)
                    del.Add(uuid);
            }
            foreach (var uuid in del)
            {
                EntitiesData.Remove(uuid);
                Destroy(Entities[uuid]);
                Entities.Remove(uuid);
            }
            NetworkMgr.Instance.Request(CMD.EntityDataReq, req.ToByteString(), OnEntityDataResp);
        }
    }

    private void OnEntityDataResp(ByteString bytes)
    {
        var resp = EntityDataRes.Parser.ParseFrom(bytes);
        if (resp != null)
        {
            foreach (var entityData in resp.Entities)
            {
                EntitiesData[entityData.EntityUUID] = entityData;
                if (Entities.ContainsKey(entityData.EntityUUID) == false)
                {
                    var transformComponent = entityData.Components[(int)(ComponentType.Transofrm)].Transform;
                    var go = Instantiate(Resources.Load("Prefabs/Boy"), transformComponent.Position, transformComponent.Rotation) as GameObject;
                    Entities[entityData.EntityUUID] = go;
                }
            }
        }
    }
}
