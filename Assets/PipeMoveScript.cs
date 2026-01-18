using UnityEngine;

public class PipeMoveScript : MonoBehaviour
{
    public float moveSpeed = 5;

    public float deadZone = -30;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + moveSpeed * Time.deltaTime * Vector3.left;
        if (transform.position.x < deadZone)
        {
            Destroy(gameObject);
        }
    }
}
