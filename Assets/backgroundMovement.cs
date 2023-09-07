using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backgroundMovement : MonoBehaviour
{
    private Rigidbody2D rbd;
    public float vel;
    private float height;
    private float hPC;

    // Start is called before the first frame update
    void Start()
    {
        rbd = GetComponent<Rigidbody2D>();
        vel = -6;
        rbd.velocity = new Vector2(0, vel);
        height = Camera.main.orthographicSize;

        hPC = GetComponent<SpriteRenderer>().bounds.size.y/2;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -2*height)
        {
            transform.position = new Vector2(0, height+ hPC);

        }
    }
}
