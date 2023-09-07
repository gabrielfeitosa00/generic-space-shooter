using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class liveScript : MonoBehaviour
{
    // Start is called before the first frame update
    private static float lives = 3;
     private static GameObject txtLives;
    void Start()
    {
        txtLives = GameObject.Find("txtLives");
    }

    public static void addLive(){
            lives += 1;
            txtLives.GetComponent<TMP_Text>().text = lives+"X Lives";
    }

        public static void removeLive(){
            lives -= 1;
            txtLives.GetComponent<TMP_Text>().text = lives + "X Lives";
    }

public static void resetLive(){
            lives = 3;
            
}
    public static float getLive(){
        return lives;
    }
   
   
}
