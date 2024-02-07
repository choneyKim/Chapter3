using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime.Misc;
using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    public ItemData[] playerInventory;
    public ItemSlotUI[] uiSlots;
    public bool[] isEquip;
    public static PlayerInventory Instance;  //플레이어 인벤토리 싱글톤

    private void Awake()
    {
        if(Instance == null)
        Instance = this;
    }

    void Start()
    {
        playerInventory = new ItemData[uiSlots.Length];
        isEquip = new bool[uiSlots.Length];

        for (int i = 0; i < uiSlots.Length; i++)
        {
            playerInventory[i] = ScriptableObject.CreateInstance<ItemData>();
            uiSlots[i].index = i;
            uiSlots[i].Clear();
        }
    }

    private void FixedUpdate()
    {
        UpdateUI();
    }


    public void UpdateUI()
    {
        for (int i = 0; i < uiSlots.Length; i++)
        {
            if (playerInventory[i] != null)
            {
                uiSlots[i].Set(playerInventory[i]);
                uiSlots[i].isEquip = isEquip[i];
            }
            else
                uiSlots[i].Clear();
        }
    }
}
