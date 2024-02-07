using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{
    public static Shop instance; //상점은 한개만 구성하니까 싱글톤
    public List<ItemData> shopInventory;
    public ItemSlotUI[] uiSlots;
    public List<ItemData> selectedItem;

    public int index;
    public bool soldOut;

    protected virtual void Awake()
    {
        if (instance == null)
        instance = this;
    }

    public void BuyItem(int index)
    {
        if (Player.instance.gold >= shopInventory[index].itemPrice)
        {
            Player.instance.gold -= shopInventory[index].itemPrice;
            PlayerInventory.Instance.playerInventory.Add(shopInventory[index]);
            soldOut = true;
        }
        else Debug.Log("금액이 부족합니다.");
        
    }
}
