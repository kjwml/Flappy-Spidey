
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class SpideyScript : MonoBehaviour
{
    public float strength = 5f;
    public Rigidbody2D rb;
    public TextMeshProUGUI scoreText;

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

        if (transform.position.y < -25f)
        {
            SpeedManager.ResetState();
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Building"))
        {
            SpeedManager.ResetState();
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

        else if (collision.gameObject.CompareTag("ScoreUp"))
        {
            // Increment the score by 1
            int currentScore = int.Parse(scoreText.text);
            currentScore++;
            scoreText.text = currentScore.ToString();
        }
    }

   
}
