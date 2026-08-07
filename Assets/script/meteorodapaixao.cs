using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        float randomSize = Random.Range(1f, 3f);
        transform.localScale = new Vector3(randomSize, randomSize, 1); 
    }

    // Update is called once per frame
    void Update()
    {
        Random.Range(0, 1);
        
    }
}
