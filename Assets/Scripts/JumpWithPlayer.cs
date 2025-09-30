using Unity.VisualScripting;
using UnityEngine;

public class JumpWithPlayer : MonoBehaviour
{
    float xvel, yvel;
    Rigidbody2D rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {

        float xvel = rb.linearVelocity.x;
        float yvel = rb.linearVelocity.y;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            yvel = 13f;
        }

        rb.linearVelocity = new Vector3(xvel, yvel, 0);
    }

}
