using Unity.VisualScripting;
using UnityEngine;

public class RaisingEnemyScript : MonoBehaviour
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
        timer = 6;
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
            yvel = 13f;
            timer = 6;
        }



        rb.linearVelocity = new Vector3(xvel, yvel, 0);
    }




}
