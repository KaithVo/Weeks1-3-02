using UnityEngine;

public class flame : MonoBehaviour
{

    public Sprite flame01;
    public Sprite flame02;

    public float t;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        t += Time.deltaTime;

        //if over 0.5f in sprite 1, change sprite1 to sprite 2 back and forth
        if (t >= 0.5f)
        {
            //reset timer
            t = 0f;
            //check if current light is light 1
            if (sprite == flame01)
            {
              sprite = flame02;
            }
            else
            {
                sprite = flame01;
            }
        }
    }
}
