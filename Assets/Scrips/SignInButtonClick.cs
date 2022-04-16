using System;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;
using System.Collections;

public class SignInButtonClick : MonoBehaviour
{
    private static string SIGN_IN_URL = "https://identitytoolkit.googleapis.com/v1/accounts:signInWithPassword";
    private static string PUBLIC_API_KEY = "AIzaSyDmXTP9dZiqvzc2o1d0VREobnx4sFVduxY";

    public void ClickOnTheButton()
    {
        // Poor design, don't use expensive function inside coroutine !!!
        StartCoroutine(LogInOnClick("josquin.cornec@insa-lyon.fr", "testtest"));
        Debug.Log("Button clicked !");
    }

    private IEnumerator LogInOnClick(string email, string password)
    {
       WWWForm form = new WWWForm();
       form.AddField("email", email);
       form.AddField("password", password);
       form.AddField("returnSecureToken", "true");

       using (UnityWebRequest www = UnityWebRequest.Post(SIGN_IN_URL + "?key=" + PUBLIC_API_KEY, form))
       {
           Debug.Log("Before sending request");
           yield return www.SendWebRequest();
           Debug.Log("After sending request");

           if (www.isNetworkError || www.isHttpError)
           {
               Debug.Log(www.error);
           }
           else
           {
               Debug.Log("Successfully get token !");
               SignInResponse response = JsonUtility.FromJson<SignInResponse>(www.downloadHandler.text);
               OpenWebSocketConnection(response.idToken);
           }
       }
    }

    private async void OpenWebSocketConnection(string token)
    {
        Debug.Log("Creating websocket ...");
        KubysStompWebSocket websocket = await KubysStompWebSocket.CreateAndConnect("ws://192.168.1.6:8080/connect", token);

        Debug.Log("Websocket created !");
        websocket.Subscribe("/user/getPlayers");
        websocket.SendMessage("/getPlayers");
        websocket.Unsubscribe("/user/getPlayers");
        SwitchScene(1);
    }
    
    private void SwitchScene(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex);
    }
}

[Serializable]
internal struct SignInResponse // struct keywork not tested
{
    string kind;
    string localId;
    string email;
    string displayName;
    public string idToken;
    string registered;
    string refreshToken;
    string expiresIn;
}