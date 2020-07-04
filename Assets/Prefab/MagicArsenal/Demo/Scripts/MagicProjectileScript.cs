using System;
using System.Linq;
using UnityEngine;

public class MagicProjectileScript : MonoBehaviour
{
    public GameObject impactParticle;
    public GameObject projectileParticle;
    public GameObject muzzleParticle;
    public GameObject[] trailParticles;
    [HideInInspector]
    public Vector3 impactNormal; //Used to rotate impactparticle.
 
    private bool hasCollided = false;
    private const int AreaOfEffect = 5;
    [HideInInspector] public PlayerCharacteristics caster;

    void Start()
    {
        projectileParticle = Instantiate(projectileParticle, transform.position, transform.rotation) as GameObject;
        projectileParticle.transform.parent = transform;
		if (muzzleParticle) {
            muzzleParticle = Instantiate(muzzleParticle, transform.position, transform.rotation) as GameObject;
            Destroy(muzzleParticle, 1.5f); // Lifetime of muzzle effect.
		}
    }
 
    void OnCollisionEnter(Collision hit)
    {
        if (!hasCollided)
        {
            hasCollided = true;
            //transform.DetachChildren();
            if (impactParticle != null) impactParticle = Instantiate(impactParticle, transform.position, Quaternion.FromToRotation(Vector3.up, impactNormal));
            //Debug.DrawRay(hit.contacts[0].point, hit.contacts[0].normal * 1, Color.yellow);
 
            if (hit.gameObject.tag == "Destructible") // Projectile will destroy objects tagged as Destructible
            {
                Destroy(hit.gameObject);
            }
 
 
            //yield WaitForSeconds (0.05);
            foreach (GameObject trail in trailParticles)
            {
                GameObject curTrail = transform.Find(projectileParticle.name + "/" + trail.name).gameObject;
                curTrail.transform.parent = null;
                Destroy(curTrail, 3f);
            }
            Destroy(projectileParticle, 3f);
            if (impactParticle != null) Destroy(impactParticle, 3f);
            Destroy(gameObject);
            //projectileParticle.Stop();
			
			ParticleSystem[] trails = GetComponentsInChildren<ParticleSystem>();
            //Component at [0] is that of the parent i.e. this object (if there is any)
            for (int i = 1; i < trails.Length; i++)
            {
                ParticleSystem trail = trails[i];
                if (!trail.gameObject.name.Contains("Trail"))
                    continue;

                trail.transform.SetParent(null);
                Destroy(trail.gameObject, 2);
            }

            foreach (var player in GameObject.FindGameObjectsWithTag("Player").ToList())
            {
                if ((player.transform.position - hit.GetContact(0).point).sqrMagnitude < Math.Pow(AreaOfEffect, 2))
                {
                    Rigidbody rb = player.GetComponent<Rigidbody>();
                    if (rb)
                    {
                        Vector3 force = Vector3.Normalize(player.transform.position - hit.transform.position) * 100;
                        rb.AddForce(force);
                    }

                    CastSpell(player.GetComponent<PlayerCharacteristics>());
                }
            }
        }
    }

    private void CastSpell(PlayerCharacteristics target)
    {
        // TODO Add complex function to compute damage based on player's stats
        target.DecreaseHealth(200);
        // FIXME Maybe bad design (second check life <= 0 in the code)
        if (target.CurrentHealth <= 0)
        {
            caster.Kill++;
        }
    }
}
