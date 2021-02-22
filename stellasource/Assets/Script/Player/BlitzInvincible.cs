using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BlitzInvincible : MonoBehaviour
{

    public BlitzManager Blitz;//블리츠의 양을 가져온다
    public GameObject Player;
    public GameObject life;// 체력바

    GameObject instance;
    public int blitz_used_count=0;
    public int blitz_count;
    bool blitz_invincible = false;//블리츠에 의한 무적인지 아닌지 표현
    bool invincible_check;//무적 상태 체크


    void Awake()
    {
        // youdie.SetActive(false);
        Blitz = GameObject.Find("manager").GetComponent<BlitzManager>();
        life = GameObject.Find("Life_fill");
        Player = GameObject.Find("Player_alpha_flyver");
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "MainCamera" || collision.tag == "Bullet_Player" || collision.tag == "Boom" || collision.tag == "WallForPattern") { }
        else
        {

            if (invincible_check == false)//무적 상태가 아닐시
            {

                invincible_check = true;
                blitz_used_count++;
                StartCoroutine("co"); //무적 코루틴을 실행시킨다.

                if (blitz_invincible == true)
                {
                    Blitz.blitzcount--; //체력대신 블리츠를 감소시킴
                }
                else
                {
                    if (collision.tag == "Enemy_bullet")
                    {

                        Player_status.PS_hp -= collision.gameObject.GetComponent<Enemy_Bullet>().damage;

                        //life.GetComponent<Image>().fillAmount = (float)Player_status.PS_hp / Player_status.PS_maxHp;
                        Debug.Log((float)Player_status.PS_hp / Player_status.PS_maxHp);

                    }
                    if (collision.tag == "Enemy_normal" || collision.tag == "Boss")
                    {

                        Player_status.PS_hp--;

                        //life.GetComponent<Image>().fillAmount = (float)Player_status.PS_hp / Player_status.PS_maxHp;
                        Debug.Log((float)Player_status.PS_hp / Player_status.PS_maxHp);

                    }
                }

            }
        }

    }

    IEnumerator co()
    {
        int counttime = 0;

        while (counttime < 10)
        {
            this.GetComponent<SpriteRenderer>().enabled = false;
            this.transform.GetChild(0).GetComponent<SpriteRenderer>().enabled = false;
            this.transform.GetChild(1).gameObject.SetActive(true);
            /*if (counttime % 2 == 0)
            {
                Player.GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 90);
            }
            else
            {
                Player.GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 180);

            }*/
            yield return new WaitForSeconds(0.2f);//0.2초동안 지연하면서 깜빡이는 시간을 줌


            counttime++;

        }

        Player.GetComponent<SpriteRenderer>().color = new Color(255, 255, 255, 255);//완료시 원래대로 되돌림



        invincible_check = false;//무적 종료
        this.GetComponent<SpriteRenderer>().enabled = true;
        this.transform.GetChild(0).GetComponent<SpriteRenderer>().enabled = true;
        this.transform.GetChild(1).gameObject.SetActive(false);

        yield return null;

    }


    void Update()
    {

        life.GetComponent<Image>().fillAmount = (float)Player_status.PS_hp / Player_status.PS_maxHp;

        if (!Player_status.isDead)
        {
            blitz_count = Blitz.blitzcount;

            if (blitz_count > 0)
            {
                blitz_invincible = true;
            }
            else
            {
                blitz_invincible = false;
            }



        }



        if (Player_status.PS_hp <= 0)
        {
            // youdie.SetActive(true);
            Player_status.isDead = true;
            ExplosionManager.GetExplosion(gameObject);
            Destroy(gameObject);
            SceneManager.LoadScene("GameOver");

            //채력이 0이될시 게임종료
        };
    }
}