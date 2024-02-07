using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public enum classType
{
    CodingSlave,
    Doby,
    Goat
}

public class Player : MonoBehaviour
{
    public string playerName;
    public classType playerClass;
    public int attackPoint;
    public int defPoint;
    public int healthPoint;
    public int criticalPoint;
    public int level;
    public float maxExp;
    public float curExp;
    public int gold;

    public TextMeshProUGUI _playerName;
    public TextMeshProUGUI _playerClass;
    public TextMeshProUGUI _playerLevel;
    public TextMeshProUGUI _playerDescription;
    public TextMeshProUGUI _playerAttack;
    public TextMeshProUGUI _playerDef;
    public TextMeshProUGUI _playerHealth;
    public TextMeshProUGUI _playerCritical;
    public TextMeshProUGUI _playerGold;
    public TextMeshProUGUI _playerExp;
    public Slider _playerExpSlider;

    public static Player instance; //플레이어 싱글톤 playerGold를 shop에서 사용
    public PlayerEquip playerEquip;

    protected virtual void Awake()
    {
        if (instance == null)
            instance = this;
        InitailizePlayer();
    }

    void Start()
    {
        playerEquip = GetComponent<PlayerEquip>();
    }
    private void FixedUpdate()
    {
        playerEquip.UpdateStatus();
    }

    private void InitailizePlayer()
    {
        playerName = "아몰랑";
        playerClass = classType.Doby;
        attackPoint = 10;
        defPoint = 25;
        healthPoint = 100;
        criticalPoint = 35;
        level = 10;
        maxExp = 16.0f;
        curExp = 8.0f;
        gold = 20000;

        _playerName.text = playerName;
        _playerLevel.text = level.ToString();
        _playerAttack.text = attackPoint.ToString();
        _playerDef.text = defPoint.ToString();
        _playerHealth.text = healthPoint.ToString();
        _playerCritical.text = criticalPoint.ToString();
        _playerGold.text = gold.ToString("#,##0");
        _playerExp.text = $"{curExp}/{maxExp}";
        _playerExpSlider.value = curExp / maxExp;



        switch (playerClass)
        {
            case classType.CodingSlave:
                _playerClass.text = "코딩노예";
                _playerDescription.text = "코딩의 노예입니다. 오늘도 퇴근시간 넘어서 머리를 쥐어뜯고 있습니다.";
                break;
            case classType.Doby:
                _playerClass.text = "도비";
                _playerDescription.text = "도비는 자유입니다. 매일밤 술집에서 도비를 만날 수 있습니다.";
                break;
            case classType.Goat:
                _playerClass.text = "고트";
                _playerDescription.text = "코딩의 신이 되었습니다. 하지만 일이 많아 여전히 퇴근은 못합니다.";
                break;
        }
    }

    public void EquipItemButton(int index)
    {
        playerEquip.EquipItem(index);
    }
}
