using UnityEngine;

public class PlayerMotion : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardforce = 4000f;
    public float sidewaysforce = 100f;
    // Start is called before the first frame update

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0,0,forwardforce*Time.deltaTime);
        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewaysforce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-(sidewaysforce) * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
