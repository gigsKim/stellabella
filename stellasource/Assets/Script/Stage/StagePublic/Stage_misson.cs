using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Stage_misson : MonoBehaviour
{


    public ScoreManager_Finish scoreManager; // 스코어 매니저 받아올것


    public GameObject missionobj1; // 달아놓을 미션오브젝트
    public GameObject missionobj2;
    public GameObject missionobj3;

    public string missionname1; //미션 오브젝트의 이름
    public string missionname2;
    public string missionname3;


    public Sprite objectimg1;
    public Sprite objectimg2;
    public Sprite objectimg3; //이미지를 붙여넣을 변수들

    public int randommisson = 0;//랜덤으로 미션을 정할 함수
    public GameObject percentTxt;//퍼센트를 나타나는 텍스트
    public GameObject icon;//이미지를 붙여넣을 칸

    public int max =0 ;//퍼센트 계산때 쓸 최대 이미지
    public int min =0;//


    public int score1 = 0;
    public int score2 = 0;
    public int score3 = 0;

    public int object1count = 0;
    public int object2count = 0;
    public int object3count = 0;


    public int object1max = 0;
    public int object2max = 0;
    public int object3max = 0;


    public float percent = 0;
    public bool missoncomplete = false;//미션이 끝났는지 아닌지 확인하는 변수

    public void Start()
    {
        scoreManager = GameObject.Find("Finish_screen").GetComponent<ScoreManager_Finish>();
        randommisson = Random.Range(0, 3);//3가지 미션중 하나가 선택된다.
        missionname1 = missionobj1.gameObject.name;
        missionname2 = missionobj2.gameObject.name;
        missionname3 = missionobj3.gameObject.name;
        icon = GameObject.Find("Missionimage");
        percentTxt = GameObject.Find("MissionText");
      

    }


    public void Update()
    {


        if(randommisson == 0)
        {

            icon.GetComponent<Image>().sprite = objectimg1;
            max = object1max;
            min = object1count;
           

            percent = (float)min / (float)max * 100;
            percentTxt.GetComponent<Text>().text = percent.ToString("N2") + "%";

            if (min >= max)
            {
                
                
                percentTxt.GetComponent<Text>().text = "MISSION CLEAR";
                if (missoncomplete == false)
                {
                    scoreManager.missionclear = true;
                    scoreManager.missionscore = score1;

                    missoncomplete = true;
                   
                }
            }
        }
        
        if(randommisson == 1)
        {
            icon.GetComponent<Image>().sprite = objectimg2;
            max = object2max;
            min = object2count;
           

            percent = (float)min / (float)max * 100;
            percentTxt.GetComponent<Text>().text = percent.ToString("N2") + "%";

            if (min >= max)
            {

                percentTxt.GetComponent<Text>().text = "MISSION CLEAR";
                if (missoncomplete == false)
                {

                    scoreManager.missionclear = true;
                    scoreManager.missionscore = score2;

                    missoncomplete = true;

                }

            }

        }

        if(randommisson ==2 )
        {

            icon.GetComponent<Image>().sprite = objectimg3;
            max = object3max;
            min = object3count;
            
            percent = (float)min / (float)max * 100;
            percentTxt.GetComponent<Text>().text = percent.ToString("N2")+"%";

            if (min >= max)
            {

                percentTxt.GetComponent<Text>().text = "MISSION CLEAR";
                if (missoncomplete == false)
                {
                    scoreManager.missionclear = true;
                    scoreManager.missionscore = score3;


                    missoncomplete = true;

                }

            }

        }





    }





}
