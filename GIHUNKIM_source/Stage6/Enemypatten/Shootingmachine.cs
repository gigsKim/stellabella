using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shootingmachine : MonoBehaviour
{

    float time = 0;

    bool bullet_fire = true;
    bool bullet_fire2 = true;
    bool checkUpdate = false;

    void OnEnable()
    {
        this.GetComponent<Rigidbody2D>().AddForce(new Vector3(-300, 0, 0));
        checkUpdate = true;

    }

    void OnDisable()
    {
        
        checkUpdate = false;
        this.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        time = 0;
        bullet_fire = true;
        bullet_fire2 = true;
    }

    private void Update()
    {
        

        //this.gameObject.transform.Translate(-0.1f, 0, 0);

        if (checkUpdate)
        {
           
            time += Time.deltaTime;
            if(time == 0)
            {
                this.GetComponent<Rigidbody2D>().velocity = Vector2.zero;

            }


            if (time > 1)
            {
                if (bullet_fire)
                {

                    if (this.transform.position.y >= 0  && this.transform.position.x >= 0)
                    {
                        EnemyBulletManager.GetBullet(gameObject).GetComponent<Rigidbody2D>().AddForce(new Vector3(-600, 0, 0));
                        EnemyBulletManager.GetBullet(gameObject).GetComponent<Rigidbody2D>().AddForce(new Vector3(-600, -100, 0));
                        EnemyBulletManager.GetBullet(gameObject).GetComponent<Rigidbody2D>().AddForce(new Vector3(-600, -200, 0));
                        EnemyBulletManager.GetBullet(gameObject).GetComponent<Rigidbody2D>().AddForce(new Vector3(-600, -300, 0));

                    }

                    if (this.transform.position.y >= 0 && this.transform.position.x < 0)
                    {
                        EnemyBulletManager.GetBullet(gameObject).GetComponent<Rigidbody2D>().AddForce(new Vector3(600, 0, 0));
                        EnemyBulletManager.GetBullet(gameObject).GetComponent<Rigidbody2D>().AddForce(new Vector3(600, -100, 0));
                        EnemyBulletManager.GetBullet(gameObject).GetComponent<Rigidbody2D>().AddForce(new Vector3(600, -200, 0));
                        EnemyBulletManager.GetBullet(gameObject).GetComponent<Rigidbody2D>().AddForce(new Vector3(600, -300, 0));

                    }



                    if (this.transform.position.y < 0 && this.transform.position.x >= 0)
                    {
                        EnemyBulletManager.GetBullet(gameObject).GetComponent<Rigidbody2D>().AddForce(new Vector3(-600, 0, 0));
                        EnemyBulletManager.GetBullet(gameObject).GetComponent<Rigidbody2D>().AddForce(new Vector3(-600, 100, 0));
                        EnemyBulletManager.GetBullet(gameObject).GetComponent<Rigidbody2D>().AddForce(new Vector3(-600, 200, 0));
                        EnemyBulletManager.GetBullet(gameObject).GetComponent<Rigidbody2D>().AddForce(new Vector3(-600, 300, 0));
                    }

                    if (this.transform.position.y < 0 && this.transform.position.x < 0)
                    {
                        EnemyBulletManager.GetBullet(gameObject).GetComponent<Rigidbody2D>().AddForce(new Vector3(600, 0, 0));
                        EnemyBulletManager.GetBullet(gameObject).GetComponent<Rigidbody2D>().AddForce(new Vector3(600, 100, 0));
                        EnemyBulletManager.GetBullet(gameObject).GetComponent<Rigidbody2D>().AddForce(new Vector3(600, 200, 0));
                        EnemyBulletManager.GetBullet(gameObject).GetComponent<Rigidbody2D>().AddForce(new Vector3(600, 300, 0));

                    }


                    bullet_fire = false;
                }
            }



            if(time > 2)
           {

               if (bullet_fire2)
               {
                    //탄환 생성 및 발사

                    if (this.transform.position.y >= 0 && this.transform.position.x >= 0)
                    {
                        EnemyBulletManager.GetBullet(gameObject).GetComponent<Rigidbody2D>().AddForce(new Vector3(-600, 0, 0));
                        EnemyBulletManager.GetBullet(gameObject).GetComponent<Rigidbody2D>().AddForce(new Vector3(-600, -100, 0));
                        EnemyBulletManager.GetBullet(gameObject).GetComponent<Rigidbody2D>().AddForce(new Vector3(-600, -200, 0));
                        EnemyBulletManager.GetBullet(gameObject).GetComponent<Rigidbody2D>().AddForce(new Vector3(-600, -300, 0));

                    }

                    if (this.transform.position.y >= 0 && this.transform.position.x < 0)
                    {
                        EnemyBulletManager.GetBullet(gameObject).GetComponent<Rigidbody2D>().AddForce(new Vector3(600, 0, 0));
                        EnemyBulletManager.GetBullet(gameObject).GetComponent<Rigidbody2D>().AddForce(new Vector3(600, -100, 0));
                        EnemyBulletManager.GetBullet(gameObject).GetComponent<Rigidbody2D>().AddForce(new Vector3(600, -200, 0));
                        EnemyBulletManager.GetBullet(gameObject).GetComponent<Rigidbody2D>().AddForce(new Vector3(600, -300, 0));

                    }



                    if (this.transform.position.y < 0 && this.transform.position.x >= 0)
                    {
                        EnemyBulletManager.GetBullet(gameObject).GetComponent<Rigidbody2D>().AddForce(new Vector3(-600, 0, 0));
                        EnemyBulletManager.GetBullet(gameObject).GetComponent<Rigidbody2D>().AddForce(new Vector3(-600, 100, 0));
                        EnemyBulletManager.GetBullet(gameObject).GetComponent<Rigidbody2D>().AddForce(new Vector3(-600, 200, 0));
                        EnemyBulletManager.GetBullet(gameObject).GetComponent<Rigidbody2D>().AddForce(new Vector3(-600, 300, 0));
                    }

                    if (this.transform.position.y < 0 && this.transform.position.x < 0)
                    {
                        EnemyBulletManager.GetBullet(gameObject).GetComponent<Rigidbody2D>().AddForce(new Vector3(600, 0, 0));
                        EnemyBulletManager.GetBullet(gameObject).GetComponent<Rigidbody2D>().AddForce(new Vector3(600, 100, 0));
                        EnemyBulletManager.GetBullet(gameObject).GetComponent<Rigidbody2D>().AddForce(new Vector3(600, 200, 0));
                        EnemyBulletManager.GetBullet(gameObject).GetComponent<Rigidbody2D>().AddForce(new Vector3(600, 300, 0));

                    }



                    bullet_fire2 = false;
               }


           }


            if (time >= 2.1f)
            {

                time = 0;
                bullet_fire = true;
                bullet_fire2 = true;


            }


        }
    }

}
