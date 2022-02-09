using UnityEngine;

public class PlayerCollision : MonoBehaviour
{

    public PlayerMovement movement;
    
    void OnCollisionEnter (UnityEngine.Collision collisionInfo) 
    {
        //Debug.Log(collisionInfo.collider.name);
        if(collisionInfo.collider.tag == "Obstacle")
        {
            movement.enabled = false;
            //Debug.Log("Hit something!");
            FindObjectOfType<GameManager>().EndGame();

        }
    }
}
