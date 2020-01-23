using System;
using System.Collections;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using UnityEngine;

public class Network
{
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


    public Network(string ip, int port)
    {
        Init(new IPEndPoint(IPAddress.Parse(ip), port));
    }

    public Network(IPEndPoint point)
    {
        Init(point);
    }

    private void Init(IPEndPoint p)
    {
        this.point = p;
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
        if (socket != null)
        {
            socket.Close();
            socket = null;
        }
    }

    /// <summary>
    /// 套接字
    /// </summary>
    private Socket socket;
    IPEndPoint point;

    private Thread sendThread;
    private Thread recvThread;
    /// <summary>
    /// 连接服务器
    /// </summary>
    public void Connect()
    {
        socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        socket.Connect(point);
        sendThread = new Thread(SendThread);
        recvThread = new Thread(ReceiveThread);
        sendThread.Start();
        recvThread.Start();
    }

    public void ReceiveThread()
    {
        byte[] ser_msg = new byte[1024];
        int current = 0;
        while (true)
        {
            while (current < 2)
            {
                int count = socket.Receive(ser_msg, current, 1024 - current, SocketFlags.None);
                current += count;
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
                int count = socket.Receive(ser_msg, current, SocketFlags.None);
                current += count;
            }

            var buffer = new byte[size];
            Array.Copy(ser_msg, 2, buffer, 0, size);
            lock (ReveBuffer)
                ReveBuffer.Enqueue(buffer);

            Array.Copy(ser_msg, size + 2, ser_msg, 0, current - size - 2);
            current = current - size - 2;
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
                socket.Send(buffer);
            }
            else
            {
                Thread.Sleep(1);
            }
        }
    }
}
