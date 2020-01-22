using System.Collections;
using System.Collections.Generic;
using System.Net;
using UnityEngine;

public class NetworkMgr : MonoBehaviour
{
    public Network Login;
    public Network Game;
    public SessionCert Cert;

    private static NetworkMgr instance;
    public static NetworkMgr Instance
    {
        get
        {
            if (instance == null)
            {
                var go = new GameObject("NetworkMgr");
                DontDestroyOnLoad(go);
                instance = go.AddComponent<NetworkMgr>();
            }
            return instance;
        }
    }

    private void OnDestroy()
    {
        CloseLogin();
        CloseGame();
    }

    public void ConnectLogin(string ip, int port)
    {
        Login = new Network(ip, port);
    }

    public void CloseLogin()
    {
        if (Login != null)
        {
            Login.Abort();
            Login = null;
        }
    }

    public void ConnectGame(string ip, int port)
    {
        Game = new Network(ip, port);
    }

    public void ConnectGame(IPEndPoint point)
    {
        Game = new Network(point);
    }

    public void CloseGame()
    {
        if (Game != null)
        {
            Game.Abort();
            Game = null;
        }
    }
}
