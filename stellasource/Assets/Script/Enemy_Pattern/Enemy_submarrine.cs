using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_submarrine : MonoBehaviour
{
    public GameObject enemy_bullet;
    public int bullet_speed = 600;


    GameObject instance;
    float time = 0;

    bool bullet_fire = true;
    bool bullet_fire1 = true;
    bool bullet_fire2 = true;


    bool moveon = false;

    public GameObject player;
    
    bool checkUpdate = false;

    bool stopdown = false;

    private void Start()
    {
        player = GameObject.Find("Player_alpha_flyver");
    }
    void OnEnable()
    {
        checkUpdate = true;
        
    }

    void OnDisable()
    {
        checkUpdate = false;
        this.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        bullet_fire = true;
        bullet_fire1 = true;
        bullet_fire2 = true;
        moveon = false;
        stopdown = false;
        time = 0;
    }

    private void FixedUpdate()
    {

       
        if (stopdown == false)
        {
            if (this.transform.position.y > -3.7)
            {

                transform.Translate(-0.1f, -0.1f, 0);
                /*.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
                this.GetComponent<Rigidbody2D>().AddForce(new Vector3(-100, 0, 0));
                stopdown = true;*/
            }

            else
            {
                transform.Translate(-0.1f, 0, 0);
            }

        }
    }

    private void Update()
    {
        if (checkUpdate)
        {
            
            if (time == 0)
            {
                // this.GetComponent<Rigidbody2D>().AddForce(new Vector3(-150, 0, 0));
                //transform.Translate(0, -1, 0);

                //시작할때 물체에게 왼쪽으로 힘을 준다.
            }
            time += Time.deltaTime;

            if (time > 0.3 && moveon ==false)
            {

                
                    //this.GetComponent<Rigidbody2D>().AddForce(new Vector3(0, -200, 0));
                     moveon = true;

                //일정 시간후에 위로 계속 힘을 줌



            }
            if (time > 0.5)
            {
                if (bullet_fire)
                {
                    //탄환 생성 및 발사
                    if (player.transform.position.x < 0)
                    {
                        EnemyBulletManager.GetBullet(gameObject).GetComponent<Rigidbody2D>().AddForce(new Vector2(-10, (5)) * 70);
                    }

                   
                    if (player.transform.position.x  > 0)
                    {
                        EnemyBulletManager.GetBullet(gameObject).GetComponent<Rigidbody2D>().AddForce(new Vector2(10, (5)) * 70);
                    }

                    bullet_fire = false;
                }
            }

            if(time > 0.7)
            {
                if (bullet_fire1)
                {
                    if (player.transform.position.x <= 0)
                    {
                        EnemyBulletManager.GetBullet(gameObject).GetComponent<Rigidbody2D>().AddForce(new Vector2(-10, (5)) * 70);
                    }
                  
                    if (player.transform.position.x > 0)
                    {
                        EnemyBulletManager.GetBullet(gameObject).GetComponent<Rigidbody2D>().AddForce(new Vector2(10, (5)) * 70);
                    }

                    bullet_fire1 = false;
                }
            }
        
            if (time > 0.9)
            {
                if (bullet_fire2)
                {
                    if (player.transform.position.x <= 0)
                    {
                        EnemyBulletManager.GetBullet(gameObject).GetComponent<Rigidbody2D>().AddForce(new Vector2(-10, (5)) * 70);
                    }
                    if (player.transform.position.x > 0)
                    {
                        EnemyBulletManager.GetBullet(gameObject).GetComponent<Rigidbody2D>().AddForce(new Vector2(10, (5)) * 70);
                    }
                    bullet_fire2 = false;
                }
            }





            if(time >=1.2)
            {

                bullet_fire = true;
                bullet_fire1 = true;
                bullet_fire2 = true;
                
              

                time = 0;

            }


        }
    }
}
