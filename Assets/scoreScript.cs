using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class scoreScript : MonoBehaviour
{
    // Start is called before the first frame update
    private static float score = 0;
    private static GameObject txtScore;
    void Start()
    {
        txtScore = GameObject.Find("txtScore");
    }

    public static void addScore(int value){
        score += value;
        txtScore.GetComponent<TMP_Text>().text = "Score: " + score;
        if(score % 100 == 0){
            liveScript.addLive();
        }
    }

    public static void resetScore()
    {
        score = 0;
    }
   
}
