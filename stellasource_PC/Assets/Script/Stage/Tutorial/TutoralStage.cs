using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutoralStage : MonoBehaviour
{
    public int stageT_timecheck = 0;
    //적기체 프리팹 달아주기

    public bool shoottuto = false;
    public bool boomtuto = false;
    //생성용 스크립트 달아주기
    public Enemy_Spawn create;

    public GameObject Totocanvas;
    private void Start()
    {
        Totocanvas = GameObject.Find("TuToCanVas");
        Totocanvas.SetActive(false);
        
    }

    void FixedUpdate()
    {
        stageT_timecheck++;
        //조건이 되는 정수는 frame 이 frame이상으로 timecheck가 증가하면 보스 출현
        if (stageT_timecheck < 1200)
        {
            //조건이 되는 정수는 패턴이 한번 다돌때까지의 frame(정수 이후는 또 case 0부터 실행되게)
            switch (stageT_timecheck % 1200)
            {
                case 0:
                    
                    create.PrintEnemy(4, 4);
                    break;
           
                case 70:
                    Time.timeScale = 0;
                    Totocanvas.SetActive(true);
                    Totocanvas.transform.GetChild(1).gameObject.SetActive(true);
                    Totocanvas.transform.GetChild(2).gameObject.SetActive(false);
                    Totocanvas.transform.GetChild(3).gameObject.SetActive(false);
                    shoottuto = true;
                    break;
                case 71:
                    Totocanvas.SetActive(false);
                    break;
                case 100:
                    create.PrintEnemy(5, 4);
                    break;
                case 150:
                    create.PrintEnemy(7, 3);
                    break;
                case 200:
                    create.PrintEnemy(2, 7);
                    break;
                case 250:
                    create.PrintEnemy(7, 1);
                    break;
                case 350:
                    create.PrintEnemy(6, 2);
                    break;
                case 370:
                    create.PrintEnemy(5, 1);
                    break;
                case 380:
                    create.PrintEnemy(4, 4);
                    break;
                case 390:
                    create.PrintEnemy(3, 2);
                    break;
                case 400:
                    Time.timeScale = 0;
                    Totocanvas.SetActive(true);
                    Totocanvas.transform.GetChild(1).gameObject.SetActive(false);
                    Totocanvas.transform.GetChild(2).gameObject.SetActive(true);
                    Totocanvas.transform.GetChild(3).gameObject.SetActive(false);
                    boomtuto = true;
                    break;
                case 401:
                    Totocanvas.SetActive(false);
                    break;

                case 600:
                    create.PrintEnemy(2, 7);
                    break;
                case 700:
                    create.PrintEnemy(1, 5);
                    break;
                case 800:
                    create.PrintEnemy(6, 2);
                    break;

                case 1100:
                    Time.timeScale = 0f;
                    Totocanvas.SetActive(true);
                    Totocanvas.transform.GetChild(1).gameObject.SetActive(true);
                    Totocanvas.transform.GetChild(2).gameObject.SetActive(true);
                    Totocanvas.transform.GetChild(3).gameObject.SetActive(true);
                    break;
                default:
                    break;
            }
        }

    }
}
