using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projectileMovement : MonoBehaviour
{
    private Rigidbody2D rbd;
    public float vel;
    private float height;
    private AudioSource sound;
    // Start is called before the first frame update
    void Start()
    {
        rbd = GetComponent<Rigidbody2D>();
        sound = GetComponent<AudioSource>();
        vel = 5;
        rbd.velocity = new Vector2(0, vel)  ;
        height = Camera.main.orthographicSize;
        sound.Play();
    }

    // Update is called once per frame
    void Update()
    {
          if(transform.position.y > height+1) {
            Destroy(this.gameObject);
        }
    }
}
