using Unity.VisualScripting;
using UnityEngine;

public class RaisingEnemyScript : MonoBehaviour
{
    float xvel, yvel;
    Rigidbody2D rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        xvel = 0;
        yvel = 1;
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
            yvel =13f;
        }



        rb.linearVelocity = new Vector3(xvel, yvel, 0);
    }




}
