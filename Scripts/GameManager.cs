using System.Diagnostics.Contracts;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public bool gameHasEnded = false;
    public float restartDelay = 3f;

    

    private void Start()
    {
        GetComponent<AudioSource>().enabled = false;
    }

    


    public void Restart()
    {
     
        SceneManager.LoadScene("Level01");
    }


    public void EndGame()
    {
            if (gameHasEnded == false)
            {
                GetComponent<AudioSource>().enabled = true;

                gameHasEnded = true;

                Debug.Log("GAME OVER");
                Invoke("Restart", restartDelay);


            }

        
    }

 
}
