using Google.Protobuf;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;

public class Enter : MonoBehaviour
{
    public string weburl;
    public Dropdown Zones;
    public Dropdown Roles;
    public InputField RoleName;
    public GameObject CreateRoleRoot;

    public static Player player;

    private IList<object> ZoneList;

    IEnumerator GetZones(string url)
    {
        UnityWebRequest webRequest = UnityWebRequest.Get(url);

        yield return webRequest.SendWebRequest();
        //异常处理，很多博文用了error!=null这是错误的，请看下文其他属性部分
       if (webRequest.isHttpError||webRequest.isNetworkError)
            Debug.Log(webRequest.error);
        else 
        {
            Debug.Log(webRequest.downloadHandler.text);
            ZoneList = SharpJson.JsonDecoder.DecodeText(webRequest.downloadHandler.text) as IList<object>;
            RefreshZonesShow();
            RefreshRolesShow();
        }
    }

    private void OnEnable()
    {
        StartCoroutine(GetZones(weburl));
        RefreshRolesShow();

        NetworkMgr.Instance.OnLoginServerMessage = OnLoginServerMessage;
    }

    private void OnLoginServerMessage(LoginToClient message)
    {
        if (message.Success)
        {
            if (message.Player != null)
            {
                player = message.Player;
                RefreshRolesShow();
            }
            if (message.SessionCert != null)
            {
                NetworkMgr.Instance.Cert = message.SessionCert;
                Debug.Log("成功:" + NetworkMgr.Instance.Cert.UUID + " Address:" + message.GateIP + " Port:" + message.GatePort);
                NetworkMgr.Instance.ConnectGame(message.GateIP, message.GatePort, message.GateWebPort);
                var req = new ConnectGateReq();
                req.SessionCert = message.SessionCert;
                NetworkMgr.Instance.Request(CMD.ConnectGateReq, req.ToByteString(), OnRoleEnterCallback);
            }
        }
        else
        {
            Debug.Log("失败");
        }
    }

    public void RefreshZonesShow()
    {
        List<Dropdown.OptionData> OptionDataList = new List<Dropdown.OptionData>();
        foreach (var zone in ZoneList)
        {
            var optionData = new Dropdown.OptionData();
            optionData.text = (zone as IDictionary<string, object>)["Name"] as string;
            OptionDataList.Add(optionData);
        }
        Zones.ClearOptions();
        Zones.AddOptions(OptionDataList);
    }

    public void OnZoneChange(int value)
    {
        RefreshRolesShow();
    }

    public void RefreshRolesShow()
    {
        List<Dropdown.OptionData> OptionDataList = new List<Dropdown.OptionData>();
        if (player.RoleList != null)
        {
            foreach (var role in player.RoleList)
            {
                if (role.Zone == Zones.value)
                {
                    var optionData = new Dropdown.OptionData();
                    optionData.text = role.Name;
                    OptionDataList.Add(optionData);
                }
            }
        }
        Roles.ClearOptions();
        Roles.AddOptions(OptionDataList);
    }

    public void OnCreateRoleClick()
    {
        CreateRoleRoot.SetActive(true);
    }

    public void OnEnterGameClick()
    {
        if (string.IsNullOrWhiteSpace(Roles.captionText.text))
        {
            Debug.Log("没有角色");
            return;
        }
        var rolename = Roles.captionText.text;
        var uuid = string.Empty;
        foreach (var role in player.RoleList)
        {
            if (rolename == role.Name)
            {
                uuid = role.RoleUUID;
            }
        }
        if (string.IsNullOrEmpty(uuid))
        {
            Debug.LogError("没有找到这个角色");
            return;
        }


        var msg = new ClientToLogin();
        msg.EnterGame = new CLRoleEnterGame();
        msg.EnterGame.RoleUUID = uuid;
        NetworkMgr.Instance.Login.Send(msg.ToByteArray());
    }

    private void OnRoleEnterCallback(ByteString bytes)
    {
        var resp = RoleEnterResp.Parser.ParseFrom(bytes);
        if (resp.Success)
        {
            Debug.Log("进入游戏成功");
            GameLogic.Role = resp.Role;
            var map = string.Format("Map{0}", resp.MapID);
            SceneManager.LoadScene(map, LoadSceneMode.Single);
        }
        else
        {
            Debug.Log("进入游戏失败");
        }
    }

    public void OnCancelCreateRoleClick()
    {
        CreateRoleRoot.SetActive(false);
    }

    public void OnConfirmCreateRoleClick()
    {
        CreateRoleRoot.SetActive(false);
        if (string.IsNullOrWhiteSpace(RoleName.text))
        {
            Debug.Log("不能为空");
            return;
        }

        var msg = new ClientToLogin();
        msg.CreateRole = new CLCreateRole();
        msg.CreateRole.RoleName = RoleName.text;
        msg.CreateRole.Zone = Zones.value;
        NetworkMgr.Instance.Login.Send(msg.ToByteArray());
    }

    private void OnDisable()
    {
        NetworkMgr.Instance.CloseLogin();
    }
}
