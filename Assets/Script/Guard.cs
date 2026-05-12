using UnityEditor;
using UnityEngine;

public class Guard : MonoBehaviour

{
    public float speed;
    public Vector3 startValue;
    public Vector3 endValue;
    public Vector3 currentValue;
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
        //NUMBER
        //currentValue = Marth.Lerp(startValue, endValue, progress/duration);

        //POSION
        currentValue = Vector3.Lerp(startValue, endValue, progress/duration);

        transform.position = currentValue;

        //Debug.Log ("progress: " + progress + "duraion :" + duration);

        //Lerp making the value between start and end value, but it will never be more than end value,
        //so we need to reset the progress to 0 when it is more than duration,
        //so it will start again from the start value to end value.
        if (progress > duration)
        {
            //Debug.Log("progress is equal to duration");
            progress = 0f;
        }

    }
}
