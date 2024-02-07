using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ItemSlotUI : MonoBehaviour
{
    public TextMeshProUGUI _itemName;
    public TextMeshProUGUI _itemDescription;
    public TextMeshProUGUI _itemPoint;
    public TextMeshProUGUI _itemPrice;
    public Image _itemIcon;
    public Image _shopIcon;
    private ItemData curSlot;

    public int index;
    public bool soldOut;
    

    public void Set(ItemData slot)
    {
        curSlot = slot;
        _itemIcon.gameObject.SetActive(true);
        _itemIcon.sprite = slot.icon;
        _shopIcon.sprite = slot.typeIcon_Shop;
        _itemName.text = slot.name;
        _itemDescription.text = slot.description;
        if(slot.type == ItemType.Weapon|| slot.type == ItemType.Neck|| slot.type == ItemType.Gloves)
        {
            _itemPoint.text = slot.itemPoint.ToString();
        }
        else if(slot.type == ItemType.Ring)
        {
            _itemPoint.color = Color.green;
            _itemPoint.text = slot.itemPoint.ToString();
        }
        else
        {
            _itemPoint.color = Color.blue;
            _itemPoint.text = slot.itemPoint.ToString();
        }
        _itemPrice.text = slot.itemPrice.ToString();

    }

    public void Clear()
    {
        curSlot = null;
        _itemIcon.gameObject.SetActive(false);
    }
}
