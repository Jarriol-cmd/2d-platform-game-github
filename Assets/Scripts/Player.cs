using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float xPos = transform.position.x;
        float yPos = transform.position.y;



        if (Input.GetKey("w") == true)
        {
            yPos += 0.1f;
        }

        if (Input.GetKey("s") == true)
        {
            yPos -= 0.1f;
        }

        if (Input.GetKey("d") == true)
        {
            xPos += 0.1f;
        }

        if (Input.GetKey("a") == true)
        {
            xPos -= 0.1f;
        }

        //if (xPos >= 1.5 || yPos >= 1.5)
        //{
            //xPos = 0;
           //yPos = 0;
        //}

        //if (xPos <= -1.5 || yPos <= -1.5)
        //{
            //xPos = 0;
            //yPos = 0;
        //}

        transform.position = new Vector3(xPos, yPos, 0);

    }
}
