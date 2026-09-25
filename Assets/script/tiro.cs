using UnityEngine;

public class tiro : MonoBehaviour
{
    public int pontosParaDar;

    [SerializeField] private float speed = 8;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        var rb = GetComponent<Rigidbody2D>();
        rb.AddForce(-transform.right * speed, ForceMode2D.Impulse);
        transform.Rotate(0, 0, 90);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("tiro"))
        {
            GameManager.instance.AumentarPontuacao(pontosParaDar);
            Destroy(collision.gameObject);
            Destroy(gameObject);

        }
    }

}
