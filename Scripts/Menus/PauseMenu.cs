using UnityEngine;
using UnityEngine.SceneManagement;
public class PauseMenu : MonoBehaviour
{
  
    public static bool GameIsPaused = false;
    public GameObject pauseMenuUI;
    public GameObject SettingMenuUI;

    void Start()
    {
        pauseMenuUI.SetActive(false);
        SettingMenuUI.SetActive(false);
        Cursor.visible = false;
    }
    private void Update()
    {
        if (Time.timeScale == 0f)
		{
            Cursor.visible = true;
        }
		else
		{
            Cursor.visible = false;
        }

        if (Input.GetKeyDown("escape"))
        {
            if (GameIsPaused)
            {              
                Resume();
            }

            else
            {
                Pause();   
            }
        }
    }

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    public void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0;
        GameIsPaused = true;
        
    }
    
    public void SettingLeButton()
	{
        SettingMenuUI.SetActive(true);
        pauseMenuUI.SetActive(false);
	}

    public void LoadMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Menu");
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quitting game...");
    }





}