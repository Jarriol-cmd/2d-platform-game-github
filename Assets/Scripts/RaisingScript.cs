using Unity.VisualScripting;
using UnityEngine;

public class RaisingScript : MonoBehaviour
{
    float xvel, yvel;
    Rigidbody2D rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        xvel = 5;
        yvel = 0;
    }

    // Update is called once per frame
    void Update()
    {

    }


    private void OnCollisionEnter2D(Collision2D collision)
    {

        
        float yvel = rb.linearVelocity.y;
        
        if (collision.gameObject)
        {
            yvel =19f;
        }



        rb.linearVelocity = new Vector3(xvel, yvel, 0);
    }




}
