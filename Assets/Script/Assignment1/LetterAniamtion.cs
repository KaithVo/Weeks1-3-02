
using UnityEngine;
using UnityEngine.InputSystem;


public class LetterAniamtion : MonoBehaviour
{
    private bool mouseIsOverMe = false;

    public Color col;
    public SpriteRenderer spriteRenderer; //for sprite chnge

    //scales value
    public Vector3 originalScale;
    public Vector3 IsExpanding = new Vector3(1.5f, 1.5f, 1.5f);

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        RandomColor();

        spriteRenderer = GetComponent<SpriteRenderer>();

        //save the original scale
        originalScale = transform.localScale;
    }

    // Update is called once per frame
    void Update()
    {
        //update animating
        Animating();
        //change color
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
        if (spriteRenderer.bounds.Contains(mousePos) == true)
        {
            //use the color variable
            spriteRenderer.color = col;
            mouseIsOverMe = true;

        }
        else
        {
            //set the color to white
            spriteRenderer.color = Color.white;
            mouseIsOverMe = false;
        }

    }

    void RandomColor()
    {
        col = Random.ColorHSV();
    }

    private float speed = 2f;
    //time
    private float t = 0;
    public AnimationCurve curve;

    //animation curve for size
    void Animating() //https://zh.esotericsoftware.com/forum/d/3825-unity-random-bone-explosion/2
    {
        //if mouse is over than the animation happens
        if (mouseIsOverMe)
        {
            //increase t 
            t += Time.deltaTime * speed;
        }
        else
        {
            //decrease t
            t -= Time.deltaTime * speed;

        }

        //clamp instead of resetting 
        t = Mathf.Clamp01(t);

        transform.localScale = Vector3.Lerp(originalScale, IsExpanding, curve.Evaluate(t));
    }
}
