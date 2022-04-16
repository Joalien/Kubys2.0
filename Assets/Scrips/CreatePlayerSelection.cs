using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatePlayerSelection : MonoBehaviour
{
    // Reference to the Prefab. Drag a Prefab into this field in the Inspector.
    public GameObject pikachu;
    public int numberOfPlayer = 5;
    public int distance = 10;
    
    // This script will simply instantiate the Prefab when the game starts.
    void Start()
    {
        // Instantiate at position (0, 0, 0) and zero rotation.
        for (var i = 0; i < numberOfPlayer; i++)
        {
            var alpha = (2 * Math.PI / numberOfPlayer * i) - Math.PI / 2;
            
            Instantiate(pikachu, 
                new Vector3((float) (Math.Cos(alpha) * distance), 0, (float) (Math.Sin(alpha) * distance)),
                // Quaternion.Euler(0, 0, -90)
                Quaternion.identity
                );
            
            // pikachu.mesh.rotate(BABYLON.Axis.Y, Math.PI / 2, BABYLON.Space.WORLD);
            // pikachu.mesh.rotate(BABYLON.Axis.Y, -alpha, BABYLON.Space.WORLD);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
