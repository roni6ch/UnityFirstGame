
using UnityEngine;

public class followPlayer : MonoBehaviour
{
    public Transform player;
    public Vector3 offset;
    void Start()
    {
        
    }

    void FixedUpdate()
    {
        transform.position = player.position + offset;
    }

}
