using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryUI : MonoBehaviour
{
    [SerializeField] private List<Slot> slots;
    [SerializeField] public Inventory playerInventory;

    public void UpdateUI()
    {
        foreach (var item in slots)
        {
            item.ClearSlot();
        }
        int i = 0;
        foreach (var item in playerInventory.items)
        {
            slots[i].UpdateSlot(item.Key, item.Value);
            i++;
        }
    }
}
