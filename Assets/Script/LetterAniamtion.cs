using UnityEngine;
using UnityEngine.InputSystem;

public class LetterAniamtion : MonoBehaviour
{
    private bool mouseIsOver = false;
    public Color col;
    public SpriteRenderer spriteRenderer; //for sprite change

<<<<<<< Updated upstream:Assets/Script/LetterAniamtion.cs
    public AnimationCurve animationCurve;
    public float startSize;
    public float endSize;

=======
    //scales value
    public Vector3 originalScale;
    public Vector3 IsExpanding = new Vector3(1.5f, 1.5f, 1.5f);
>>>>>>> Stashed changes:Assets/Script/Assignment1/LetterAniamtion.cs

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        //Detect mouse is over the object
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());

        //if mouse is in the bounds area, change color
        if (spriteRenderer.bounds.Contains(mousePos) == true)
        {
            //use the color variable
            spriteRenderer.color = Random.ColorHSV();
            mouseIsOver = true;


        }
        else
        {
            //set the color to white
            spriteRenderer.color = Color.white;
            mouseIsOver = false;
        }

    }
}
