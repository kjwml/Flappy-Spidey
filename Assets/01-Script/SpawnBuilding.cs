using UnityEngine;

public class SpawnBuilding : MonoBehaviour
{
    public GameObject [] buildingPrefab;
    public float xRange = 1f;
    public float yRange = 1f;
    public float spawnInterval = 2f;
    public float startDelay = 3.5f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("SpawnRandomBuilding", startDelay, spawnInterval);
    }
    

    // Update is called once per frame
    void  SpawnRandomBuilding()
    {
        int randomIndex = Random.Range(0, buildingPrefab.Length);
        Instantiate(buildingPrefab[randomIndex], new Vector2(xRange,yRange), Quaternion.identity);

       
    }
 }
    