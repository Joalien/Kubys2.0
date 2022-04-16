using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public abstract class CatchableObject : MonoBehaviour
{
    public float grabDistance = 1;
    
    private List<PlayerCharacteristics> _players;

    // Start is called before the first frame update
    void Start()
    {
        _players = GameObject.FindGameObjectsWithTag("Player")
            .ToList()
            .Select(o => o.GetComponent<PlayerCharacteristics>())
            .ToList();
    }

    // Update is called once per frame
    void Update()
    {
        foreach (var player in _players)
        {
            if (IsCloseEnoughFromPlayer(player))
            {
                ExecuteBehaviour(player);
            }
        }
    }

    private bool IsCloseEnoughFromPlayer(PlayerCharacteristics player)
    {
        Vector3 playerPosition = player.transform.position;
        Vector3 objectPosition = gameObject.transform.position;
        
        Vector2 player2dPosition = new Vector2(playerPosition.x, playerPosition.z);
        Vector2 object2dPosition = new Vector2(objectPosition.x, objectPosition.z);
        
        bool isCloseEnough2D = (player2dPosition - object2dPosition).sqrMagnitude < Math.Pow(grabDistance, 2);
        bool isCloseEnoughY = objectPosition.y - playerPosition.y < grabDistance * 2f;
        bool isInsideCylinder = isCloseEnoughY && isCloseEnough2D;
        return isInsideCylinder;
    }

    protected abstract void ExecuteBehaviour(PlayerCharacteristics player);
}