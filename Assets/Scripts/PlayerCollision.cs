
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMotion movement;
    // Start is called before the first frame update
    public void OnCollisionEnter(Collision collisioninfo)
    {
        if (collisioninfo.collider.tag == "obstacle")
        {
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
