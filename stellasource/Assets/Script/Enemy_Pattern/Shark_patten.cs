using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shark_patten : MonoBehaviour
{

    float time = 0;


    public GameObject player;

    public GameObject sm1;
    public GameObject sm2;
    public GameObject sm3;


    public GameObject ss1;
    public GameObject ss2;
    public GameObject ss3;
    public GameObject ss4;
    public GameObject ss5;
    public GameObject ss6;



    bool bullet_fire = true;
    bool bullet_fire2 = true;
    bool bullet_fire3 = true;
    bool bullet_fire4 = true;
    bool bullet_fire5 = true;
    bool bullet_fire6 = true;


    bool shottingmode = false;
    bool moveon = false;
    bool firstmove = false;
    int movein = 0;
    int shootime =0;


    private void Start()
    {
        player = GameObject.Find("Player_alpha_flyver");
    }

    void OnDisable()
    {
        this.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        time = 0;
        movein = 0;



        shootime = 0;
        bullet_fire = true;
        bullet_fire2 = true;
        bullet_fire3 = true;
        bullet_fire4 = true;
        bullet_fire5 = true;
        bullet_fire6 = true;
        moveon = false;
        shottingmode = false;
        firstmove = false;

    }

    

    void Update()
    {
        time += Time.deltaTime;

      


        if(shootime >=2)
        {
            this.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
            bullet_fire = false;
            moveon = true;
            transform.Translate(- 0.3f, 0, 0);
        }




        if (shottingmode == false)
        {
            if (time >= 0 &&firstmove == false)
            {
                this.GetComponent<Rigidbody2D>().AddForce(new Vector3(-250, 0, 0));
                //gameObject.transform.Translate(-1, 0, 0);
                firstmove = true;
            }
            



            if (time >= 1.2f)
            {
                this.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
                shottingmode = true;
            }

        }


        if (shottingmode == true)
        {

            if (time > 2.0f)
            {
               
                if (bullet_fire)
                {

                   
                        EnemyBulletManager.GetBullet(sm1).GetComponent<Rigidbody2D>().AddForce(new Vector2(-1, 0) * 700);
                        EnemyBulletManager.GetBullet(ss2).GetComponent<Rigidbody2D>().AddForce(new Vector2(player.transform.position.x, (2)) * 70);
                        EnemyBulletManager.GetBullet(ss5).GetComponent<Rigidbody2D>().AddForce(new Vector2(player.transform.position.x, (-2)) * 70);
                        bullet_fire = false;
                    

                  
                }



            }

            if(time >= 2.0f)
            {
                if (moveon == false)
                {
                    if (movein == 0 )
                    {

                        this.GetComponent<Rigidbody2D>().AddForce(new Vector3(0, -100, 0));
                        

                       
                        moveon = true;
                        
                        movein = 1;

                        

                    }

                    else
                    {
                        this.GetComponent<Rigidbody2D>().AddForce(new Vector3(0, 120, 0));
                       

                        moveon = true;
                        movein = 0;
                    }
                }
            }

            if(time >= 3.4f)
            {
                if (bullet_fire2)
                {


                    EnemyBulletManager.GetBullet(ss1).GetComponent<Rigidbody2D>().AddForce(new Vector3(-1, 0, 0) * 300);
                    EnemyBulletManager.GetBullet(ss2).GetComponent<Rigidbody2D>().AddForce(new Vector3(-1, 0.3f, 0) * 300);
                    EnemyBulletManager.GetBullet(ss3).GetComponent<Rigidbody2D>().AddForce(new Vector3(-1, 0.7f, 0) * 300);

                    EnemyBulletManager.GetBullet(ss4).GetComponent<Rigidbody2D>().AddForce(new Vector3(-1, 0, 0) * 300);
                    EnemyBulletManager.GetBullet(ss5).GetComponent<Rigidbody2D>().AddForce(new Vector3(-1, -0.3f, 0) * 300);
                    EnemyBulletManager.GetBullet(ss6).GetComponent<Rigidbody2D>().AddForce(new Vector3(-1, -0.7f, 0) * 300);

                    bullet_fire2 = false;
                }

            }


            if (time >= 3.9f)
            {
                if (bullet_fire3)
                {



                    EnemyBulletManager.GetBullet(ss1).GetComponent<Rigidbody2D>().AddForce(new Vector3(-1, 0, 0) * 300);
                    EnemyBulletManager.GetBullet(ss2).GetComponent<Rigidbody2D>().AddForce(new Vector3(-1, 0.3f, 0) * 300);
                    EnemyBulletManager.GetBullet(ss3).GetComponent<Rigidbody2D>().AddForce(new Vector3(-1, 0.7f, 0) * 300);

                    EnemyBulletManager.GetBullet(ss4).GetComponent<Rigidbody2D>().AddForce(new Vector3(-1, 0, 0) * 300);
                    EnemyBulletManager.GetBullet(ss5).GetComponent<Rigidbody2D>().AddForce(new Vector3(-1, -0.3f, 0) * 300);
                    EnemyBulletManager.GetBullet(ss6).GetComponent<Rigidbody2D>().AddForce(new Vector3(-1, -0.7f, 0) * 300);
                    bullet_fire3 = false;
                }

            }



            if (time >= 4.4f)
            {
                if (bullet_fire4)
                {



                    EnemyBulletManager.GetBullet(ss1).GetComponent<Rigidbody2D>().AddForce(new Vector3(-1, 0, 0) * 300);
                    EnemyBulletManager.GetBullet(ss2).GetComponent<Rigidbody2D>().AddForce(new Vector3(-1, 0.3f, 0) * 300);
                    EnemyBulletManager.GetBullet(ss3).GetComponent<Rigidbody2D>().AddForce(new Vector3(-1, 0.7f, 0) * 300);

                    EnemyBulletManager.GetBullet(ss4).GetComponent<Rigidbody2D>().AddForce(new Vector3(-1, 0, 0) * 300);
                    EnemyBulletManager.GetBullet(ss5).GetComponent<Rigidbody2D>().AddForce(new Vector3(-1, -0.3f, 0) * 300);
                    EnemyBulletManager.GetBullet(ss6).GetComponent<Rigidbody2D>().AddForce(new Vector3(-1, -0.7f, 0) * 300);

                    bullet_fire4 = false;
                }

            }



            if (time >= 4.9f)
            {
                if (bullet_fire5)
                {



                    EnemyBulletManager.GetBullet(ss1).GetComponent<Rigidbody2D>().AddForce(new Vector3(-1, 0, 0) * 300);
                    EnemyBulletManager.GetBullet(ss2).GetComponent<Rigidbody2D>().AddForce(new Vector3(-1, 0.3f, 0) * 300);
                    EnemyBulletManager.GetBullet(ss3).GetComponent<Rigidbody2D>().AddForce(new Vector3(-1, 0.7f, 0) * 300);

                    EnemyBulletManager.GetBullet(ss4).GetComponent<Rigidbody2D>().AddForce(new Vector3(-1, 0, 0) * 300);
                    EnemyBulletManager.GetBullet(ss5).GetComponent<Rigidbody2D>().AddForce(new Vector3(-1, -0.3f, 0) * 300);
                    EnemyBulletManager.GetBullet(ss6).GetComponent<Rigidbody2D>().AddForce(new Vector3(-1, -0.7f, 0) * 300);

                    bullet_fire5 = false;
                }

            }


            if(time >= 5.1f)
            {
                this.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
                bullet_fire = true;
                bullet_fire2 = true;
                bullet_fire3 = true;
                bullet_fire4 = true;
                bullet_fire5 = true;
                time = 0.5f;
                moveon = false;
                shootime++;

            }


        }

    }
}


