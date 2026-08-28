using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.InputSystem;

public class andardanave : MonoBehaviour
{
    Rigidbody2D rb;
    public float thrustForce = 10f;
    public Animator animator;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }

    private void naosei()
    {
        if (Mouse.current.leftButton.isPressed && gameObject)
        {
            animator.SetBool("IsMoving", true);
        }
        else if (gameObject)
        {
            animator.SetBool("IsMoving", false);
        }
    }

    void Update()
    {
        if (Mouse.current.leftButton.isPressed)
        {
            Vector3 MousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.value);
            Vector2 direction = (MousePos - transform.position).normalized;
            transform.up = direction;
            rb.AddForce(direction * thrustForce);
            animator.SetBool("IsMoving", true);
        }
        
    }

}
