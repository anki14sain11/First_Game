using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Player_motor : MonoBehaviour
{
    private Vector3 vel = Vector3.zero;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        
    }
    public void Move(Vector3 velocity)
    {
        vel = velocity;
    }
    void FixedUpdate()
    {
        PerformMovement();
    }
    void PerformMovement()
    {
        if (vel != Vector3.zero)
        {
            rb.MovePosition(rb.position + vel*Time.fixedDeltaTime);
        }
    }
}
