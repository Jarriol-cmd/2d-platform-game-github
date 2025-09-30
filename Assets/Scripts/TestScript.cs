using JetBrains.Annotations;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEditor.Tilemaps;
using UnityEngine;

public class TestScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    Rigidbody2D rb;



    void Start()
    {

        rb = GetComponent<Rigidbody2D>();


    }

    // Update is called once per frame
    void Update()
    {

        float xvel = rb.linearVelocity.x;
        float yvel = rb.linearVelocity.y;


        if (yvel >=0)
        {
            yvel = -10f;
        }

        else if(yvel <=0)
        {
            yvel = 10;
        }

        rb.linearVelocity = new Vector3(xvel, yvel, 0);

    }
}
