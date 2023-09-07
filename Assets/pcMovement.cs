using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
public class pcMovement : MonoBehaviour

    
{
    // Start is called before the first frame update
    private Rigidbody2D rbd;
    public float vel;
    private float height;
    private float width;
    private float ratio;
    private float hPC;
 
    private static GameObject txtLives;
    public GameObject projectile;

   
    void Start()
    {

        rbd = GetComponent<Rigidbody2D>();
        vel = 10;
        height = Camera.main.orthographicSize;
        ratio = Camera.main.aspect;
        width = height *  ratio;

        hPC = GetComponent<SpriteRenderer>().bounds.size.y/2;
        txtLives = GameObject.Find("txtLives");
        
    }
void OnCollisionEnter2D(Collision2D col){
        Debug.Log("Bateu");
    }
void OnTriggerEnter2D(Collider2D col){
    if(col.tag != "shoot1")
           { 
            
            liveScript.removeLive();
            if(liveScript.getLive()<=0){
               
                Destroy(this.gameObject);
                SceneManager.LoadSceneAsync(2);
                liveScript.resetLive();
                scoreScript.resetScore();
            }
            
            }
         
       
        
    }

 
    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        rbd.velocity = new Vector2(x, y) * vel;
        if(transform.position.x>width){
            transform.position = new Vector2(-width, transform.position.y);
        } else if (transform.position.x<-width){
              transform.position = new Vector2(width, transform.position.y);
        }

        
        if (transform.position.y>0f){
              transform.position = new Vector2(transform.position.x, 0f);
        }
        else if (transform.position.y<-height+hPC){
              transform.position = new Vector2(transform.position.x, -height+hPC);
        }

          if (Input.GetKeyDown(KeyCode.Space)
            ||Input.GetMouseButtonDown(0))
        {  Vector2 pos = new Vector2(transform.position.x, transform.position.y+hPC);
            Instantiate(projectile, pos,Quaternion.identity);
        }

      
    }
}
