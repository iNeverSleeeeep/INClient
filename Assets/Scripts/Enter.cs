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
        List<Dropdown.OptionData> OpenDataList = new List<Dropdown.OptionData>();
        foreach (var zone in ZoneList)
        {
            var optionData = new Dropdown.OptionData();
            optionData.text = (zone as IDictionary<string, object>)["Name"] as string;
            OpenDataList.Add(optionData);
        }
        Zones.ClearOptions();
        Zones.AddOptions(OpenDataList);
    }

    public void RefreshRolesShow()
    {

    }

    public void OnCreateRoleClick()
    {

    }

    public void OnEnterGameClick()
    {

    }

    public void OnCancelCreateRoleClick()
    {

    }

    public void OnConfirmCreateRoleClick()
    {

    }
}
