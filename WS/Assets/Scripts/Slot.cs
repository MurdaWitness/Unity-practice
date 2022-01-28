using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Slot : MonoBehaviour, IPointerDownHandler, IPointerEnterHandler, IPointerExitHandler
{
    [SerializeField] private Text nameUI;
    [SerializeField] private Text amountUI;
    public ItemDataSO itemUP;
    public Inventory pInventory;
    public GameObject Panel;
    private void Start()
    {
        pInventory = transform.parent.GetComponent<InventoryUI>().playerInventory;
    }

    public void UpdateSlot(ItemDataSO item, int amount)
    {
        itemUP = item;
        nameUI.text = item.itemName;
        amountUI.text = amount.ToString();
    }
    
    public void ClearSlot()
    {
        nameUI.text = "Empty";
        amountUI.text = "0";
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        Panel.SetActive(true);
        Panel.GetComponent<Panelka>().amount = int.Parse(amountUI.text);
    }
    public void OnPointerEnter(PointerEventData eventData)
    {
        GetComponent<Image>().color = Color.yellow;
    }
    public void OnPointerExit(PointerEventData eventData)
    {
        GetComponent<Image>().color = Color.white;
    }
}
