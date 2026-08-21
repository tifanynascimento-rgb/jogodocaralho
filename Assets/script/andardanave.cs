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
        if (Mouse.current.leftButton.isPressed)
        {
            animator.SetBool("isMoving", true);
        }
        else
        {
            animator.SetBool("isMoving", false);
        }
    }
 
    void Update()
    {
     if (Mouse.current.leftButton.isPressed)
        {
            Vector3 MousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.value);
            Vector2 direction = (MousePos - transform.position). normalized;
            transform.up = direction;
            rb.AddForce(direction * thrustForce);
        }
        naosei();
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Colidiu com: " + collision.gameObject.tag);
        if (collision.gameObject.CompareTag("meteoro"))
        {
            Destroy(gameObject);
        }
    }

}
