using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage_Final_half : MonoBehaviour
{

    // Start is called before the first frame update
    //스테이지별로 메인카메라에 달것
    private int stage1_timecheck = 0;
    //적기체 프리팹 달아주기
    public Enemy_ufo_align_status st;

    //생성용 스크립트 달아주기
    public Enemy_Spawn_DM create;

    int plus = 10;
    int cs;
    //보스한번만 생성하게 하기위한 bool
    bool boss_check = false;
    bool end = false;
    float checktime = 0;
   public int halftime = 0;

    private void Start()
    {
       
        boss_check = true;
        create = GameObject.Find("MainCamera").GetComponent<Enemy_Spawn_DM>();
    }

    void FixedUpdate()
    {

        stage1_timecheck++;
        //조건이 되는 정수는 frame 이 frame이상으로 timecheck가 증가하면 보스 출현
        if (end == false && halftime < 2)
        {
            //조건이 되는 정수는 패턴이 한번 다돌때까지의 frame(정수 이후는 또 case 0부터 실행되게)
            switch (stage1_timecheck % 3350)
            {

                case 50:
                    {
                        create.PrintEnemy(1, 4);
                        create.PrintEnemy(2, 5);

                    }
                    break;


             


                case 120:
                     create.PrintEnemy(9, 1);
                      break;
                case 130:
                    create.PrintEnemy(9, 1);
                    break;
                case 140:
                    create.PrintEnemy(9, 1);
                    break;
                case 150:
                    create.PrintEnemy(9, 1);
                    break;
                case 160:
                    create.PrintEnemy(9, 1);
                    break;
                case 170:
                    create.PrintEnemy(9, 1);
                    break;
                case 180:
                    create.PrintEnemy(9, 1);
                    break;
                case 190:
                    create.PrintEnemy(9, 1);
                    break;
                case 200:
                    create.PrintEnemy(9, 1);
                    break;
                case 210:
                    create.PrintEnemy(9, 1);
                    break;




              

                case 400:
                    {
                        create.PrintEnemy(0, 7);
                        create.PrintEnemy(3, 7);

                        
                    }
                    break;


                case 450:
                    {
                        //create.PrintEnemy(1, 4);
                        create.PrintEnemy(1, 4);
                        create.PrintEnemy(7, 5);
                        create.PrintEnemy(4, 4);

                    }
                    break;


                case 500:
                    {
                        //create.PrintEnemy(1, 4);
                        create.PrintEnemy(6, 4);
                        create.PrintEnemy(3, 5);
                      

                    }
                    break;

                case 620:
                    create.PrintEnemy(8, 1);
                    break;
                case 630:
                    create.PrintEnemy(8, 1);
                    break;
                case 640:
                    create.PrintEnemy(8, 1);
                    break;
                case 650:
                    create.PrintEnemy(8, 1);
                    break;
                case 660:
                    create.PrintEnemy(8, 1);
                    break;
                case 670:
                    create.PrintEnemy(8, 1);
                    break;
                case 680:
                    create.PrintEnemy(8, 1);
                    break;
                case 690:
                    create.PrintEnemy(8, 1);
                    break;
                case 700:
                    create.PrintEnemy(8, 1);
                    break;
                case 710:
                    create.PrintEnemy(8, 1);
                    break;





                case 850:
                    {
                        create.PrintEnemy(1, 7);
                        create.PrintEnemy(6, 7);

                        
                    }
                    break;

                case 1100:
                    {
                        create.PrintEnemy(0, 8);
                        create.PrintEnemy(4, 10);
                        create.PrintEnemy(7, 10);
                    }
                    break;

                case 1150:
                    {
                        create.PrintEnemy(6, 8);
                        create.PrintEnemy(1, 10);
                    }
                    break;


                case 1200:
                    {
                        create.PrintEnemy(3, 8);
                        create.PrintEnemy(5, 8);
                    }
                    break;



                case 1300:
                    {
                        create.PrintEnemy(2, 8);
                        create.PrintEnemy(6, 10);
                    }
                    break;



                case 1400:
                    {
                        create.PrintEnemy(3, 10);
                        create.PrintEnemy(0, 8);
                        create.PrintEnemy(7, 8);
                    }
                    break;


                case 1500:
                    {
                        create.PrintEnemy(2, 7);
                        create.PrintEnemy(5, 7);
                        create.PrintEnemy(7, 7);
                    }
                    break;

                case 1650:
                    {
                        create.PrintEnemy(0, 6);
                        create.PrintEnemy(3, 6);
                        create.PrintEnemy(7, 9);
                    }
                    break;


                case 1700:
                    {
                        create.PrintEnemy(1, 6);
                        create.PrintEnemy(2, 9);
                        create.PrintEnemy(4, 6);
                        create.PrintEnemy(3, 9);
                    }
                    break;


                case 1750:
                    {
                        create.PrintEnemy(0, 9);
                        create.PrintEnemy(6, 6);
                        create.PrintEnemy(5, 6);
                       
                    }
                    break;

                case 1800:
                    {
                        create.PrintEnemy(7, 9);
                        create.PrintEnemy(2, 5);
                        create.PrintEnemy(5, 3);
                        create.PrintEnemy(7, 5);
                    }
                    break;

                case 1890:
                    {
                        //create.PrintEnemy(1, 4);
                        create.PrintEnemy(1, 4);
                        create.PrintEnemy(7, 5);
                      

                    }
                    break;


                case 1900:
                    create.PrintEnemy(9, 1);
                    break;
                case 1910:
                    create.PrintEnemy(9, 1);
                    break;
                case 1920:
                    create.PrintEnemy(9, 1);
                    break;
                case 1930:
                    {
                        create.PrintEnemy(5, 4);
                        create.PrintEnemy(6, 7);
                        create.PrintEnemy(9, 1);
                        break;
                    }
                case 1940:
                    create.PrintEnemy(9, 1);
                    break;
                case 1950:
                    create.PrintEnemy(9, 1);
                    break;
                case 1960:
                    create.PrintEnemy(9, 1);
                    break;
                case 1970:
                    create.PrintEnemy(9, 1);
                    break;

                case 1980:
                    create.PrintEnemy(9, 1);
                    break;
                case 1990:
                    create.PrintEnemy(9, 1);
                    break;

                case 2100:
                    {
                        create.PrintEnemy(1, 2);
                        create.PrintEnemy(6, 2);
                    }
                    break;

                case 2300:
                    {
                        create.PrintEnemy(7, 7);
                        create.PrintEnemy(1, 7);
                    }
                    break;

                

                case 2600:
                    {
                        create.PrintEnemy(0, 6);
                        create.PrintEnemy(2, 9);
                        create.PrintEnemy(7,9);
                        create.PrintEnemy(6, 6);

                    }
                    break;



                case 2800:
                    {
                        create.PrintEnemy(1, 9);
                        create.PrintEnemy(4, 7);
                        create.PrintEnemy(3, 6);


                    }
                    break;

                case 2900:
                    {
                        create.PrintEnemy(4, 6);
                        create.PrintEnemy(1, 9);
                        create.PrintEnemy(7, 9);

                    }
                    break;


                case 2950:
                    {
                        create.PrintEnemy(0, 9);
                        create.PrintEnemy(2, 4);
                        create.PrintEnemy(5, 4);
                        create.PrintEnemy(6, 6);

                    }
                    break;

                case 3000:
                    create.PrintEnemy(8, 1);
                    break;

                case 3010:
                    create.PrintEnemy(8, 1);
                    break;

                case 3020:
                    create.PrintEnemy(8, 1);
                    break;
                case 3030:
                    create.PrintEnemy(8, 1);
                    break;

                case 3040:
                    create.PrintEnemy(8, 1);
                    break;
                case 3050:
                    create.PrintEnemy(8, 1);
                    break;

                case 3060:
                    create.PrintEnemy(8, 1);
                    break;
                case 3070:
                    create.PrintEnemy(8, 1);
                    break;

                case 3080:
                    create.PrintEnemy(8, 1);
                    break;


                case 3090:
                    create.PrintEnemy(8, 1);
                    break;

                case 3150:
                    create.PrintEnemy(5, 2);
                    break;

                case 3300:
                    {
                        if (halftime >= 1)
                        {
                            boss_check = true;
                        }
                        halftime++;
                    }
                    break;



                default:
                    break;
            }
        }


        if (halftime >= 2)
        {
            end = true;
            checktime += Time.deltaTime;
            if (boss_check == true && checktime >= 3f)
            {
                create.PrintEnemy(10, 0);
                gameObject.GetComponent<AudioSource>().Stop();
                boss_check = false;
            }
        }
    }

}
