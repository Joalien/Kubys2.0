using System;
using System.Collections.Generic;
using System.Linq;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

[Serializable]
[CreateAssetMenu(fileName = "Spell", menuName = "ScriptableObjects/Spell", order = 2)]
public class Spell : ScriptableObject
{
    public int manaCost = 35;
    public int cooldown = 2;
    public GameObject previsualizationShape;
    public Texture2D cursorShape;
    // [HideInInspector] public PlayerCharacteristics caster;


    [Header("Attack animation ")]
    public bool hasAnimation = false;
    public int range = 20;
    public int areaOfEffect = 1;
    public int damage = 150;
    public int repulsion = 200;
    public int initialForce = 10;
    public int timeBeforeDestroy = 10;
    public GameObject animation;

    [Header("Movement")]
    public bool hasMovement = false;
    public int dashForce;
    public float dashTime;

    [Header("Charge")]
    public bool hasCharge = false;
    public float chargeTime;
    public float overhead = 1;


    // private void OnParticleCollision(GameObject other) // FIXME
    // {
    //     List<ParticleCollisionEvent> collisionEvents = new List<ParticleCollisionEvent>();
    //     animation.GetComponent<ParticleSystem>().GetCollisionEvents(other, collisionEvents);
    //
    //     foreach (var player in GameObject.FindGameObjectsWithTag("Player").ToList())
    //     {
    //         if ((player.transform.position - collisionEvents[0].intersection).sqrMagnitude < Math.Pow(areaOfEffect, 2))
    //         {
    //
    //             Rigidbody rb = player.GetComponent<Rigidbody>();
    //             if (rb)
    //             {
    //                 Vector3 force = Vector3.Normalize(player.transform.position - collisionEvents[0].intersection) *
    //                                 repulsion;
    //                 rb.AddForce(force);
    //             }
    //
    //             CastSpell(player.GetComponent<PlayerCharacteristics>());
    //         }
    //     }
    // }
    //
    //
    // // TODO use event instead of that poor design
    // private void CastSpell(PlayerCharacteristics target)
    // {
    //     // TODO Add complex function to compute damage based on player's stats
    //     target.DecreaseHealth(damage);
    //     // FIXME Maybe bad design (second check life <= 0 in the code)
    //     if (target.CurrentHealth <= 0)
    //     {
    //         caster.Kill++;
    //     }
    // }
}
