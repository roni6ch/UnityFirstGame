
using UnityEngine;

public class playerCollision : MonoBehaviour
{
    public PlayerMovment movment;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Obsticle"))
        {
            movment.enabled = false;
        }
    }
}

