using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BlitzManager : MonoBehaviour
{

    //이미지 달아줘야함
    public Sprite fullblitz;//가득찬 블리츠의 이미지
    public Sprite nomalblitz;//덜 차오른 블리츠의 이미지
    public GameObject[] blitz = new GameObject[5]; //블리츠의 배열
    public GameObject[] blitzgaze = new GameObject[5]; //  블리츠 게이지를 담을 배욜

    public int blitzcount = 0; //  현재 가지고 있는 블리츠의 양 Blitzinvincible에서 사용

    int maxblitz = 5;
    float cooltime = 0; //블리츠가 차는데 걸리는 쿨타임
    float pblitz; //현재 차오르고 있는 블리츠 게이지
    
    bool BlitzStart = true;

    private void Awake()
    {
        for (int i = 0; i < maxblitz; i++)
        {
            blitz[i] = GameObject.Find("blitz" + i);
            blitzgaze[i] = GameObject.Find("blitzgaze" + i);
        }
        
    }

    public void Blitzon()
    {

        for (int i = 0; i < 5; i++)
        {
            blitz[i].SetActive(false);

        }
        for (int i = 0; i < Player_status.PS_blitz; i++)
        {
            blitz[i].SetActive(true);

        } //현재 최대량만큼의 블리츠만 보이게 하고 나머지는 끈다.


        blitzcount = Player_status.PS_blitz;// 현재 블리츠개수 만큼 추가한다.
    }

    void Blitzcool()
    {
        switch (Player_status.PS_blitz)

        {
            case 3:
                {
                    switch (blitzcount)
                    {
                        case 0:
                            blitzgaze[0].GetComponent<Image>().fillAmount = pblitz;
                            blitz[0].GetComponent<Image>().sprite = nomalblitz;


                            blitz[1].GetComponent<Image>().sprite = nomalblitz;
                            blitzgaze[1].GetComponent<Image>().fillAmount = 0f;


                            blitz[2].GetComponent<Image>().sprite = nomalblitz;
                            blitzgaze[2].GetComponent<Image>().fillAmount = 0f;
                            break;

                        case 1:
                            blitz[0].GetComponent<Image>().sprite = fullblitz;


                            blitzgaze[1].GetComponent<Image>().fillAmount = pblitz;
                            blitz[1].GetComponent<Image>().sprite = nomalblitz;

                            blitzgaze[2].GetComponent<Image>().fillAmount = 0;
                            blitz[2].GetComponent<Image>().sprite = nomalblitz;
                            break;

                        case 2:
                            blitz[0].GetComponent<Image>().sprite = fullblitz;

                            blitz[1].GetComponent<Image>().sprite = fullblitz;

                            blitzgaze[2].GetComponent<Image>().fillAmount = pblitz;
                            blitz[2].GetComponent<Image>().sprite = nomalblitz;
                            break;

                        case 3:

                            blitz[0].GetComponent<Image>().sprite = fullblitz;
                            blitz[1].GetComponent<Image>().sprite = fullblitz;
                            blitz[2].GetComponent<Image>().sprite = fullblitz;
                            break;

                    };
                }
                break;


            case 4:
                {
                    switch (blitzcount)
                    {
                        case 0:
                            blitzgaze[0].GetComponent<Image>().fillAmount = pblitz;
                            blitz[0].GetComponent<Image>().sprite = nomalblitz;


                            blitz[1].GetComponent<Image>().sprite = nomalblitz;
                            blitzgaze[1].GetComponent<Image>().fillAmount = 0f;


                            blitz[2].GetComponent<Image>().sprite = nomalblitz;
                            blitzgaze[2].GetComponent<Image>().fillAmount = 0f;

                            blitz[3].GetComponent<Image>().sprite = nomalblitz;
                            blitzgaze[3].GetComponent<Image>().fillAmount = 0f;


                           
                            break;

                        case 1:
                            blitz[0].GetComponent<Image>().sprite = fullblitz;


                            blitzgaze[1].GetComponent<Image>().fillAmount = pblitz;
                            blitz[1].GetComponent<Image>().sprite = nomalblitz;

                            blitz[2].GetComponent<Image>().sprite = nomalblitz;
                            blitzgaze[2].GetComponent<Image>().fillAmount = 0;
                            

                            blitz[3].GetComponent<Image>().sprite = nomalblitz;
                            blitzgaze[3].GetComponent<Image>().fillAmount = 0;
                           
                             
                            break;

                        case 2:
                            blitz[0].GetComponent<Image>().sprite = fullblitz;

                            blitz[1].GetComponent<Image>().sprite = fullblitz;

                            blitzgaze[2].GetComponent<Image>().fillAmount = pblitz;
                            blitz[2].GetComponent<Image>().sprite = nomalblitz;


                            blitz[3].GetComponent<Image>().sprite = nomalblitz;
                            blitzgaze[3].GetComponent<Image>().fillAmount = 0;


                            
                           
                            break;

                        case 3:

                            blitz[0].GetComponent<Image>().sprite = fullblitz;
                            blitz[1].GetComponent<Image>().sprite = fullblitz;
                            blitz[2].GetComponent<Image>().sprite = fullblitz;

                            blitz[3].GetComponent<Image>().sprite = nomalblitz;
                            blitzgaze[3].GetComponent<Image>().fillAmount = pblitz;
                          
                            break;


                        case 4:

                            blitz[0].GetComponent<Image>().sprite = fullblitz;
                            blitz[1].GetComponent<Image>().sprite = fullblitz;
                            blitz[2].GetComponent<Image>().sprite = fullblitz;
                            blitz[3].GetComponent<Image>().sprite = fullblitz;


                            break;

                    };
                }
                break;



            case 5:
                {
                    switch (blitzcount)
                    {
                        case 0:
                            blitzgaze[0].GetComponent<Image>().fillAmount = pblitz;
                            blitz[0].GetComponent<Image>().sprite = nomalblitz;


                            blitz[1].GetComponent<Image>().sprite = nomalblitz;
                            blitzgaze[1].GetComponent<Image>().fillAmount = 0f;


                            blitz[2].GetComponent<Image>().sprite = nomalblitz;
                            blitzgaze[2].GetComponent<Image>().fillAmount = 0f;

                            blitz[3].GetComponent<Image>().sprite = nomalblitz;
                            blitzgaze[3].GetComponent<Image>().fillAmount = 0f;

                            blitz[4].GetComponent<Image>().sprite = nomalblitz;
                            blitzgaze[4].GetComponent<Image>().fillAmount = 0f;
                            break;

                        case 1:
                            blitz[0].GetComponent<Image>().sprite = fullblitz;


                            blitzgaze[1].GetComponent<Image>().fillAmount = pblitz;
                            blitz[1].GetComponent<Image>().sprite = nomalblitz;

                            blitz[2].GetComponent<Image>().sprite = nomalblitz;
                            blitzgaze[2].GetComponent<Image>().fillAmount = 0;

                            blitz[3].GetComponent<Image>().sprite = nomalblitz;
                            blitzgaze[3].GetComponent<Image>().fillAmount = 0;
                        

                            blitz[4].GetComponent<Image>().sprite = nomalblitz;
                            blitzgaze[4].GetComponent<Image>().fillAmount = 0f;
                            break;

                        case 2:
                            blitz[0].GetComponent<Image>().sprite = fullblitz;

                            blitz[1].GetComponent<Image>().sprite = fullblitz;

                            blitzgaze[2].GetComponent<Image>().fillAmount = pblitz;
                            blitz[2].GetComponent<Image>().sprite = nomalblitz;

                            blitz[3].GetComponent<Image>().sprite = nomalblitz;
                            blitzgaze[3].GetComponent<Image>().fillAmount = 0;

                            blitz[4].GetComponent<Image>().sprite = nomalblitz;
                            blitzgaze[4].GetComponent<Image>().fillAmount = 0f;

                             break;

                        case 3:

                            blitz[0].GetComponent<Image>().sprite = fullblitz;
                            blitz[1].GetComponent<Image>().sprite = fullblitz;
                            blitz[2].GetComponent<Image>().sprite = fullblitz;

                            blitzgaze[3].GetComponent<Image>().fillAmount = pblitz;
                            blitz[3].GetComponent<Image>().sprite = nomalblitz;

                            blitz[4].GetComponent<Image>().sprite = nomalblitz;
                            blitzgaze[4].GetComponent<Image>().fillAmount = 0f;

                            break;



                        case 4:

                            blitz[0].GetComponent<Image>().sprite = fullblitz;
                            blitz[1].GetComponent<Image>().sprite = fullblitz;
                            blitz[2].GetComponent<Image>().sprite = fullblitz;
                            blitz[3].GetComponent<Image>().sprite = fullblitz;

                            blitz[4].GetComponent<Image>().sprite = nomalblitz;
                            blitzgaze[4].GetComponent<Image>().fillAmount = pblitz;

                            break;


                        case 5:

                            blitz[0].GetComponent<Image>().sprite = fullblitz;
                            blitz[1].GetComponent<Image>().sprite = fullblitz;
                            blitz[2].GetComponent<Image>().sprite = fullblitz;
                            blitz[3].GetComponent<Image>().sprite = fullblitz;
                            blitz[4].GetComponent<Image>().sprite = fullblitz;


                            break;


                    };
                }
                break;






        }; //현재 가지고있는 블리츠의 수량만큼 시작하는것.
    }

    // Update is called once per frame
    void Update()
    {


        if (!Player_status.isDead)
        {//게임의 상태가 진행 중일때만 실행 
            if (BlitzStart)
            {
                Blitzon();
                BlitzStart = false;
            }
            if (blitzcount >= 0)
            {
                if (blitzcount != Player_status.PS_blitz)//블리츠가 0보다 크고 최대량 보다 적을때 실행
                {
                    cooltime += Time.deltaTime;


                    if (cooltime >= 3) //3초이상 진행될시 게이지를 0.2씩 추가한다.
                    {


                        pblitz += 0.2f;
                        cooltime = 0;

                    }




                    if (pblitz == 1)//게이지가 가들 찰 시 블리츠 양을 하나 추가한다(약 15초 정도 걸림)
                    {
                        if (blitzcount != Player_status.PS_blitz)
                        {
                            blitzcount++;
                        }

                        pblitz = 0;
                    }


                    if (blitzcount == Player_status.PS_blitz) //만약 최대 블리츠가 된다면 쿨타임을 0으로 만든다.
                        cooltime = 0;

                }


            }

            Blitzcool();//블리츠 표시하는 함수 실행
        }

    }


}




