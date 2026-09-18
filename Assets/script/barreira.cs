using UnityEngine;

public class barreira : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Colidiu com: " + collision.gameObject.tag);
        if (collision.gameObject.CompareTag("parede"))
        {
            Destroy(collision.gameObject);
        }
    }
}
