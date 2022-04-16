using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class GrabWeapon : MonoBehaviour
{
    public float grabWeaponDistance = 1;
    public Transform weaponHandler;
    public string dropWeaponLetter = "w";

    private List<GameObject> _weapons;
    private Vector3 weaponPosition = Vector3.zero;
    private Vector3 weaponRotation = new Vector3(0, 270, 300);
    private Vector3 weaponScale = new Vector3(0.8f, 0.8f, 0.8f);
    private List<GameObject> _lastDroppedWeapons = new List<GameObject>();

    // Start is called before the first frame update
    void Start()
    {
        _weapons = GameObject.FindGameObjectsWithTag("Weapon").ToList();
        GetComponent<PlayerCharacteristics>().deathOfPlayer.AddListener(DropWeapon);
    }

    // Update is called once per frame
    void Update()
    {
        foreach (var weapon in _weapons)
        {
            if (_lastDroppedWeapons.Contains(weapon))
            {
                bool isPlayerFarEnoughtFromWeapon = (weapon.transform.position - weaponHandler.position).sqrMagnitude > Math.Pow(grabWeaponDistance * 1.2, 2);
                if (isPlayerFarEnoughtFromWeapon)
                {
                    _lastDroppedWeapons.Remove(weapon);
                }
                else
                {
                    continue;
                }
            }

            bool isPlayerNearWeapon = (weapon.transform.position - weaponHandler.position).sqrMagnitude < Math.Pow(grabWeaponDistance, 2);
            if (isPlayerNearWeapon && !weapon.GetComponent<WeaponCharacteristics>().isHandled)
            {
                if (weaponHandler.childCount == 1)
                {
                    DropWeapon();
                } 

                weapon.GetComponent<WeaponCharacteristics>().isHandled = true;
                weapon.transform.parent = weaponHandler;
                weapon.transform.localPosition = weaponPosition;
                weapon.transform.localRotation = Quaternion.Euler(weaponRotation);
                weapon.transform.localScale = weaponScale;
                weapon.GetComponent<Animation>().Stop();

                break;
            }
        }
        
        if (Input.GetKeyDown(dropWeaponLetter))
        {
            DropWeapon();
        }
    }

    public void DropWeapon()
    {
        if (weaponHandler.childCount == 1)
        {
            weaponHandler.GetChild(0).GetComponent<WeaponCharacteristics>().isHandled = false;
            _lastDroppedWeapons.Add(weaponHandler.GetChild(0).gameObject);
            weaponHandler.GetChild(0).GetComponent<Animation>().Play();
            weaponHandler.DetachChildren();
        }
    }
}
