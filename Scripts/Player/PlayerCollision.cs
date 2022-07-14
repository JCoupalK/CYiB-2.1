using UnityEngine;
using UnityEngine.UI;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;
    void OnCollisionEnter (UnityEngine.Collision collisionInfo)
    {
        
        if (collisionInfo.gameObject.tag == "Obstacle")
        {           
            GetComponent<PlayerMovement>().enabled = false;
            FindObjectOfType<GameManager>().EndGame();
            
        }
    }
}
