using UnityEngine;

public class BuildingMovement : MonoBehaviour
{
    public float speed = 5f;

    public float leftBoundary = -10f;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {

        transform.Translate(Vector2.left * SpeedManager.globalSpeed * Time.deltaTime);

        if (transform.position.x < leftBoundary)
        {
            Destroy(gameObject);
        }
    }
}
