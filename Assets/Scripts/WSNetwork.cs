using System;
using System.Collections.Generic;
using System.Net;
using System.Net.WebSockets;
using System.Threading;

public class WSNetwork : INetwork
{
    IPEndPoint point;
    ClientWebSocket ws;


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
        ws = new ClientWebSocket();
        CancellationToken ct = new CancellationToken();

        var url = "ws://" + point.ToString();
        UnityEngine.Debug.Log(url);
        Uri uri = new Uri(url);
        await ws.ConnectAsync(uri, ct);
        UnityEngine.Debug.Log("Connected");
        sendThread = new Thread(SendThread);
        recvThread = new Thread(ReceiveThread);
        sendThread.Start();
        recvThread.Start();
    }

    public async void SendThread()
    {
        CancellationToken ct = new CancellationToken();
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
                UnityEngine.Debug.Log("Before Send");
                await ws.SendAsync(new ArraySegment<byte>(buffer), WebSocketMessageType.Binary, true, ct);
                UnityEngine.Debug.Log("End Send");
            }
            else
            {
                Thread.Sleep(1);
            }
        }
    }
    public async void ReceiveThread()
    {
        byte[] ser_msg = new byte[1024];
        int current = 0;
        CancellationToken ct = new CancellationToken();
        while (true)
        {
            ArraySegment<byte> recvBuf = new ArraySegment<byte>(ser_msg);
            while (current < 2)
            {
                var result = await ws.ReceiveAsync(recvBuf, ct);
                current += result.Count;
            }

            var size = BitConverter.ToUInt16(ser_msg, 0);
            if (BitConverter.IsLittleEndian)
            {
                var buf = BitConverter.GetBytes(size);
                Array.Reverse(buf);
                size = BitConverter.ToUInt16(buf, 0);
            }

            while (current - 2 < size)
            {
                var result = await ws.ReceiveAsync(recvBuf, ct);
                current += result.Count;
            }

            var buffer = new byte[size];
            Array.Copy(ser_msg, 2, buffer, 0, size);
            lock (ReveBuffer)
                ReveBuffer.Enqueue(buffer);

            Array.Copy(ser_msg, size + 2, ser_msg, 0, current - size - 2);
            current = current - size - 2;
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
            ws.Abort();
            ws = null;
        }
	}
}
