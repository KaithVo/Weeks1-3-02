using UnityEngine;
using UnityEngine.InputSystem;

public class BouncingBall : MonoBehaviour
{
    public float speed;
    //xMax
    //xMin
    public float xMax;
    public float xMin;
    public float yMax;
    public float yMin;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPositon = transform.position;
        newPositon.x += speed * Time.deltaTime;
        newPositon.y += speed * Time.deltaTime;
        transform.position = newPositon;

         if (newPositon.x > xMax || newPositon.x < xMin)
        {
            speed *= -1f;
      
        }
         if (newPositon.y > yMax || newPositon.y < yMin)
        {
            speed *= -1f;
      
        }


    }

}
