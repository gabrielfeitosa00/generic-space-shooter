using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnerScript : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject npc;
    private float height;
    private float width;
    private float ratio;
    private float hPC;
    void Start()
    {
          height = Camera.main.orthographicSize;
        ratio = Camera.main.aspect;
        width = height *  ratio;
        InvokeRepeating("respawn", 1,0.5f);
    }

    void respawn()
    {
        float x = Random.Range(-width, width);
        Vector2 pos = new Vector2(x, height + 2);
        Instantiate(npc, pos, Quaternion.identity);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
