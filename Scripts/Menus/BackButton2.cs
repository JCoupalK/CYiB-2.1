using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackButton2 : MonoBehaviour
{
   
    public GameObject SettingMenu;
    public GameObject PauseMenu;

    private void Update()
    {
        if (Input.GetKeyDown("escape"))
        {
            SettingMenu.SetActive(false);         
        }
    }
    public void Back2()
    {
        SettingMenu.SetActive(false);
       
        PauseMenu.SetActive(true);
    }
}