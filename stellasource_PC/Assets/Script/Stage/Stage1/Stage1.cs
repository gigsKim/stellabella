using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage1 : MonoBehaviour
{
    //스테이지별로 메인카메라에 달것
    private int stage1_timecheck = 0;
    //적기체 프리팹 달아주기
 

    //생성용 스크립트 달아주기
    public Enemy_Spawn create;

    //보스한번만 생성하게 하기위한 bool
    bool boss_check = true;
    private void Start()
    {
        
    }

    void FixedUpdate()
    {
        stage1_timecheck++;
        //조건이 되는 정수는 frame 이 frame이상으로 timecheck가 증가하면 보스 출현
        if (stage1_timecheck < 3600)
        {
            //조건이 되는 정수는 패턴이 한번 다돌때까지의 frame(정수 이후는 또 case 0부터 실행되게)
            switch (stage1_timecheck % 1200)
            {
                case 0:
                    create.PrintEnemy(4, 4);
                    break;
                case 50:
                    create.PrintEnemy(7, 3);
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
                    create.PrintEnemy(7, 3);
                    break;
                case 300:
                    create.PrintEnemy(1, 5);
                    break;
                case 350:
                    create.PrintEnemy(7, 3);
                    break;
                case 400:
                    create.PrintEnemy(4, 4);
                    break;
                case 500:
                    create.PrintEnemy(5, 4);
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
                case 900:
                    for (int i = 0; i < 7; i++)
                    {
                        create.PrintEnemy(i, 1);
                    }
                    break;
                default:
                    break;
            }
        }
        else if (boss_check)
        {
            boss_check = false;
            create.PrintEnemy(3, 0);
        }
    }
}
