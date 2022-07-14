using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackButton : MonoBehaviour
{
    public GameObject BackStoryMenu;
    public GameObject VideoPlayer;
    public GameObject Menus;
    public GameObject SettingMenu;

    public void Back()
    {
        SettingMenu.SetActive(false);
        BackStoryMenu.SetActive(false);
        VideoPlayer.SetActive(false);
        BackStoryMenu.SetActive(false);
        Menus.SetActive(true);
    }
}
