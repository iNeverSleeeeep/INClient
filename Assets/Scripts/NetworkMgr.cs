using Google.Protobuf;
using System.Collections;
using System.Collections.Generic;
using System.Net;
using UnityEngine;

public class NetworkMgr : MonoBehaviour
{
    public Network Login;
    public Network Game;
    public SessionCert Cert;

    public delegate void OnLoginServerMessageDelegate(LoginToClient message);
    public delegate void MessageDelegate(ByteString bytes);
    public OnLoginServerMessageDelegate OnLoginServerMessage;

    private readonly Dictionary<Command, MessageDelegate> listeners = new Dictionary<Command, MessageDelegate>();
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
                    if (listeners.ContainsKey(message.Command))
                    {
                        listeners[message.Command](message.Buffer);
                    }
                    else
                    {
                        Debug.LogError("没有注册Command " + message.Command.ToString());
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

    public void ConnectLogin(string ip, int port)
    {
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

    public void ConnectGame(string ip, int port)
    {
        Game = new Network(ip, port);
        Game.Connect();
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

    public void Request(Command cmd, ByteString bytes, MessageDelegate callback)
    {
        sequence++;
        var togate = new ClientToGate();
        togate.Request = bytes;
        togate.Command = cmd;
        togate.Sequence = sequence;
        callbacks.Add(sequence, callback);
        Game.Send(togate.ToByteArray());
    }

    public void Notify(Command cmd, ByteString bytes)
    {
        var togate = new ClientToGate();
        togate.Notify = bytes;
        togate.Command = cmd;
        Game.Send(togate.ToByteArray());
    }

    public void Listen(Command cmd, MessageDelegate listener)
    {
        listeners[cmd] = listener;
    }
}
