using Google.Protobuf;
using System.Collections;
using System.Collections.Generic;
using System.Net;
using UnityEngine;

public interface INetwork
{
    void Send(byte[] bytes);
    byte[] Recv();
    void Connect();
    void Abort();
}

public class NetworkMgr : MonoBehaviour
{
    public INetwork Login;
    public INetwork Game;
    public SessionCert Cert;

    public delegate void OnLoginServerMessageDelegate(LoginToClient message);
    public delegate void MessageDelegate(ByteString bytes);
    public OnLoginServerMessageDelegate OnLoginServerMessage;

    private readonly Dictionary<CMD, MessageDelegate> listeners = new Dictionary<CMD, MessageDelegate>();
    private readonly Dictionary<ulong, MessageDelegate> callbacks = new Dictionary<ulong, MessageDelegate>();

    private static ulong sequence = 0;

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

    private void Update()
    {
        if (Login != null)
        {
            var buffer = Login.Recv();
            if (buffer != null)
            {
                Debug.Log("Login 收到了消息");
                var message = Message.Parser.ParseFrom(buffer);

                var loginResult = LoginToClient.Parser.ParseFrom(message.Buffer);
                if (OnLoginServerMessage != null)
                    OnLoginServerMessage(loginResult);
            }
        }
        if (Game != null)
        {
            var buffer = Game.Recv();
            if (buffer != null)
            {
                Debug.Log("Game 收到了消息");
                var message = GateToClient.Parser.ParseFrom(buffer);
                if (message.Sequence == 0)
                {
                    if (listeners.ContainsKey(message.CMD))
                    {
                        listeners[message.CMD](message.Buffer);
                    }
                    else
                    {
                        Debug.LogError("没有注册Command " + message.CMD.ToString());
                    }
                }
                else
                {
                    if (callbacks.ContainsKey(message.Sequence))
                    {
                        callbacks[message.Sequence](message.Buffer);
                        callbacks.Remove(message.Sequence);
                    }
                    else
                    {
                        Debug.LogError("没有Sequence回调 " + message.Sequence.ToString());
                    }
                }
            }
        }
    }

    public void ConnectLogin(string ip, int port, int webport)
    {
        if (webport > 0)
            Login = new WSNetwork(ip, webport);
        else
            Login = new Network(ip, port);
        Login.Connect();
    }

    public void CloseLogin()
    {
        if (Login != null)
        {
            Login.Abort();
            Login = null;
        }
    }

    public void ConnectGame(string ip, int port, int webport)
    {
        if (webport > 0)
            Game = new WSNetwork(ip, webport);
        else
            Game = new Network(ip, port);
        Game.Connect();
    }

    public void CloseGame()
    {
        if (Game != null)
        {
            Game.Abort();
            Game = null;
        }
    }

    public void Request(CMD cmd, ByteString bytes, MessageDelegate callback)
    {
        sequence++;
        var togate = new ClientToGate();
        togate.Request = bytes;
        togate.CMD = cmd;
        togate.Sequence = sequence;
        callbacks.Add(sequence, callback);
        Game.Send(togate.ToByteArray());
    }

    public void Notify(CMD cmd, ByteString bytes)
    {
        var togate = new ClientToGate();
        togate.Notify = bytes;
        togate.CMD = cmd;
        Game.Send(togate.ToByteArray());
    }

    public void Listen(CMD cmd, MessageDelegate listener)
    {
        listeners[cmd] = listener;
    }
}
