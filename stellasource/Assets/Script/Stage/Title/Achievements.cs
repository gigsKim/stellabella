using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Achievements : MonoBehaviour
{
    private bool onBtn = true;

    //랭킹 받아오기
    private void Start()
    {
        string temp = Player_status.DBReadScore();
        if (temp != "")
        {
            string[] rank = temp.Split(';');
            for (int i = 0; i < 16; i++)
            {
                //this.transform.GetChild(0).GetChild(i).GetComponent<Text>().text = rank[i];
            }
        }
    }

    //버튼 누르면 껏다켰다
    public void OnAchievements()
    {
        if (onBtn)
        {
            onBtn = false;
            this.transform.GetChild(0).gameObject.SetActive(true);
            this.transform.GetChild(1).gameObject.SetActive(true);
        }
        else
        {
            onBtn = true;
            this.transform.GetChild(0).gameObject.SetActive(false);
            this.transform.GetChild(1).gameObject.SetActive(false);
        }
    }
}
