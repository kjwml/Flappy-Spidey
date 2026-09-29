using UnityEngine;

public class SpawnBuilding : MonoBehaviour
{
    public GameObject[] buildingPrefab;
    public float xRange = 1f;
    public float yRange = 1f;
    
    // Das gewünschte Basis-Intervall am Spielanfang
    public float baseSpawnInterval = 2f;
    public float startDelay = 3.5f;
    
    private float timer = 0f;
    private bool gameStarted = false;

    void Start()
    {
        // Start-Verzögerung einbauen
        Invoke("StartSpawning", startDelay);
    }

    void StartSpawning()
    {
        gameStarted = true;
        SpawnRandomBuilding();
    }

    void Update()
    {
        if (!gameStarted) return;

        timer += Time.deltaTime;

        // MAGIE HIER: Wir berechnen das Intervall dynamisch anhand der aktuellen Geschwindigkeit.
        // Formel: (Start-Geschwindigkeit / Aktuelle Geschwindigkeit) * Basis-Intervall
        // Wenn das Spiel schneller wird, schrumpft das Intervall im selben Verhältnis, 
        // sodass der physische Abstand zwischen den Gebäuden exakt gleich bleibt!
        float currentInterval = baseSpawnInterval * (5f / SpeedManager.globalSpeed);

        // Wenn die (angepasste) Zeit um ist -> Spawnen und Timer resetten
        if (timer >= currentInterval)
        {
            SpawnRandomBuilding();
            timer = 0f; 
        }
    }

    void SpawnRandomBuilding()
    {
        int randomIndex = Random.Range(0, buildingPrefab.Length);
        Instantiate(buildingPrefab[randomIndex], new Vector2(xRange, yRange), Quaternion.identity);
    }
}