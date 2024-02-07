using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UiController : MonoBehaviour
{
    public List<Image> menuIndex;
    public GameObject equipPanel;
    public TextMeshProUGUI _itemNameEquip;
    public TextMeshProUGUI _itemDescriptionEquip;
    public TextMeshProUGUI _itemPointEquip;
    public TextMeshProUGUI _itemTypeEquip;
    public Image _itemIconEquip;
    public Image _equipIconEquip;
    public static UiController instance;
    private ItemData data;
    private int equipIndex;

    private void Awake()
    {
        if (instance == null)
        instance = this;
    }
    void Start()
    {

    }


    void Update()
    {
        
    }
    public void OnClickMenu(int index)
    {
        menuIndex[0].gameObject.SetActive(false);
        menuIndex[index].gameObject.SetActive(true);
    }
    public void OnClickReturn(int index)
    {
        menuIndex[0].gameObject.SetActive(true);
        menuIndex[index].gameObject.SetActive(false);
    }
    public void OnClickCancel()
    {
        equipPanel.SetActive(false);
    }
    public void OnClickEquip()
    {
        Player.instance.EquipItemButton(equipIndex);
        equipPanel.SetActive(false);
    }
    public void OnClickSelectItem(int index)
    {
        equipIndex = index;
        data = PlayerInventory.Instance.playerInventory[index];
        equipPanel.SetActive(true);
        SetEquipPanel(data);
    }

    public void SetEquipPanel(ItemData data)
    {
        _itemIconEquip.sprite = data.icon;
        if (_equipIconEquip != null)
            _equipIconEquip.sprite = data.typeIcon_Equip;
        if (_itemNameEquip != null)
            _itemNameEquip.text = data.displayName;
        if (_itemDescriptionEquip != null)
            _itemDescriptionEquip.text = data.description;
        if (_itemPointEquip != null)
        {
            switch (data.type)
            {
                case ItemType.Ring:
                    _itemPointEquip.color = Color.green;
                    _itemPointEquip.text = data.itemPoint.ToString();
                    _itemTypeEquip.text = "생명력";
                    break;
                case ItemType.Shoes:
                    _itemPointEquip.color = Color.blue;
                    _itemPointEquip.text = data.itemPoint.ToString();
                    _itemTypeEquip.text = "방어력";
                    break;
                case ItemType.Gloves:
                    _itemPointEquip.text = data.itemPoint.ToString();
                    _itemTypeEquip.text = "치명타";
                    break;
                default:
                    _itemPointEquip.text = data.itemPoint.ToString();
                    _itemTypeEquip.text = "공격력";
                    break;

            }
        }
   
    }
}
