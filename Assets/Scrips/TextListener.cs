using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class TextListener : MonoBehaviour
{
    private const int MAX_NUMBER_OF_MESSAGES = 3;
    private readonly Queue<string> _messages = new Queue<string>(MAX_NUMBER_OF_MESSAGES);

    private void Awake()
    {
    }

    private void Start()
    {
        var textPublisher = GetComponent<TextPublisher>();
        textPublisher.messageEvent.AddListener(ShowTextDuringSeconds);
    }

    private void ShowTextDuringSeconds(string text)
    {
        // Debug.Log("receive message : " + text);
        _messages.Enqueue(text);
        while (_messages.Count > MAX_NUMBER_OF_MESSAGES)
        {
            _messages.Dequeue();
        }
        GetComponent<Text>().text = _messages.ToArray().Aggregate("", (current, m) => current + "\n\n- " + m);
    }
}
