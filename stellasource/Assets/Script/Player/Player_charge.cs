using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Player_charge : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public GameObject playercharge;
    public GameObject lazer;
    public BlitzManager blitzManager;
    public bool player_fired_check = false;//Player_shoot에서 참조

    bool ischarge = false;
    bool ischargeon = false;
    bool doublecharge = false;

    bool ccolor = false;
    public bool lazerActivate = false;

    private Touch tempTouchs;


    int chargershottime = 0;
    int chargerontime = 0;



    float time = 0;


    private Vector3 touchedPos;

    public void Start()
    {
        blitzManager = GameObject.Find("manager").GetComponent<BlitzManager>();
        playercharge = GameObject.Find("playercharge");
        lazer = GameObject.Find("lazer");
        lazer.SetActive(false);
    }

    public void OnPointerDown(PointerEventData ped)
    {
        
            if (ischargeon == false && lazerActivate == false)
            {
                player_fired_check = true;
                ischarge = true;

            }




        if (ischarge == true && lazerActivate == false)
        {
            player_fired_check = true;
            chargerontime = 0;
            ischarge = false;
            doublecharge = true;

        }

        if(doublecharge)
        {

        }




        // throw new System.NotImplementedException();
    }


    public void OnPointerUp(PointerEventData ped)
    {
        //player_fired_check = false;

        if (ischargeon == true)
        {
            if (blitzManager.blitzcount >= 1)
            {
                blitzManager.blitzcount--;
                chargerontime = 0;
                StartCoroutine("chargeshoot");
                ischargeon = false;

            }
              else 
            {
                
                ischarge = false;
                ischargeon = false;
                ccolor = false;
                chargerontime = 0;
            }
        }


       if (ischargeon==false && lazerActivate == false)
        {
            
            ischarge = false;
            ccolor = false;
            doublecharge = false;

        }

        if(ischarge == true && ischargeon == false )
        {
            ischarge = false;
            chargerontime = 0;
            doublecharge = false;

        }



        // throw new System.NotImplementedException();
    }




    IEnumerator chargeshoot()
    {
        chargershottime = 0;//차지하는데 걸리는 시간
        chargerontime = 0;
        lazerActivate = true;
        ccolor = false;

        lazer.SetActive(true);


        while (chargershottime < 10)
        {
            chargerontime = 0;
            yield return new WaitForSeconds(0.2f);

            

            chargershottime++;

        }


        if (chargershottime >= 10)
        {
            
            
            lazer.SetActive(false);
            Debug.Log(lazer);
            lazerActivate = false;

            chargerontime = 0;
            chargershottime = 0;
            yield return null;

        }//차지가 완려됬다고 함

    }


    IEnumerator charge()
    {
        if (blitzManager.blitzcount > 0)
        {
            chargerontime = 0;//차지하는데 걸리는 시간

            while (chargerontime < 15&& ischarge == true)
            {

                if (chargerontime >= 10)
                {

                    if (chargerontime % 2 == 0)
                        playercharge.GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 255);
                    else
                        playercharge.GetComponent<SpriteRenderer>().color = new Color32(255, 255, 90, 255);//배경이 노란색이 됫다가 안햇다가함

                }

                yield return new WaitForSeconds(0.2f);

                

                if (ischarge == false)
                {
                    chargerontime = 0;
                    break;

                }//만약 차지중에 손을때면 취소시킴

                if(ischarge == true)
                chargerontime++;

            }

            if (chargerontime >= 15)
            {
                
                ischarge = false;
                ischargeon = true;

                ccolor = true;
                yield return null;

            }//차지가 완려됬다고 함

            if (ischarge == false)
            {
                chargerontime = 0;
                yield return null;

            }
        }
    }

    public void FixedUpdate()
    {
        if (!Player_status.isDead)
        {
            if (ischarge)
            {
                chargerontime = 0;
                StartCoroutine("charge");

            }

            if(!ischarge)
            {
                chargerontime = 0;
            }


            if (!doublecharge)
            {
                time = 0;
            }

                if (doublecharge)
                {
                chargerontime = 0;
                time += Time.deltaTime;

                if(time > 0.3f)
                {
                    ischarge = true;
                   
                    doublecharge = false;
                }

                }

            playercharge.GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 0);

            if (ccolor == true)
                playercharge.GetComponent<SpriteRenderer>().color = new Color32(255, 255, 100, 255);


            if (ischargeon == true)
                player_fired_check = false;

        }
    }


}



