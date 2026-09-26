using UnityEngine;

public class SpeedManager : MonoBehaviour
{
    // Eine globale Variable, auf die alle Gebäude zugreifen können
    public static float globalSpeed = 5f;
    public float speedIncrease = 0.2f;

    void Update()
    {
        // Lässt den globalen Speed-Wert mit der Zeit steigen
        globalSpeed += speedIncrease * Time.deltaTime;
    }
}