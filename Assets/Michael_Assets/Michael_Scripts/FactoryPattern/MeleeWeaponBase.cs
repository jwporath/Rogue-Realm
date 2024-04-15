using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// MeleeWeaponBase.cs
public abstract class MeleeWeaponBase : MonoBehaviour, IMeleeWeapon
{
    public abstract void Attack();
    // Add more common functionality as needed
}

