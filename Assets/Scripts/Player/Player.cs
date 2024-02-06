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
    private string playerName;
    private classType playerClass;
    private int attackPoint;
    private int defPoint;
    private int healthPoint;
    private int criticalPoint;
    private int level;
    private float maxExp;
    private float curExp;
    private int gold;

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

    private void Awake()
    {
        InitailizePlayer();
    }

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void InitailizePlayer()
    {
        playerName = "�Ƹ���";
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
                _playerClass.text = "�ڵ��뿹";
                _playerDescription.text = "�ڵ��� �뿹�Դϴ�. ���õ� ��ٽð� �Ѿ �Ӹ��� ����� �ֽ��ϴ�.";
                break;
            case classType.Doby:
                _playerClass.text = "����";
                _playerDescription.text = "����� �����Դϴ�. ���Ϲ� �������� ���� ���� �� �ֽ��ϴ�.";
                break;
            case classType.Goat:
                _playerClass.text = "��Ʈ";
                _playerDescription.text = "�ڵ��� ���� �Ǿ����ϴ�. ������ ���� ���� ������ ����� ���մϴ�.";
                break;
        }
    }
}
