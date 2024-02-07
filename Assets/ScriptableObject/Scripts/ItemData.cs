using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ItemType
{
    Weapon,
    Neck,
    Ring,
    Gloves,
    Shoes
}


[CreateAssetMenu(fileName = "Item", menuName = "New Item")]
public class ItemData : ScriptableObject
{
    [Header("Info")]
    public string displayName;
    public string description;
    public ItemType type;
    public Sprite icon;
    public int itemPoint;
    public int itemPrice;
    public Sprite typeIcon_Equip;
    public Sprite typeIcon_Shop;

}