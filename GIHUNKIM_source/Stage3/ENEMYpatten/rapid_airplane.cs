using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rapid_airplane : MonoBehaviour
{
    public GameObject enemy_bullet;
    public int bullet_speed = 600;


    GameObject instance;
    public GameObject player;
    float time = 0;
    bool bullet_fire = true;
    bool bullet_fire1 = true;
    bool bullet_fire2 = true;
    bool checkUpdate = false;


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
        this.gameObject.transform.Translate(0, 0, 0);
        checkUpdate = false;
        //this.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        time = 0;
        bullet_fire = true;
        bullet_fire1 = true;
        bullet_fire2 = true;
    }

    private void Update()
    {


        this.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(-10, (player.transform.position.y * 0.3f)) * 70);



        if (checkUpdate)
        {



            /* 
             * if (time == 0)
             {
                 this.GetComponent<Rigidbody2D>().AddForce(new Vector3(-750, player.transform.position.y, 0));
                 //시작할때 물체에게 왼쪽으로 힘을 준다.
             }
             * if (time > 1 && time < 1.1)
             {
                 this.GetComponent<Rigidbody2D>().AddForce(new Vector3(0, 5, 0));
                 //일정 시간후에 위로 계속 힘을 줌

             } */

            if (time > 0.3)
            {
                if (bullet_fire)
                {
                    //탄환 생성 및 발사
                    EnemyBulletManager.GetBullet(gameObject).GetComponent<Rigidbody2D>().AddForce(new Vector3(-700, 0, 0));
                    bullet_fire = false;
                }
            }

             if (time > 0.4)
            {
                if (bullet_fire1)
                {
                    //탄환 생성 및 발사
                    EnemyBulletManager.GetBullet(gameObject).GetComponent<Rigidbody2D>().AddForce(new Vector3(-700, 100, 0));
                    bullet_fire1 = false;
                }
            }

            if (time > 0.5)
            {
                if (bullet_fire2)
                {
                    //탄환 생성 및 발사
                    EnemyBulletManager.GetBullet(gameObject).GetComponent<Rigidbody2D>().AddForce(new Vector3(-700, -100, 0));
                    bullet_fire2 = false;
                }
            }


            if( time >= 0.6)
            {
                time = 0;
                bullet_fire = false;
                bullet_fire1 = false;
                bullet_fire2 = false;
            }

            time += Time.deltaTime;
        }
    }
}
