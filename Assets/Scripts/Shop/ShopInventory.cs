using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class ShopInventory : Shop
{
    public TextMeshProUGUI _playerGold;
    protected override void Awake()
    {
        base.Awake();
    }
    void Start()
    {
        for (int i = 0; i < shopInventory.Count; i++)
        {
            uiSlots[i].index = i;
            uiSlots[i].Set(shopInventory[i]);
        }
        _playerGold.text = Player.instance._playerGold.text;
    }

    void Update()
    {

    }
}
