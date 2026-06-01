using UnityEngine;

public class flame : MonoBehaviour
{

    public Sprite flame01;
    public Sprite flame02;

    // calling spriteRender
    public SpriteRenderer spriteRenderer;

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
        if (t >= 0.5f) //https://docs.unity3d.com/6000.4/Documentation/ScriptReference/SpriteRenderer.html

        {
            //reset timer
            t = 0f;
            //check if current light is light 1
            if (spriteRenderer.sprite == flame01)
            {
                spriteRenderer.sprite = flame02;
            }
            else
            {
                spriteRenderer.sprite = flame01;
            }
        }
    }
}
