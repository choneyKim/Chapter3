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
    public GameObject buyButton;
    public GameObject soldOutButton;

    public int index;
    public bool soldOut;
    private void Start()
    {

    }

    public void Set(ItemData slot)
    {
        curSlot = slot;
        _itemIcon.gameObject.SetActive(true);
        _itemIcon.sprite = slot.icon;
        if(_shopIcon != null )
        _shopIcon.sprite = slot.typeIcon_Shop;
        if(_itemName != null )
        _itemName.text = slot.displayName;
        if(_itemDescription != null )
        _itemDescription.text = slot.description;
        if(_itemPoint != null)
        {
            switch(slot.type)
            {
                case ItemType.Ring:
                    _itemPoint.color = Color.green;
                    _itemPoint.text = slot.itemPoint.ToString();
                    break;
                case ItemType.Shoes:
                    _itemPoint.color = Color.blue;
                    _itemPoint.text = slot.itemPoint.ToString();
                    break;
                default:
                    _itemPoint.text = slot.itemPoint.ToString();
                    break;

            }
        }
        if(_itemPrice != null )
        _itemPrice.text = slot.itemPrice.ToString();
        if(buyButton != null || soldOutButton != null)
        {
            if (soldOut)
            {
                buyButton.gameObject.SetActive(false);
                soldOutButton.gameObject.SetActive(true);
            }
            else
            {
                buyButton.gameObject.SetActive(true);
                soldOutButton.gameObject.SetActive(false);
            }
        }

    }

    public void Clear()
    {
        curSlot = null;
        _itemIcon.gameObject.SetActive(false);
    }

    public void OnBuyButtonClick()
    {
        Shop.instance.BuyItem(index);
    }
    public void OnSelectButtonClick()
    {
        UiController.instance.OnClickSelectItem(index);
    }
}
