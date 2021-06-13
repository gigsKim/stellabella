using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage3 : MonoBehaviour
{
    //스테이지별로 메인카메라에 달것
    private int stage1_timecheck = 0;
    //적기체 프리팹 달아주기

    bool end = false;
    //생성용 스크립트 달아주기
    public Enemy_Spawn_DM create;

    //보스한번만 생성하게 하기위한 bool
    bool boss_check = false;
    float checktime = 0;
    float time = 0;
    public int halftime = 0;

    private void Start()
    {
           halftime = 0;
    create = GameObject.Find("MainCamera").GetComponent<Enemy_Spawn_DM>();
    }

    void FixedUpdate()
    {
        stage1_timecheck++;
        //조건이 되는 정수는 frame 이 frame이상으로 timecheck가 증가하면 보스 출현

        //조건이 되는 정수는 패턴이 한번 다돌때까지의 frame(정수 이후는 또 case 0부터 실행되게)

        //Debug.Log(stage1_timecheck % 2400);

        if (halftime >= 2)
        {
            checktime += Time.deltaTime;
            end = true;
            if (boss_check == false && checktime >= 3)
            {

                create.PrintEnemy(10, 0);
                gameObject.GetComponent<AudioSource>().Stop();
                boss_check = true;

            }
        }

        if (end == false)
        {
            time += Time.deltaTime;



            switch (stage1_timecheck % 3630)
            {

                //0 == boss
                //1 == justmove
                //2 == luncher
                //3 == tank
                //4 == pattern1
                //5 == pattern2
                //6 == pattern3
                //7 == pattern4


                case 20:
                    {

                       
                        create.PrintEnemy(4, 4);
                        create.PrintEnemy(3, 5);
                        create.PrintEnemy(2, 5);
                        Debug.Log(Time.deltaTime +"첫 번째");
                        break;
                    }

                    



                case 50:

                    {

                        create.PrintEnemy(5,1);
                        create.PrintEnemy(2,8);
                        create.PrintEnemy(1,4);
                        
                        break;

                    }
                   




                case 200:
                    {
                        create.PrintEnemy(1, 2);
                        //create.PrintEnemy(2, 4);
                        create.PrintEnemy(2,7);
                        break;
                    }
                    

                case 350:
                    {
                        create.PrintEnemy(6, 1);
                        create.PrintEnemy(2, 1);
                        create.PrintEnemy(8, 3);
                        create.PrintEnemy(7, 2);
                        create.PrintEnemy(3, 9);

                        break;
                    }





                case 600:
                    {
                       //create.PrintEnemy(8, 3);
                        create.PrintEnemy(4, 1);
                        create.PrintEnemy(7, 5);
                        create.PrintEnemy(5, 2);
                        create.PrintEnemy(3, 9);

                    }
                    break;

                case 850:
                    {
                        create.PrintEnemy(3, 1);
                        create.PrintEnemy(4, 4);
                        create.PrintEnemy(8, 3);
                        create.PrintEnemy(0, 2);
                       
                    }
                    break;


                case 1000:
                    {
                        create.PrintEnemy(7, 1);
                        create.PrintEnemy(8, 3);
                        create.PrintEnemy(5, 2);
                        create.PrintEnemy(1, 1);
                        create.PrintEnemy(6, 9);
                    }
                    break;

                case 1100:
                    {
                        
                        create.PrintEnemy(2, 9);
                        create.PrintEnemy(8, 3);
                        create.PrintEnemy(7, 2);

                    }
                    break;
                case 1200:
                    {
                        create.PrintEnemy(0, 2);
                        create.PrintEnemy(3, 1);
                        create.PrintEnemy(5, 5);
                        create.PrintEnemy(8, 3);
                        break;

                    }
                case 1400:
                    {
                        create.PrintEnemy(2, 2);
                        create.PrintEnemy(3, 5);
                        create.PrintEnemy(2, 1);
                        create.PrintEnemy(8, 3);
                    }
                    break;
                case 1450:
                    {
                        create.PrintEnemy(2, 8);
                        create.PrintEnemy(5, 1);
                        create.PrintEnemy(7, 6);
                        create.PrintEnemy(2, 7);
                        break;
                    }


                case 1700:
                    {
                        create.PrintEnemy(4, 4);
                        create.PrintEnemy(3, 1);
                        create.PrintEnemy(1, 2);
                        create.PrintEnemy(7, 1);
                        break;
                    }


                case 1900:
                    {
                        create.PrintEnemy(8, 3);
                        create.PrintEnemy(7, 1);
                        create.PrintEnemy(0, 4);
                        create.PrintEnemy(7, 5);
                        create.PrintEnemy(1, 2);
                        break;
                    }


                case 2000:
                    {
                        create.PrintEnemy(8, 3);
                        create.PrintEnemy(1, 1);
                      
                        create.PrintEnemy(5, 1);
                        break;
                    }


                case 2200:
                    {
                        create.PrintEnemy(0, 9);
                        create.PrintEnemy(1, 2);

                        create.PrintEnemy(3, 1);

                        create.PrintEnemy(4, 9);
                        create.PrintEnemy(7, 5);
                        break;
                    }


                case 2400:
                    {
                        create.PrintEnemy(5, 6);
                        create.PrintEnemy(2, 8);
                        create.PrintEnemy(9, 2);
                        create.PrintEnemy(5, 1);


                        break;
                    }



                case 2600:
                    {
                        create.PrintEnemy(8, 3);
                        create.PrintEnemy(6, 5);
                        create.PrintEnemy(1, 1);


                        break;
                    }



                case 2800:
                    {
                        create.PrintEnemy(8, 3);
                        create.PrintEnemy(6, 1);
                        create.PrintEnemy(2, 1);


                        break;
                    }


                case 3000:
                    {
                        create.PrintEnemy(8, 3);
                        create.PrintEnemy(2, 9);
                        create.PrintEnemy(5, 4);
                        create.PrintEnemy(7, 2);


                        break;
                    }

                case 3150:
                    {
                        //create.PrintEnemy(2, 7);
                        create.PrintEnemy(2, 5);
                        create.PrintEnemy(5, 4);
                        create.PrintEnemy(7, 1);


                        break;
                    }


                case 3300:
                    {
                        create.PrintEnemy(0, 9);
                        create.PrintEnemy(3, 9);
                        create.PrintEnemy(5, 9);
                        create.PrintEnemy(7, 1);
                        create.PrintEnemy(4, 1);
                        break;
                    }


                case 3600:
                    {
                        halftime++;   


                        break;
                    }




                default:
                    break;
            }

        }


       
    }

}
