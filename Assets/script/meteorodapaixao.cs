using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    Rigidbody2D rb;

    float minSpeed = 20f;

    float maxSpeed = 60f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        float randomSize = Random.Range(1f, 2f);
        transform.localScale = new Vector3(randomSize, randomSize, 1); 
        rb = GetComponent<Rigidbody2D>();
        float RandomSpeed = Random.Range(minSpeed, maxSpeed);
        Vector2 randomDirection = Random.insideUnitCircle;
        rb.AddForce(randomDirection * RandomSpeed);
    }

    // Update is called once per frame
    void Update()
    {
        Random.Range(0, 1);
       
       
    }

     void OnCollisionEnter2D(Collision2D collision)
     {
      Debug.Log("Colidiu com: " + collision.gameObject.tag);
      if (collision.gameObject.CompareTag("meteoro"))
      {
       Destroy(collision.gameObject);
      }
     }
}
