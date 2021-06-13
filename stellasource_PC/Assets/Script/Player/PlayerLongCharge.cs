using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerLongCharge : MonoBehaviour, IPointerClickHandler
{
    public GameObject playercharge;
    public GameObject lazer;
    public BlitzManager blitzManager;
    public bool player_fired_check = false;//Player_shoot에서 참조
    public Player_AutoShoot player_AutoShoot;

    bool ischarge = false;
    bool ischargeon = false;
    public bool lazerActivate = false;
    private bool charging = false;

    private Touch tempTouchs;


    int chargershottime = 0;
    int chargerontime = 0;


    private Vector3 touchedPos;

    public void Start()
    {
        player_AutoShoot = GameObject.Find("Player_alpha_flyver").GetComponent<Player_AutoShoot>();
        blitzManager = GameObject.Find("manager").GetComponent<BlitzManager>();
        playercharge = GameObject.Find("playercharge");
        lazer = GameObject.Find("lazer");
        lazer.SetActive(false);
        playercharge.GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 0);
    }
    public void FixedUpdate()
    {
        if (ischargeon)
        {
            if (!charging)
            {
                playercharge.GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 0);
                StartCoroutine("chargeshoot");
                charging = true;
            }
            
        }
    }
    public void OnPointerClick(PointerEventData ped)
    {
       /* if (EventSystem.current.IsPointerOverGameObject() == false)
        {*/
            if (ischargeon == false && lazerActivate == false &&blitzManager.blitzcount>0&&ischarge==false)
            {
            ischarge = true;
            blitzManager.blitzcount--;
                StartCoroutine("charge");
                 player_AutoShoot.canshoot = false;
               

            }
       
        /*}*/

        // throw new System.NotImplementedException();
    }


    /*public void OnPointerUp(PointerEventData ped)
    {
        //player_fired_check = false;

        if (ischargeon == true)
        {
            if (blitzManager.blitzcount >= 1)
            {
                
                chargerontime = 0;
               
                ischargeon = false;

            }
            else
            {
                Debug.Log("블리츠 부족!");
                ischarge = false;
                ischargeon = false;
                ccolor = false;
                chargerontime = 0;
            }
        }


        else if (ischargeon == false && lazerActivate == false)
        {
            Debug.Log("일반 샷 발사!");
            ischarge = false;
            ccolor = false;

        }



        // throw new System.NotImplementedException();
    }*/




    IEnumerator chargeshoot()
    {
        chargershottime = 0;//차지하는데 걸리는 시간
        chargerontime = 0;
        lazerActivate = true;
    

        lazer.SetActive(true);


        while (chargershottime < 10)
        {
            chargerontime = 0;
            yield return new WaitForSeconds(0.2f);

            Debug.Log("차지 샷 발사 중");

            chargershottime++;

        }


        if (chargershottime >= 10)
        {

            Debug.Log("차지샷 발사 완료");
            lazer.SetActive(false);
            Debug.Log(lazer);
            lazerActivate = false;
            ischarge = false;

            chargerontime = 0;
            chargershottime = 0;
            player_AutoShoot.canshoot = true;
            ischargeon = false;
            charging = false;
            yield return null;

        }//차지가 완려됬다고 함

    }


    IEnumerator charge()
    {
        if (blitzManager.blitzcount >= 0)
        {
            chargerontime = 0;//차지하는데 걸리는 시간

            while (chargerontime < 15)
            {

                if (chargerontime >= 10)
                {

                    if (chargerontime % 2 == 0)
                        playercharge.GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 255);
                    else
                        playercharge.GetComponent<SpriteRenderer>().color = new Color32(255, 255, 90, 255);//배경이 노란색이 됫다가 안햇다가함

                }

                yield return new WaitForSeconds(0.2f);

                Debug.Log("차지중");

               /* if (ischarge == false)
                {
                    chargerontime = 0;
                    break;

                }//만약 차지중에 손을때면 취소시킴*/

                chargerontime++;

            }

            if (chargerontime >= 15)
            {
                Debug.Log("차지완료");
                ischargeon = true;
                chargerontime = 0;
                yield return null;
            }//차지가 완려됬다고 함

          
        }
      
    }

  /*  public void Update()
    {
        if (!Player_status.isDead)
        {
            if (ischarge)
            {
                StartCoroutine("charge");

            }

            playercharge.GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 0);

            if (ccolor == true)
                playercharge.GetComponent<SpriteRenderer>().color = new Color32(255, 255, 100, 255);


            if (ischargeon == true)
                player_fired_check = false;

        }
    }*/
}
