using Unity.VisualScripting;
using UnityEngine;

public class RaisingEnemy3 : MonoBehaviour
{
    float xvel, yvel;
    Rigidbody2D rb;
    float timer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        xvel = 0;
        yvel = 1;
        timer = 4;
    }

    // Update is called once per frame
    void Update()
    {
        DoJump();
    }


    private void DoJump()
    {
        timer -= Time.deltaTime;
        
        float yvel = rb.linearVelocity.y;
        
        if (timer < 0)
        {
            yvel = 11f;
            timer = 4;
        }



        rb.linearVelocity = new Vector3(xvel, yvel, 0);
    }




}
