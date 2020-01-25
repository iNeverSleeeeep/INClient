using Google.Protobuf;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;

public class Enter : MonoBehaviour
{
    public string weburl;
    public Dropdown Zones;
    public Dropdown Roles;
    public InputField RoleName;
    public GameObject CreateRoleRoot;

    public Player player;

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
        }
    }

    private void OnEnable()
    {
        StartCoroutine(GetZones(weburl));
        var req = new ConnectGateReq();
        req.SessionCert = NetworkMgr.Instance.Cert;
        NetworkMgr.Instance.Request(Command.ConnectGateReq, req.ToByteString(), OnConnectGateCallback);
    }

    public void OnConnectGateCallback(ByteString bytes)
    {
        var resp = ConnectGateResp.Parser.ParseFrom(bytes);
        if (resp.Success)
        {
            Debug.Log("连接Gate成功");
            player = resp.Player;
            RefreshRolesShow();
        }
        else
        {
            Debug.Log("连接Gate失败");
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
        var req = new CreateRoleReq();
        req.RoleName = RoleName.text;
        req.PlayerUUID = NetworkMgr.Instance.Cert.UUID;
        req.Zone = Zones.value;
        NetworkMgr.Instance.Request(Command.GdCreateRoleReq, req.ToByteString(), OnCreateRoleCallback);
    }

    private void OnCreateRoleCallback(ByteString bytes)
    {
        var resp = CreateRoleResp.Parser.ParseFrom(bytes);
        if (resp.Success)
        {
            player.RoleList.Add(resp.Role);
            Debug.Log("创建角色成功");
            RefreshRolesShow();
        }
        else
        {
            Debug.Log("创建角色失败");
        }
    }
}
