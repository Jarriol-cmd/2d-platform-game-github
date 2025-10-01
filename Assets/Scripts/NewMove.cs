using JetBrains.Annotations;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEditor.Tilemaps;
using UnityEngine;

public class NewMove : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    Rigidbody2D rb;
    //public bool isFacingRight;
    bool isGrounded;
    public int lives;
    public Animator anim;
    HelperScript helper;

    void Start()
    {
        lives = 5;
        rb = GetComponent<Rigidbody2D>();
        helper = gameObject.AddComponent<HelperScript>();
    }

    // Update is called once per frame
    void Update()
    {

        float xvel = rb.linearVelocity.x;
        float yvel = rb.linearVelocity.y;


        if (Input.GetKey("a"))
        {
            xvel = -10;
        }

        if (Input.GetKey("d"))
        {
            xvel = 10;
        }

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded == true)
        {
            yvel = 11;
        }

        if (Input.GetKey("s") && isGrounded == false)
        {
            yvel = 0;
        }


        if (xvel != 0)
        {
            anim.SetBool("Is Walking", true);
        }


        else
        {
            anim.SetBool("Is Walking", false);
        }

        if (yvel > 0f)
        {
            anim.SetBool("Is Jumping", true);
        }


        else
        {
            anim.SetBool("Is Jumping", false);
        }


        if (yvel < 0f)
        {
            anim.SetBool("Is Falling", true);
            anim.SetBool("Is Jumping", true);
        }


        else
        {
            anim.SetBool("Is Falling", false);

        }

        if (xvel > 0)
        {
            helper.DoFlipObject(true);    
        }

        if (xvel < 0)
        {
            helper.DoFlipObject(false);    
        }


        /*
        if (!isFacingRight && xvel > 0f)
        {
            Flip();
        }

        else if (isFacingRight && xvel < 0f)
        {
            Flip();
        }
        */


        rb.linearVelocity = new Vector3(xvel, yvel, 0);

        GroundCheck();

    }


    public LayerMask groundLayer;

    void GroundCheck()
    {

        Vector2 position = transform.position;
        Vector2 direction = Vector2.down;
        float distance = 1.0f;
        Debug.DrawRay(position, direction, Color.black);
        RaycastHit2D hit = Physics2D.Raycast(position, direction, distance, groundLayer);
        if (hit.collider != null)
        {
            isGrounded = true;
            Debug.DrawRay(position, direction, Color.green);
        }

        else if (hit.collider == null)
        {
            isGrounded = false;
            Debug.DrawRay(position, direction, Color.darkRed);
        }
    }




    
    /*
    private void Flip()
    {
        isFacingRight = !isFacingRight;
        Vector3 localscale = transform.localScale;
        localscale.x *= -1f;
        transform.localScale = localscale;
    }
    */
}
