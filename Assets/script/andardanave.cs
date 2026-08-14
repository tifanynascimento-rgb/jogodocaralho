using UnityEngine;
using UnityEngine.InputSystem;

public class andardanave : MonoBehaviour
{
    Rigidbody2D rb;
    public float thrustForce = 10f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
     if (Mouse.current.leftButton.isPressed)
        {
            Vector3 MousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.value);
           Debug.Log("Mouse Position: " + MousePos);

            Vector2 direction = MousePos - transform.position;
            transform.up = direction;
            rb.AddForce(direction * thrustForce);
        }
    }

}
