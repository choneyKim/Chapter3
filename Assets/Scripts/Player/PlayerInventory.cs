using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    public List<ItemData> playerInventory;
    public ItemSlotUI[] uiSlots;
    public int PlayerBag;
    public static PlayerInventory Instance;  //플레이어 인벤토리 싱글톤

    private void Awake()
    {
        if(Instance == null)
        Instance = this;
    }

    void Start()
    {
        PlayerBag = 25;
        for(int i = 0; i < PlayerBag; i++)
        {
            uiSlots[i].index = i;
            
            if (playerInventory[i] == null)
            {

            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
