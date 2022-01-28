using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//[CreateAssetMenu(fileName = "New Item", menuName = "Item")]
public class ItemDataSO : ScriptableObject
{
    public string itemName;
    public bool isStackable;
    public int stackSize;
    public ItemType itemType;
}

public enum ItemType
{
    equipment,
    food,
    potion,
    resource
}