using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime.Misc;
using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    public ItemData[] playerInventory;
    public ItemSlotUI[] uiSlots;
    public int playerBag;
    public static PlayerInventory Instance;  //플레이어 인벤토리 싱글톤

    private void Awake()
    {
        if(Instance == null)
        Instance = this;
    }

    void Start()
    {        
        playerBag = 25;
        playerInventory = new ItemData[playerBag];
        for (int i = 0; i < playerBag; i++)
        {
            playerInventory[i] = new ItemData();
            uiSlots[i].index = i;
            uiSlots[i].Clear();
        }
    }

    // Update is called once per frame
    void Update()
    {
    }


    public void UpdateUI()
    {
        for (int i = 0; i < playerBag; i++)
        {
            if (playerInventory[i] != null)
                uiSlots[i].Set(playerInventory[i]);
            else
                uiSlots[i].Clear();
        }
    }
}
