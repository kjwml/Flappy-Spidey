using UnityEngine;

public class SpawnCloud : MonoBehaviour
{
    public GameObject cloudPrefab;
    public float xRange = 1f;
    public float yRange = 1f;
    public float spawnInterval = 2f;
    public float startDelay = 3.5f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        InvokeRepeating("SpawnRandomCloud", startDelay, spawnInterval);
        
    }
    

    void Update()
    {

    }

    // Update is called once per frame
    void  SpawnRandomCloud()
    {
        Instantiate(cloudPrefab, new Vector2(xRange,yRange), Quaternion.identity);

       
    }
 }
    