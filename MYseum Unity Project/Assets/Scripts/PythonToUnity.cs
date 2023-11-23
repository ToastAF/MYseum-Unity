using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

public class PythonToUnity : MonoBehaviour
{
    private TcpListener server;
    private Thread listenerThread;
    private TcpClient connectedClient;
    private NetworkStream clientStream;

    int number = 0;
    SpawnMaleri scr;

    private void Start()
    {
        StartServer();
        scr = GameObject.FindGameObjectWithTag("GameController").GetComponent<SpawnMaleri>();
    }

    private void StartServer()
    {
        server = new TcpListener(IPAddress.Any, 5555);
        server.Start();

        Debug.Log("Server listening on port 5555");

        listenerThread = new Thread(new ThreadStart(ListenForClients));
        listenerThread.Start();
    }

    private void ListenForClients()
    {
        while (true)
        {
            TcpClient client = server.AcceptTcpClient();

            // Store the connected client and its stream for continuous communication
            connectedClient = client;
            clientStream = client.GetStream();

            Debug.Log("Client connected");

            // Continuously receive and handle messages from the client
            byte[] message = new byte[4]; // Assuming messages are 4 bytes (int size)
            int bytesRead;

            while (true)
            {
                try
                {
                    bytesRead = clientStream.Read(message, 0, message.Length);

                    if (bytesRead > 0)
                    {
                        int receivedData = BytesToInt(message);
                        Debug.Log($"Received data from Python: {receivedData}");

                        SpawnPainting(receivedData);
                    }
                }
                catch
                {
                    // Handle disconnect or errors
                    Debug.Log("Client disconnected");
                    connectedClient.Close();
                    clientStream = null;
                    break;
                }
            }
        }
    }

    private void SpawnPainting(int number)
    {
        NewMainThreadDispatcher.ExecuteInUpdate(() =>
        {
             scr.spawnNumberedPainting(number);
        });
    }

    private int BytesToInt(byte[] bytes)
    {
        // Convert byte array to integer manually
        return (bytes[0] << 24) | (bytes[1] << 16) | (bytes[2] << 8) | bytes[3];
    }

    private byte[] IntToBytes(int value)
    {
        // Convert integer to byte array manually
        return new byte[] { (byte)(value >> 24), (byte)(value >> 16), (byte)(value >> 8), (byte)value };
    }

    private void OnDestroy()
    {
        if (server != null)
        {
            server.Stop();
        }

        if (connectedClient != null)
        {
            connectedClient.Close();
        }
    }
}
