using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{

    public float movespeed = 5.0f;
    Rigidbody2D rb;
    bool isVertical;
    bool flipH;
    bool flipV;
    string lastDirection = "None";
    public Animator anim;
    

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        if (BetweenScenesManager.Instance.EnterSceneMatters)
        {
            GenerateStartPosition();
        }
        
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
        if (lastDirection == "Down")
        {
            if (currentDirection == "Left" || currentDirection == "Right")
            {
                isVertical = true;
                flipV = false;
                flipH = false;
            }
            else if (currentDirection == "Up")
            {
                isVertical = true;
                flipV = true;
                flipH = true;
            }
            else if (currentDirection == "Down" || currentDirection == "None")
            {
                isVertical = true;
                flipV = false;
                flipH = false;
            }
            else
            {
                isVertical = true;
                flipV = false;
                flipH = false;
            }
            if (currentDirection != "None")
            {
                lastDirection = "Down";
            }
            else
            {
                lastDirection = "None";
            }
        }
        else if (lastDirection == "Up")
        {
            if (currentDirection == "Left" || currentDirection == "Right")
            {
                isVertical = true;
                flipV = false;
                flipH = false;
            }
            else if (currentDirection == "Up" || currentDirection == "None")
            {
                isVertical = true;
                flipV = true;
                flipH = true;
            }
            else if (currentDirection == "Down")
            {
                isVertical = true;
                flipV = false;
                flipH = false;
            }
            if (currentDirection != "None")
            {
                lastDirection = "Up";
            }
            else
            {
                lastDirection = "None";
            }
        } else if (lastDirection == "Left")
        {
            if (currentDirection == "Down" || currentDirection == "Up")
            {
                isVertical = false;
                flipV = false;
                flipH = true;
            } else if (currentDirection == "Left" || currentDirection == "None")
            {
                isVertical = false;
                flipV = false;
                flipH = true;
            } else if (currentDirection == "Right")
            {
                isVertical = false;
                flipV = false;
                flipH = false;
            }
            if (currentDirection != "None")
            {
                lastDirection = "Left";
            }
            else
            {
                lastDirection = "None";
            }

        } else if (lastDirection == "Right")
        {
            if (currentDirection == "Down" || currentDirection == "Down")
            {
                isVertical = false;
                flipH = false;
                flipV = false;
            } else if (currentDirection == "Left")
            {
                isVertical = false;
                flipV = false;
                flipH = true;
            } else if (currentDirection == "Right" || currentDirection == "None")
            {
                isVertical = false;
                flipV = false;
                flipH = false;
            }
            if (currentDirection != "None")
            {
                lastDirection = "Right";
            }
            else
            {
                lastDirection = "None";
            }
        }
        else
        {
            if (currentDirection == "Down")
            {
                isVertical = true;
                flipV = false;
                flipH = false;
            }else if(currentDirection == "Up")
            {
                isVertical = true;
                flipV = true;
                flipH = true;
            }else if(currentDirection == "Left")
            {
                isVertical = false;
                flipV = false;
                flipH = true;
            }else if(currentDirection == "Right")
            {
                isVertical = false;
                flipV = false;
                flipH = false;
            }
        }

        //Update Animations
        anim.SetBool("isVertical", isVertical);
        GetComponent<SpriteRenderer>().flipX = flipH;
        GetComponent<SpriteRenderer>().flipY = flipV;
        

    }

    void GenerateStartPosition()
    {

    }
}
