using UnityEngine;

public class arma : MonoBehaviour
{
    [SerializeField] private tiro projectilPrefab;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectilPrefab, transform.position, transform.rotation);
        }
    }
}
