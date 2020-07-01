using UnityEngine;

[RequireComponent(typeof(Player_motor))]
public class Player_Controller : MonoBehaviour
{
    [SerializeField]
    private float speed = 5f;
    private Player_motor motor;
    void Start()
    {
        motor = GetComponent<Player_motor>();
    }
    void update()
    {
        float xMov = Input.GetAxisRaw("Horizontal"); 
        float zMov = Input.GetAxisRaw("Vertical");
        Vector3 movHorizontal = transform.right*xMov;
        Vector3 movVertical = transform.forward*zMov;

        Vector3 velocity = (movHorizontal + movVertical).normalized*speed;
        motor.Move(velocity);
        
    }
}
