using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    [SerializeField] private ItemDataSO ItemData;

    public int itemAmount;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponent<Playee>() != null)
        {
            collision.gameObject.GetComponent<Inventory>().AddItem(ItemData, itemAmount);
            Destroy(this.gameObject);
        }
    }
}
