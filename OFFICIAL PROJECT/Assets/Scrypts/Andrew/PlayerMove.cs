using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{

    public float movespeed = 5.0f;
    Rigidbody2D rb;
    bool isVertical;
    bool flipX;
    bool flipY;
    string lastDirection = "None";
    

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        pMove();
    }

    void pMove()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");
        rb.velocity = new Vector2(x * movespeed, y * movespeed);
        UpdateAnimations(rb.velocity);
        
    }

    void UpdateAnimations(Vector2 velocity)
    {
        string currentDirection = "None";
        //Set Current Direction
        if(velocity[0] > 0 && (velocity[1] > -0.1 && velocity[1] < 0.1))
        {
            currentDirection = "Right";
        }else if(velocity[0] < 0 && (velocity[1] > -0.1 && velocity[1] < 0.1))
        {
            currentDirection = "Left";
        }else if(velocity[1] > 0 && (velocity[0] > -0.1 && velocity[0] < 0.1))
        {
            currentDirection = "Up";
        }else if(velocity[1] < 0 && (velocity[0] > -0.1 && velocity[0] < 0.1))
        {
            currentDirection = "Down";
        }


        //Now, Logic Depending Upon Last Movement
        if(lastDirection == "Down")
        {
            if(currentDirection == "Left" || currentDirection == "Right")
            {

            }
        }

    }
}
