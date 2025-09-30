using UnityEngine;

public class MimicScript : MonoBehaviour
{
    Rigidbody2D rb;
    bool isGrounded;
    public bool isFacingRight;
    public LayerMask groundLayer;

    float xvel,yvel;

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
        yvel = rb.linearVelocity.y;

        //GroundCheck();


        
        /*
        if (isGrounded == true && isFacingRight == false)
        {
            xvel = -10;
        }

        else if (isGrounded == true && isFacingRight == true)
        {
            xvel = 10;
        }
        */

        if (xvel < 0)
        {
            if (ExtendedRayCollisionCheck(-2, 0) == false && xvel < 0)
            {
                Flip();
                xvel = -xvel;

            }
        }


        if (xvel > 0)
        {
            if (ExtendedRayCollisionCheck(2, 0) == false && xvel > 0)
            {
                Flip();
                xvel = -xvel;

            }
        }
        

        rb.linearVelocity = new Vector3(xvel, yvel, 0);
        
    }


   /* void GroundCheck()
    {

        Vector2 position = transform.position;
        Vector2 direction = Vector2.down;
        float distance = 2.5f;
        Debug.DrawRay(position, direction, Color.black);
        RaycastHit2D hit = Physics2D.Raycast(position, direction, distance, groundLayer);
        if (hit.collider != null)
        {
            isGrounded = true;
            Debug.DrawRay(position, direction*distance, Color.green);
        }

        else if (hit.collider == null)
        {
            isGrounded = false;
            Debug.DrawRay(position, direction, Color.darkRed);
        }


    }
   */
    private void Flip()
    {
        isFacingRight = !isFacingRight;
        Vector3 localscale = transform.localScale;
        localscale.x *= -1f;
        transform.localScale = localscale;
    }

    public bool ExtendedRayCollisionCheck(float xoffs, float yoffs)
    {
        float rayLength = 2.5f;
        bool hitSomething = false;

        Vector3 offset = new Vector3(xoffs, yoffs, 0);

        RaycastHit2D hit;

        hit = Physics2D.Raycast(transform.position + offset, -Vector2.up, rayLength, groundLayer);

        Color hitColor = Color.white;


        if (hit.collider != null)
        {
            hitColor = Color.green;
            hitSomething = true;
        }

        Debug.DrawRay(transform.position + offset, -Vector3.up * rayLength, hitColor);

        return hitSomething;
    }
}
