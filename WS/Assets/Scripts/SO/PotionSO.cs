using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Potion", menuName = "Item/Potion")]
public class PotionSO : ItemDataSO
{
    public enum PotionType
    {
        HP,
        MP
    }
    public PotionType potionType;

    private void OnEnable()
    {
        this.stackSize = 10;
    }
}