using Unity.VisualScripting;
using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    Rigidbody2D rb;
    float xv, yv;

    void Start()
    {

        rb = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        xv = 0;
        yv = rb.linearVelocity.y;

       float speed = 15;

        if (Input.GetKey("a"))
        {
            xv -= speed;
        }
        if (Input.GetKey("d"))
        {
            xv = speed;
        }


        rb.linearVelocity = new Vector3(xv, yv, 0);


    }
}
