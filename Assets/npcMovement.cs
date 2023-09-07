using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class npcMovement : MonoBehaviour
{
    private Rigidbody2D rbd;
    public float vel;
    private float height;
    private AudioSource sound;
    // Start is called before the first frame update
    void Start()
    {
        rbd = GetComponent<Rigidbody2D>();
        
        vel = -5;
        rbd.velocity = new Vector2(0, vel);
        height = Camera.main.orthographicSize;
    
    }
        void OnTriggerEnter2D(Collider2D col){
           
            if(col.tag == "shoot1"){
                scoreScript.addScore(50);
                Destroy(this.gameObject);
                  Destroy(col.gameObject);
            }  
       
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y < -height-1) {
            Destroy(this.gameObject);
           
        }
    }
}
