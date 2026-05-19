
using UnityEngine;

public class Teleport : MonoBehaviour
{

    float timer = 0f;

    void Start()
    {

    }

    void Update()
    {
        // Count up time
        timer += Time.deltaTime;

        // When timer reaches 3 seconds
        if (timer >= 3f)
        {
            // Move to a random position
            transform.position = new Vector3(
                Random.Range(-5f, 5f),
                Random.Range(-5f, 5f),
                0f
            );

            // Restart timer
            timer = 0f;
        }
    }
}
