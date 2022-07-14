using UnityEngine;

public class QuitButton : MonoBehaviour
{
    public void Quit()
    {
        Debug.Log("QUIT");
        Application.Quit();
    }


}
