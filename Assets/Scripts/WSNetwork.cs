using System;
using System.Collections.Generic;
using WebSocketSharp;
using System.Threading;
using System.Net;

public class WSNetwork : INetwork
{
    IPEndPoint point;
    WebSocket ws;

    public WSNetwork(string ip, int port)
	{
		Init(new IPEndPoint(IPAddress.Parse(ip), port));
	}

	public WSNetwork(IPEndPoint point)
	{
		Init(point);
	}

	private void Init(IPEndPoint p)
	{
		this.point = p;
    }
    private Queue<byte[]> SendBuffer = new Queue<byte[]>();
    private Queue<byte[]> ReveBuffer = new Queue<byte[]>();

    public void Send(byte[] bytes)
    {
        lock (SendBuffer)
        {
            SendBuffer.Enqueue(bytes);
        }
    }

    public byte[] Recv()
    {
        lock (ReveBuffer)
        {
            if (ReveBuffer.Count > 0)
                return ReveBuffer.Dequeue();
            return null;
        }
    }

    private Thread sendThread;
    private Thread recvThread;
    public async void Connect()
	{
        CancellationToken ct = new CancellationToken();

        var url = "ws://" + point.ToString();
        UnityEngine.Debug.Log(url);
        ws = new WebSocket(url);
        ws.OnOpen += (sender, args) =>
        {
            sendThread = new Thread(SendThread);
            sendThread.Start();
            recvThread = new Thread(RecvThread);
            recvThread.Start();
        };
        ws.ConnectAsync();
    }

    public void OnMessage(object sender, MessageEventArgs args)
    {

    }

    public void RecvThread()
    {
        byte[] ser_msg = new byte[1024];
        int current = 0;
        ws.OnMessage += (sender, args) =>
        {
            lock (ser_msg)
            {
                Array.Copy(args.RawData, 0, ser_msg, current, args.RawData.Length);
                current = current + args.RawData.Length;
            }
        };
        while (true)
        {
            int currentTemp = 0;
            lock (ser_msg)
            {
                currentTemp = current;
            }
            if (currentTemp < 2)
            {
                Thread.Sleep(1);
                continue;
            }
            ushort size = 0;
            lock (ser_msg)
            {
                size = BitConverter.ToUInt16(ser_msg, 0);
            }
            if (BitConverter.IsLittleEndian)
            {
                var buf = BitConverter.GetBytes(size);
                Array.Reverse(buf);
                size = BitConverter.ToUInt16(buf, 0);
            }

            if (currentTemp - 2 < size)
            {
                Thread.Sleep(1);
                continue;
            }

            lock (ser_msg)
            {
                var buffer = new byte[size];
                Array.Copy(ser_msg, 2, buffer, 0, size);
                lock (ReveBuffer)
                    ReveBuffer.Enqueue(buffer);

                Array.Copy(ser_msg, size + 2, ser_msg, 0, current - size - 2);
                current = current - size - 2;
            }
        }
    }

    public void SendThread()
    {
        while (true)
        {
            byte[] bytes = null;
            lock (SendBuffer)
            {
                if (SendBuffer.Count > 0)
                    bytes = SendBuffer.Dequeue();
            }
            if (bytes != null)
            {
                var size = BitConverter.GetBytes((short)(bytes.Length));
                if (BitConverter.IsLittleEndian)
                    Array.Reverse(size);
                var buffer = new byte[bytes.Length + 2];
                Array.Copy(size, buffer, 2);
                Array.Copy(bytes, 0, buffer, 2, bytes.Length);
                ws.Send(buffer);
            }
            else
            {
                Thread.Sleep(1);
            }
        }
    }

    public void Abort()
    {
        if (sendThread != null)
        {
            sendThread.Abort();
            sendThread = null;
        }
        if (recvThread != null)
        {
            recvThread.Abort();
            recvThread = null;
        }
        if (ws != null)
        {
            ws.Close();
            ws = null;
        }
	}
}