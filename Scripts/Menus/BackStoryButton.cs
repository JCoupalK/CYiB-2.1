using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackStoryButton : MonoBehaviour
{
    public GameObject BackStoryMenu;
    public GameObject VideoPlayer;
    public GameObject Menus;

    public void Start()
    {
        BackStoryMenu.SetActive(false);
        VideoPlayer.SetActive(false);
        Menus.SetActive(true);
    }

    
    public void BackStory()
    {
        BackStoryMenu.SetActive(true);
        VideoPlayer.SetActive(true);
        Menus.SetActive(false);
    }
}
