using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{

    private void Update()
    {
        if (this.gameObject.name == "GameOverScore")
        {
            this.GetComponent<Text>().text = "최종점수 : " + Player_status.PS_score;
        }
        else
        {
            this.GetComponent<Text>().text = "Score : " + Player_status.PS_score;
        }
        
    }
}

