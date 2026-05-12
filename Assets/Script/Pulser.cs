using UnityEngine;

public class Pulser : MonoBehaviour
{
    public AnimationCurve curve;
    public float startSize;
    public float endSize;

    public float duration;
    float progress = 0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        progress += Time.deltaTime;
        transform.localScale = curve.Evaluate(progress/duration) * Vector3.one; //".one" is to make the scale uniform in all directions, it means by (x,y,z) -> (1,1,1)

        if ( progress > duration)
        {
            progress = 0f;
        }
    }
}
