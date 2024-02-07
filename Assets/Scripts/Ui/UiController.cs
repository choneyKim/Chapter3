using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UiController : MonoBehaviour
{
    public List<Image> menuIndex;
    
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
        PlayerInventory.Instance.UpdateUI();
    }
    public void OnClickReturn(int index)
    {
        menuIndex[0].gameObject.SetActive(true);
        menuIndex[index].gameObject.SetActive(false);
    }
}
