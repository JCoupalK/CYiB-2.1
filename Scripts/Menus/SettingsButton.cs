using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingsButton : MonoBehaviour
{
    public GameObject SettingMenu;
	public GameObject Menus;

	public void Start()
	{
		Cursor.visible = true;
		Menus.SetActive(true);
		SettingMenu.SetActive(false);
	}

	public void SettingsMenuOpen()
	{
		Menus.SetActive(false);
		SettingMenu.SetActive(true);
	}


}
   


