using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerEquip : MonoBehaviour
{
    private int itemAttackPoint;
    private int itemDefPoint;
    private int itemHealthPoint;
    private int itemCriticalPoint;

    private ItemData selectItem;
    private ItemData curWeapon; //傍
    private ItemData curGloves; //农府
    private ItemData curShoes; //规
    private ItemData curRing; //积
    private ItemData curNeck; //傍

    private int totalAttackPoint;
    private int totalDefPoint;
    private int totalHealthPoint;
    private int totalCriticalPoint;




    public void UpdateStatus()
    {
        CalStatus();
        Player.instance._playerName.text = Player.instance.playerName;
        Player.instance._playerLevel.text = Player.instance.level.ToString();
        Player.instance._playerAttack.text = itemAttackPoint == 0 ? $"{totalAttackPoint}" : $"{totalAttackPoint} ({itemAttackPoint})";
        Player.instance._playerDef.text = itemDefPoint == 0 ? $"{totalDefPoint}" : $"{totalDefPoint} ({itemDefPoint})";
        Player.instance._playerHealth.text = itemHealthPoint == 0 ? $"{totalHealthPoint}" : $"{totalHealthPoint} ({itemHealthPoint})";
        Player.instance._playerCritical.text = itemCriticalPoint == 0 ? $"{totalCriticalPoint}" : $"{totalCriticalPoint} ({itemCriticalPoint})";
        Player.instance._playerGold.text = Player.instance.gold.ToString("#,##0");
        Player.instance._playerExp.text = $"{Player.instance.curExp}/{Player.instance.maxExp}";
        Player.instance._playerExpSlider.value = Player.instance.curExp / Player.instance.maxExp;
    }

    public void CalStatus()
    {
        if (curWeapon == null && curNeck == null) itemAttackPoint = 0;
        if (curWeapon == null && curNeck != null) itemAttackPoint = curNeck.itemPoint;
        if (curWeapon != null && curNeck == null) itemAttackPoint = curWeapon.itemPoint;
        if (curWeapon != null && curNeck != null) itemAttackPoint = curNeck.itemPoint + curWeapon.itemPoint;
        if (curGloves != null) itemCriticalPoint = curGloves.itemPoint;
        else itemCriticalPoint = 0;
        if (curShoes != null) itemDefPoint = curShoes.itemPoint;
        else itemDefPoint = 0;
        if (curRing != null) itemHealthPoint = curRing.itemPoint;
        else itemHealthPoint = 0;

        totalAttackPoint = Player.instance.attackPoint + itemAttackPoint;
        totalDefPoint = Player.instance.defPoint + itemDefPoint;
        totalHealthPoint = Player.instance.healthPoint + itemHealthPoint;
        totalCriticalPoint = Player.instance.criticalPoint + itemCriticalPoint;

    }
    public void EquipItem(int index)
    {
        selectItem = PlayerInventory.Instance.playerInventory[index];
        switch (selectItem.type)
        {
            case ItemType.Weapon:
                if (curWeapon == selectItem)
                {
                    curWeapon = null;
                    PlayerInventory.Instance.isEquip[index] = false;
                }
                else
                {
                    if(curWeapon != null)
                    {
                        for(int i = 0; i < PlayerInventory.Instance.playerInventory.Length; i++)
                        {
                            if (PlayerInventory.Instance.playerInventory[i] == curWeapon)
                                PlayerInventory.Instance.isEquip[i] = false;
                        }
                    }
                    curWeapon = selectItem;
                    PlayerInventory.Instance.isEquip[index] = true;
                }

                break;
            case ItemType.Gloves:
                if (curGloves == selectItem)
                {
                    curGloves = null;
                    PlayerInventory.Instance.isEquip[index] = false;
                }
                else
                {
                    if (curGloves != null)
                    {
                        for (int i = 0; i < PlayerInventory.Instance.playerInventory.Length; i++)
                        {
                            if (PlayerInventory.Instance.playerInventory[i] == curGloves)
                                PlayerInventory.Instance.isEquip[i] = false;
                        }
                    }
                    curGloves = selectItem;
                    PlayerInventory.Instance.isEquip[index] = true;
                }
                break;
            case ItemType.Shoes:
                if (curShoes == selectItem)
                {
                    curShoes = null;
                    PlayerInventory.Instance.isEquip[index] = false;
                }
                else
                {
                    if (curShoes != null)
                    {
                        for (int i = 0; i < PlayerInventory.Instance.playerInventory.Length; i++)
                        {
                            if (PlayerInventory.Instance.playerInventory[i] == curShoes)
                                PlayerInventory.Instance.isEquip[i] = false;
                        }
                    }
                    curShoes = selectItem;
                    PlayerInventory.Instance.isEquip[index] = true;
                }
                break;
            case ItemType.Ring:
                if (curRing == selectItem)
                {
                    curRing = null;
                    PlayerInventory.Instance.isEquip[index] = false;
                }
                else
                {
                    if (curRing != null)
                    {
                        for (int i = 0; i < PlayerInventory.Instance.playerInventory.Length; i++)
                        {
                            if (PlayerInventory.Instance.playerInventory[i] == curRing)
                                PlayerInventory.Instance.isEquip[i] = false;
                        }
                    }
                    curRing = selectItem;
                    PlayerInventory.Instance.isEquip[index] = true;
                }
                break;
            case ItemType.Neck:
                if (curNeck == selectItem)
                {
                    curNeck = null;
                    PlayerInventory.Instance.isEquip[index] = false;
                }
                else
                {
                    if (curNeck != null)
                    {
                        for (int i = 0; i < PlayerInventory.Instance.playerInventory.Length; i++)
                        {
                            if (PlayerInventory.Instance.playerInventory[i] == curNeck)
                                PlayerInventory.Instance.isEquip[i] = false;
                        }
                    }
                    curNeck = selectItem;
                    PlayerInventory.Instance.isEquip[index] = true;
                }
                break;

        }
    }

}
