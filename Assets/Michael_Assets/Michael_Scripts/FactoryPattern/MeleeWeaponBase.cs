using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// MeleeWeaponBase.cs
public abstract class MeleeWeaponBase : MonoBehaviour, IMeleeWeapon
{
    public abstract void Attack();
    // {
    //     Debug.Log("MeleeWeapon attack!!");
    // }
    // //public float weaponDamage;
    // Add more common functionality as needed
}

