
using UnityEngine;
using UnityEngine.SceneManagement;

public class SpideyScript : MonoBehaviour
{
    public float strength = 5f;
    public Rigidbody2D rb;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.linearVelocity = Vector2.up * strength;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        SpeedManager.ResetState();
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
