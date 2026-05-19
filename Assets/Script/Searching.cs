using UnityEngine;

public class Searching : MonoBehaviour
{

    public Vector2 starting;
    public Vector2 ending;
    public float speed = 1f;//speed
    public float t; //time for Lerp


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        starting = transform.position;
        ending = new Vector2(Random.Range(-5f, 5f), Random.Range(-5f, 5f));
    }

    // Update is called once per frame
    void Update()
    {
        t += Time.deltaTime * speed; //increasing t over time

        transform.position = Vector2.Lerp(starting, ending,t);
    }
}
