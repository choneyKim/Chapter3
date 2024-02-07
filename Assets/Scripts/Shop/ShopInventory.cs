using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ShopInventory : MonoBehaviour
{
    public List<ItemData> shopInventory;
    public bool[] isBuy;
    public TextMeshProUGUI _itemName;
    public TextMeshProUGUI _itemDescription;
    public TextMeshProUGUI _itemPoint;
    public TextMeshProUGUI _itemPrice;
    public Image _itemIcon;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
