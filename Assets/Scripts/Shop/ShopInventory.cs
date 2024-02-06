using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopInventory : MonoBehaviour
{
    public List<ItemData> data;
    public bool[] isBuy;
    public Dictionary<bool, List<ItemData>> shopInventory;


    void Start()
    {
        shopInventory = new Dictionary<bool, List<ItemData>>();
        for (int i = 0; i < data.Count; i++)
        {
            shopInventory.Add(isBuy[i], data);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
