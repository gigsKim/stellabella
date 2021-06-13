using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage3_2 : MonoBehaviour
{
    //스테이지별로 메인카메라에 달것
    private int stage1_timecheck = 0;
    //적기체 프리팹 달아주기

    public int harftime = 2;
    bool end = false;
    //생성용 스크립트 달아주기
    public Enemy_Spawn_DM create;

    //보스한번만 생성하게 하기위한 bool
    bool boss_check = false;
    float time = 0;
    float check_time = 0;
    private void Start()
    {
        create = GameObject.Find("MainCamera").GetComponent<Enemy_Spawn_DM>();
    }

    void FixedUpdate()
    {
        stage1_timecheck++;
        //조건이 되는 정수는 frame 이 frame이상으로 timecheck가 증가하면 보스 출현

        //조건이 되는 정수는 패턴이 한번 다돌때까지의 frame(정수 이후는 또 case 0부터 실행되게)

        //Debug.Log(stage1_timecheck % 2400);


        if (end == false)
        {
            time += Time.deltaTime;

            switch (stage1_timecheck % 4500)
            {

                //0 == boss
                //1 == mine
                //2 == submarrine
                //3 == turtle
                //4 == airplane
                //5 == airplane
                //6 == shipwarror
                //7 == shark


                case 50:
                    {



                        create.PrintEnemy(13, 1);
                        create.PrintEnemy(11, 1);
                        create.PrintEnemy(12, 1);
                        create.PrintEnemy(10, 1);
                        create.PrintEnemy(9, 1);
                        break;
                    }

                case 200:
                    {
                        create.PrintEnemy(3, 4);
                        create.PrintEnemy(5, 4);

                    }
                    break;


                case 350:
                    {
                        create.PrintEnemy(8, 3);
                        break;
                    }

                case 380:
                    {
                        create.PrintEnemy(8, 3);
                        break;
                    }


                

                case 450:
                    {

                        create.PrintEnemy(1, 2);
                        create.PrintEnemy(12, 5);
                        create.PrintEnemy(2, 4);
                        create.PrintEnemy(3, 5);
                        //create.PrintEnemy(14, 2);
                        break;
                    }



                case 600:
                    {

                        create.PrintEnemy(14, 1);
                      
                        create.PrintEnemy(6, 6);
                        create.PrintEnemy(1, 5);
                       
                        create.PrintEnemy(3, 4);
                    
                        
                        //create.PrintEnemy(14, 2);
                        break;
                    }

                case 700:
                    {
                        create.PrintEnemy(9, 1);
                        create.PrintEnemy(13, 1);
                        create.PrintEnemy(11, 1);
                        create.PrintEnemy(4, 5);
                        
                        create.PrintEnemy(7, 5);

                        break;
                    }

                case 750:
                    {
                       
                        create.PrintEnemy(3, 4);

                    }
                    break;

                case 790:
                    {
                        create.PrintEnemy(8, 3);
                        create.PrintEnemy(1, 2);

                    }
                    break;

                case 830:
                    {
                        create.PrintEnemy(8, 3);
                        create.PrintEnemy(13, 1);
                        create.PrintEnemy(12, 1);

                    }
                    break;


                case 870:
                    {
                        create.PrintEnemy(8, 3);
                        create.PrintEnemy(6, 5);
                        

                    }
                    break;

                case 910:
                    {
                        create.PrintEnemy(8, 3);
                        create.PrintEnemy(0, 2);
                        create.PrintEnemy(7, 4);

                    }
                    break;

                case 950:
                    {
                     
                        create.PrintEnemy(6, 5);
                        //create.PrintEnemy(2, 4);

                    }
                    break;


                case 1050:
                    {
                        create.PrintEnemy(1, 6);
                        create.PrintEnemy(2, 7);
                        

                    }
                    break;



                case 1300:
                    {
                        create.PrintEnemy(13, 1);
                        
                        create.PrintEnemy(11, 2);
                        create.PrintEnemy(1, 5);
                    }
                    break;

                case 1500:
                {
                        create.PrintEnemy(14, 1);
                        create.PrintEnemy(13, 1);
                        create.PrintEnemy(4, 6);
                        create.PrintEnemy(7, 6);

                    }
                    break;

                case 1700:
                    {

                        create.PrintEnemy(8, 3);

                    }
                    break;

                case 1740:
                    {
                        create.PrintEnemy(2, 4);
                        create.PrintEnemy(8, 3);

                    }
                    break;

                case 1780:
                    {
                        create.PrintEnemy(12, 1);
                        create.PrintEnemy(8, 3);

                    }
                    break;

                case 1820:
                    {
                        create.PrintEnemy(9, 2);
                        create.PrintEnemy(8, 3);

                    }
                    break;

                case 1860:
                    {
                        create.PrintEnemy(0 ,5);
                     
                        create.PrintEnemy(8, 3);

                    }
                    break;

                case 1900:
                    {
                        create.PrintEnemy(13, 1);
                        create.PrintEnemy(11, 1);
                        create.PrintEnemy(8, 3);

                    }
                    break;


                case 2200:
                    {
                        create.PrintEnemy(8, 4);
                        create.PrintEnemy(3, 5);
                        create.PrintEnemy(0, 2);
                   
                        create.PrintEnemy(7, 6);
                        create.PrintEnemy(5, 4);

                    }
                    break;


                case 2400:
                    {
                        create.PrintEnemy(13, 4);
                        create.PrintEnemy(11, 5);
                        create.PrintEnemy(2, 7);
                    
                        create.PrintEnemy(9, 2);



                    }
                    break;


                case 2600:
                    {
                        create.PrintEnemy(10, 1);
                        create.PrintEnemy(15, 1);
                        



                    }
                    break;

                case 2800:
                    {
                        create.PrintEnemy(11, 1);
                        create.PrintEnemy(13, 1);
                       



                    }
                    break;

                case 3000:
                    {
                        create.PrintEnemy(5, 4);
                        create.PrintEnemy(9, 5);
                        create.PrintEnemy(11, 5);
                    }
                    break;


                case 3200:
                    {
                        create.PrintEnemy(2, 2);
                        create.PrintEnemy(9, 1);
                        create.PrintEnemy(8, 3);
                       
                    }
                    break;

                case 3240:
                    {


                        create.PrintEnemy(9, 5);
                        create.PrintEnemy(8, 3);

                    }
                    break;

                case 3280:
                    {
                        create.PrintEnemy(2, 7);
                        create.PrintEnemy(8, 3);

                    }
                    break;

                case 3300:
                    {
                        create.PrintEnemy(8, 6);

                    }
                    break;


                case 3500:
                    {
                        create.PrintEnemy(11, 1);
                        create.PrintEnemy(9, 5);
                        create.PrintEnemy(7, 2);

                    }
                    break;

                case 3700:
                    {
                        create.PrintEnemy(7, 4);
                        create.PrintEnemy(11, 5);
                        create.PrintEnemy(13, 4);

                    }
                    break;

                case 3900:
                    {
                        create.PrintEnemy(9, 1);
                        create.PrintEnemy(14, 1);
                        

                    }
                    break;


                case 4000:
                    {
                       
                       
                        create.PrintEnemy(8, 3);

                    }
                    break;

                case 4100:
                    {

                        create.PrintEnemy(4, 4);
                        create.PrintEnemy(5, 6);
                        create.PrintEnemy(8, 3);

                    }
                    break;

                case 4300:
                    {

                        create.PrintEnemy(6, 4);
                        create.PrintEnemy(5, 5);
                        
                       
                    }
                    break;
                    
                case 4490:
                    {
                        harftime++;
                    }
                    break;

            }

        }

        if (harftime >=2 && boss_check == false)
        {
            end = true;
            check_time += Time.deltaTime;

            


            if (boss_check == false  && check_time >= 5)
            {
                gameObject.GetComponent<AudioSource>().Stop();
                create.PrintEnemy(16, 0);
                boss_check = true;

            }

        }
    }
}
