using UnityEngine;

public class SpeedManager : MonoBehaviour
{
    public static float globalSpeed = 5f;
    public float speedIncrease = 0.2f;

    public static void ResetState()
    {
        globalSpeed = 5f;
    }

    void Update()
    {
        globalSpeed += speedIncrease * Time.deltaTime;
    }
}