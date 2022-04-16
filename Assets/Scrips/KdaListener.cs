using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KdaListener : MonoBehaviour
{
    private PlayerCharacteristics _playerCharacteristics;
    void Start()
    {
        FormatKda(0, 0, 0);
        _playerCharacteristics = GameObject.Find("MyPlayer").GetComponent<PlayerCharacteristics>();
        _playerCharacteristics.kdaUpdate.AddListener(
            () => FormatKda(_playerCharacteristics.Kill, _playerCharacteristics.Death, _playerCharacteristics.Assist)
        );
    }

    private void FormatKda(int k, int d, int a)
    {
        GetComponent<Text>().text = k + " / " + d + " / " + a;
    }
}
