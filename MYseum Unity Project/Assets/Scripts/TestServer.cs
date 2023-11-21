using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

public class TestServer : MonoBehaviour
{
    private TcpListener listener;
    private const int port = 5555; // Make sure it matches the port used in Python

    //IKKE KØRE DEN HER. DU KOMMER IKKE UD AF WHILE-LOOPET

    void Start()
    {
        listener = new TcpListener(IPAddress.Any, port);
        listener.Start();

        Debug.Log("Server is listening...");

        while (true)
        {
            TcpClient client = listener.AcceptTcpClient();
            NetworkStream stream = client.GetStream();

            byte[] data = new byte[256];
            int bytesRead = stream.Read(data, 0, data.Length);
            string received = Encoding.ASCII.GetString(data, 0, bytesRead);

            Debug.Log("Received: " + received);

            // Handle the received data (convert back to number, etc.)
            // For example:
            int receivedNumber = int.Parse(received);
            Debug.Log("Parsed number: " + receivedNumber);

            stream.Close();
            client.Close();
        }
    }

    void OnDestroy()
    {
        listener.Stop();
    }
}
