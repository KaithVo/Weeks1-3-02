using System;
using UnityEngine;

public class LightFlick : MonoBehaviour
{
    //use the same method in the special letter but in color
    //spriteRender but for Alpha this time
    public SpriteRenderer SpriteRenderer;

    //range for min and max for Alpha
    public float minAlpha = 0.2f;
    public float maxAlpha = 0.7f;

    //animationCurve ofcours
    private float speed = 0.5f;
    public AnimationCurve flickeringCurve;
    private float flickerTime;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SpriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        flickerTime += Time.deltaTime * speed;

        //aplly alpha witout changing colpr
        
        currentColor.a = Mathf.Lerp(minAlpha, maxAlpha, flickeringCurve.Evaluate(flickerTime));
        Color currentColor = currentColor;

    }
}
