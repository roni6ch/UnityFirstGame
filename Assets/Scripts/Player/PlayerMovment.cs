
using UnityEngine;

public class PlayerMovment : MonoBehaviour
{
    public Rigidbody rb;

    public float forwardForce = 200f;
    public float sidewaysForce = 200f;
    void Start()
    {
        UnityEngine.Debug.Log("Start");
    }

    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);
        if (Input.GetKey("d")) {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0,ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (rb.position.y < -1f){
            FindObjectOfType<GameManager>().EndGame();
        }
    }
     private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Obsticle"))
        {
            this.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}

