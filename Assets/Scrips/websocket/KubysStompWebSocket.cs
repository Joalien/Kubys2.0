using System.Text;
using System.Threading.Tasks;
using NativeWebSocket;
using UnityEngine;

// Custom implementation of a STOMP client
// Limitation: for simplicity, user can't subscribe multiples time at the same channel
public class KubysStompWebSocket
{
    private WebSocket websocket;
    private bool isSocketReady = false;

    public static async Task<KubysStompWebSocket> CreateAndConnect(string url, string token)
    {
        KubysStompWebSocket kubysStompWebSocket = new KubysStompWebSocket(url, token);

        while (!kubysStompWebSocket.isSocketReady)
        {
            await Task.Delay(25);
        }

        return kubysStompWebSocket;
    }

    private KubysStompWebSocket(string url, string token)
    {
        Debug.Log("Entering inside my custom STOMP client");
        websocket = new WebSocket(url);

        websocket.OnOpen += () =>
        {
            Debug.Log("OnOpen");
            StompConnect(token);
            Debug.Log("After connection");
            isSocketReady = true;
        };

        websocket.OnError += (e) => { Debug.Log("Error! " + e); };

        websocket.OnClose += (e) => { Debug.Log("Connection closed!"); };

        websocket.OnMessage += (bytes) =>
        {
            // getting the message as a string
            var message = Encoding.UTF8.GetString(bytes);
            Debug.Log("OnMessage! " + message);
        };

        websocket.Connect();
    }

    public async void Subscribe(string channel)
    {
        await websocket.SendText("SUBSCRIBE\n" +
                                 "id:" + channel + "\n" +
                                 "destination:" + channel + "\n" +
                                 "\n" +
                                 "\0");
    }

    public async void SendMessage(string message)
    {
        await websocket.SendText("SEND\n" +
                                 "destination:" + message + "\n" +
                                 "\n" +
                                 "\0");
    }

    public async void Unsubscribe(string channel)
    {
        await websocket.SendText("UNSUBSCRIBE\n" +
                                 "id:" + channel + "\n" +
                                 "destination:" + channel + "\n" +
                                 "\n" +
                                 "\000");
    }

    private async void StompConnect(string token)
    {
        await websocket.SendText("CONNECT\n" +
                                 "login:" + token + "\n" +
                                 "passcode:null\n" +
                                 "accept-version:1.0,1.1,1.2\n" +
                                 "heart-beat:10000,10000\n" +
                                 "\n" +
                                 "\0");
    }
}