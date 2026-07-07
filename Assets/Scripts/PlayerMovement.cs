using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody rb;
    public float forwardForce = 2000f;
    public float horizontalForce = 500f;

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if (Keyboard.current.dKey.isPressed)
        {
            rb.AddForce(horizontalForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Keyboard.current.aKey.isPressed)
        {
            rb.AddForce(-horizontalForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if(rb.position.y < -1)
        {
            FindAnyObjectByType<GameManager>().EndGame();
        }
    }
}
