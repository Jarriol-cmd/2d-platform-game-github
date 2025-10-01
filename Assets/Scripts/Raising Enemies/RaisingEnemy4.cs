using Unity.VisualScripting;
using UnityEngine;

public class RaisingEnemy4 : MonoBehaviour
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
        timer = 3;
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
            yvel = 10f;
            timer = 3;
        }



        rb.linearVelocity = new Vector3(xvel, yvel, 0);
    }




}
