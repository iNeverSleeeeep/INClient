using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class GameLogic : MonoBehaviour
{
    public CinemachineVirtualCamera VirtualCamera;

    private GameObject m_RoleObject;
    private bool m_InMove;
    private UnityEngine.Vector3 m_MoveTargetPosition;
    private UnityEngine.Vector3 m_MoveTargetDirection;
    private Role m_Role;

    private void OnEnable()
    {
        m_RoleObject = new GameObject("Role");
        VirtualCamera.Follow = m_RoleObject.transform;
        VirtualCamera.LookAt = m_RoleObject.transform;
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
            if (m_MoveTargetDirection != dir)
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
    }

    private void UpdateRolePosition()
    {
        if (m_InMove)
        {
            var physicsComponent = m_Role.OnlineData.EntityData.Components[(int)ComponentType.Transofrm].Physics;
            UnityEngine.Vector3 deltaPosition = (physicsComponent.RawSpeed + physicsComponent.PassiveSpeed) * Time.deltaTime;
            m_RoleObject.transform.position += deltaPosition;
        }
    }

    private void SendStopMove()
    {

    }

    private void SendMove()
    {

    }
}
