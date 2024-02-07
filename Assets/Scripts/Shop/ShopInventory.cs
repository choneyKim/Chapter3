using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class ShopSlot
{
    public ItemData _itemData;
    public bool _soldOut;
}

public class ShopInventory : MonoBehaviour
{
    public List<ItemData> shopInventory;
    public ItemSlotUI[] uiSlots;
    public ShopSlot[] slots;
    public TextMeshProUGUI _itemName;
    public TextMeshProUGUI _itemDescription;
    public TextMeshProUGUI _itemPoint;
    public TextMeshProUGUI _itemPrice;
    public Image _itemIcon;

    void Start()
    {
        for (int i = 0; i < shopInventory.Count; i++)
        {
            uiSlots[i].index = i;
            uiSlots[i].Set(shopInventory[i]);

        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
