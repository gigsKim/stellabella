using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finalstage : MonoBehaviour
{
    //스테이지별로 메인카메라에 달것
    private int stage1_timecheck = 0;
    //적기체 프리팹 달아주기

    public int harftime = 0;
    bool end = false;
    //생성용 스크립트 달아주기
    public Enemy_spawn_2 create;

    //보스한번만 생성하게 하기위한 bool
   public bool boss_check = false;
    float time = 0;
    float check_time = 0;
    private void Start()
    {
        create = GameObject.Find("MainCamera").GetComponent<Enemy_spawn_2>();
    }

    void FixedUpdate()
    {
        if(end == false)
        stage1_timecheck++;
        //조건이 되는 정수는 frame 이 frame이상으로 timecheck가 증가하면 보스 출현

        //조건이 되는 정수는 패턴이 한번 다돌때까지의 frame(정수 이후는 또 case 0부터 실행되게)

        //Debug.Log(stage1_timecheck % 2400);


        if (end == false)
        {
            time += Time.deltaTime;

            switch (stage1_timecheck % 4400)
            {

                //0 == boss
                //1 == metere
                //2 == ufo
                //3 == ball
                //4 == rapid
                //5 == airplane
                //6 == shipwarror
                //7 == shark
                //8 == container

                case 200:
                    {


                        create.PrintEnemy(1, 8);
                        create.PrintEnemy(8, 8);

                     
                        break;
                    }


                case 500:
                    {


                        create.PrintEnemy(5,1);
                        create.PrintEnemy(1,1);

                        break;
                    }


                case 600:
                    {

                        create.PrintEnemy(1, 3);
                        create.PrintEnemy(4, 4);
                        create.PrintEnemy(5, 4);


                        break;
                    }

                case 630:
                    {


                        create.PrintEnemy(3, 1);
                        create.PrintEnemy(5, 1);


                        break;
                    }


                case 700:
                    {


                        create.PrintEnemy(0, 2);
                        create.PrintEnemy(5, 6);
                        create.PrintEnemy(8, 2);


                        break;
                    }


                case 900:
                    {


                        create.PrintEnemy(0, 4);
                        create.PrintEnemy(1, 4);
                        create.PrintEnemy(5, 4);
                        create.PrintEnemy(8, 5);
                        create.PrintEnemy(3, 5);
                        create.PrintEnemy(6, 5);


                        break;
                    }

  

                case 1200:
                    {

                        create.PrintEnemy(8, 3);
                        create.PrintEnemy(2, 1);
                        create.PrintEnemy(5, 1);


                        break;
                    }

                case 1400:
                    {
                        create.PrintEnemy(1, 6);
                        create.PrintEnemy(3, 7);
                        create.PrintEnemy(8, 6);

                    }
                    break;

                case 1800:
                    {
                        create.PrintEnemy(0, 2);
                        
                        create.PrintEnemy(7, 2);

                    }
                    break;
                case 1900:
                    {
                        create.PrintEnemy(4, 4);
                        create.PrintEnemy(3, 5);
                        create.PrintEnemy(5, 4);

                    }
                    break;


                case 2200:
                    {
                        create.PrintEnemy(0, 8);
                       
                        create.PrintEnemy(8, 3);

                    }
                    break;

                case 2500:
                    {
                        create.PrintEnemy(1, 4);
                        create.PrintEnemy(3, 4);
                        create.PrintEnemy(4, 6);
                        create.PrintEnemy(5, 5);
                        create.PrintEnemy(8, 5);

                    }
                    break;


                

                case 3000:
                    {
                      

                        create.PrintEnemy(4, 2);

                        create.PrintEnemy(8, 2);

                    }
                    break;


                case 3200:
                    {
                        create.PrintEnemy(1, 4);
                        create.PrintEnemy(7, 5);

                        create.PrintEnemy(3, 9);

                    }
                    break;

                case 3400:
                    {
                        create.PrintEnemy(5, 1);
                       
                        create.PrintEnemy(8, 3);
                    }
                    break;

                case 3700:
                    {
                        create.PrintEnemy(1, 3);
                        create.PrintEnemy(4, 4);
                        create.PrintEnemy(8, 4);
                    }
                    break;

                case 3900:
                    {
                        create.PrintEnemy(2, 2);
                        create.PrintEnemy(4, 1);
                        create.PrintEnemy(6, 2);
                    }
                    break;

                case 4100:
                    {
                        create.PrintEnemy(1, 1);
                        create.PrintEnemy(4, 1);
                        create.PrintEnemy(8, 1);
                    }
                    break;

                case 4300:
                    {
                        create.PrintEnemy(1, 3);
                        create.PrintEnemy(4, 4);
                        create.PrintEnemy(5, 4);
                    }
                    break;

                


                case 4350:
                    {
                        harftime++;
                        if (harftime >= 1)
                        {
                            boss_check = true;
                        }
                    }
                    break;


            }

        }

        if (harftime >= 2 && boss_check == true)
        {
            end = true;
            check_time += Time.deltaTime;




            if (boss_check == true && check_time >= 9)
            {

                create.PrintEnemy(10, 0);
                gameObject.GetComponent<AudioSource>().Stop();
                boss_check = false;

            }

        }
    }
}
