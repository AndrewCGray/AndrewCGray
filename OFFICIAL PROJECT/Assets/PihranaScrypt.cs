using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PihranaScrypt : MonoBehaviour
{

    public float speed;
    bool dead;
    bool flipx = true;
    private Transform t;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(1, 1) * speed;
        t = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<SpriteRenderer>().flipX = flipx;
    }

    public void FaceCorrectDirection(float x, float y)
    {
        if(x < t.position.x)
        {
            flipx = true;
        }
        else
        {
            flipx = false;
        }
    }
}
