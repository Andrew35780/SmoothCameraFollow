using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;
    [SerializeField] private float speed = 16f;

    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.D))
            rb.AddForce(-speed / 2 * Time.deltaTime, 0, 0, ForceMode.VelocityChange);

        if (Input.GetKey(KeyCode.A))
            rb.AddForce(speed / 2 * Time.deltaTime, 0, 0, ForceMode.VelocityChange);

        if (Input.GetKey(KeyCode.W))
            rb.AddForce(0, speed * Time.deltaTime, 0, ForceMode.VelocityChange);

        if (Input.GetKey(KeyCode.S))
            rb.AddForce(0, -speed * Time.deltaTime, 0, ForceMode.VelocityChange);
    }
}
