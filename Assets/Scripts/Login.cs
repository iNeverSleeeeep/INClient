using Google.Protobuf;
using System.Collections;
using System.Collections.Generic;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Login : MonoBehaviour
{
    public string LoginIP;
    public int LoginPort;
    public int LoginWebPort;

    public InputField Name;
    public InputField Password;

    private void OnEnable()
    {
        NetworkMgr.Instance.ConnectLogin(LoginIP, LoginPort, LoginWebPort);
        NetworkMgr.Instance.OnLoginServerMessage = OnLoginServerMessage;
    }

    private void OnDisable()
    {
        if (Enter.player == null)
        {
            NetworkMgr.Instance.CloseLogin();
        }
    }

    public void OnLogonClick()
    {
        Debug.Log("LogonClick");
        var msg = new ClientToLogin();
        msg.Logon = new CLLogon();
        msg.Logon.Name = Name.text;
        msg.Logon.PasswordHash = GetHashString(Name.text + Password.text);
        NetworkMgr.Instance.Login.Send(msg.ToByteArray());
    }

    public void OnLoginClick()
    {
        Debug.Log("LoginClick");
        var msg = new ClientToLogin();
        msg.Login = new CLLogin();
        msg.Login.Name = Name.text;
        msg.Login.PasswordHash = GetHashString(Name.text + Password.text);
        NetworkMgr.Instance.Login.Send(msg.ToByteArray());
    }

    private void OnLoginServerMessage(LoginToClient message)
    {
        if (message.Success)
        {
            if (message.Player != null)
            {
                Enter.player = message.Player;
                SceneManager.LoadScene("Enter", LoadSceneMode.Single);
            }
            else
            {
                Debug.Log("成功");
            }
        }
        else
        {
            Debug.Log("失败");
        }
    }

    public static byte[] GetHash(string inputString)
    {
        HashAlgorithm algorithm = MD5.Create();  //or use SHA256.Create();
        return algorithm.ComputeHash(Encoding.UTF8.GetBytes(inputString));
    }


    private static string GetHashString(string inputString)
    {
        StringBuilder sb = new StringBuilder();
        foreach (byte b in GetHash(inputString))
            sb.Append(b.ToString("X2"));
        return sb.ToString();
    }
}
