using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Weapon", menuName = "Item/Weapon")]
public class WeaponSO : ItemDataSO
{
    public enum WeaponType
    {
        sword,
        bow,
        shield
    }
    public WeaponType weaponType;
}
