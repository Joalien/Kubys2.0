using System;
using UnityEngine;
using UnityEngine.Events;

public class TextPublisher : MonoBehaviour
{
    [HideInInspector] public TextEvent messageEvent;

    private void Awake()
    {
        messageEvent = new TextEvent();
    }

    private void Start()
    {
        var playerCharacteristics = GameObject.Find("MyPlayer").GetComponent<PlayerCharacteristics>();
        var playerCharacteristicsDeathOfPlayer = playerCharacteristics.deathOfPlayer;
        playerCharacteristicsDeathOfPlayer.AddListener(DeathOfPlayer);
    }

    public void SendNewMessage(string message)
    {
        // Debug.Log("send message : " + message);
        messageEvent.Invoke(message);
    }


    private void DeathOfPlayer()
    {
        SendNewMessage("You have been KILLED !");
    }

    [Serializable]
    public class TextEvent : UnityEvent<string>
    {
    }
}
