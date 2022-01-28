using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    [SerializeField] private string inventoryName;
    [SerializeField] private int inventorySize;

    [SerializeField] public Dictionary<ItemDataSO, int> items { get; set; }

    [SerializeField] private UnityEvent invetoryChanged;

//    public Dictionary<ItemDataSO, int> GetItems { get { return items; } }
    public Text txt;

    private void Start()
    {
        items = new Dictionary<ItemDataSO, int>();
        invetoryChanged.AddListener(Display);
    }


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            Display();
        }
    }

    public void AddItem(ItemDataSO item, int amount)
    {
        if (items.ContainsKey(item))
            items[item] += amount;
        else
            items.Add(item, amount);
        invetoryChanged.Invoke();
    }

    public void DropItemStack(ItemDataSO item)
    {
        items.Remove(item);
        invetoryChanged.Invoke();
    }

    void Display()
    {
        string str = "";
        foreach (var item in items)
        {
            str += item.Key.itemName + item.Value.ToString() + "\n";
        }
        txt.text = str;
    }
}
