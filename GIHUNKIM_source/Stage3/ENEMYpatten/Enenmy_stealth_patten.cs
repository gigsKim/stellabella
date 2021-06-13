using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enenmy_stealth_patten : MonoBehaviour
{

    float time = 0;


    public GameObject st1;
    public GameObject st2;
    public GameObject st3;
    

    bool bullet_fire = true;
    bool bullet_fire2 = true;
    bool bullet_fire3 = true;

    int shottime = 0;
    float checktime = 0;

    void OnEnable()
    {
        shottime = 0;
        checktime = 0;
    }

    void OnDisable()
    {
        this.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        time = 0;
        shottime = 0;
        checktime = 0;

        bullet_fire = true;
        bullet_fire2 = true;
        bullet_fire3 = true;
    }

    void Update()
    {
        if (shottime >= 2)
        {
           
            checktime += Time.deltaTime;
            if (checktime >=3)
                gameObject.transform.Translate(-0.1f, 0.2f, 0);
        }

        if (shottime < 2)
        {
            if (time == 0)
            {
                this.GetComponent<Rigidbody2D>().AddForce(new Vector3(-200, 0, 0));
            }



            time += Time.deltaTime;

            if (time >= 1.2f)
            {
                this.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
            }



            if (time > 1.5)
            {

                if (bullet_fire)
                {


                    EnemyBulletManager.GetBullet(st1).GetComponent<Rigidbody2D>().AddForce(new Vector3(-1, 1, 0) * 300);
                    EnemyBulletManager.GetBullet(st1).GetComponent<Rigidbody2D>().AddForce(new Vector3(-1, -1, 0) * 300);
                    EnemyBulletManager.GetBullet(st1).GetComponent<Rigidbody2D>().AddForce(new Vector3(-1, 0, 0) * 300);
                    EnemyBulletManager.GetBullet(st1).GetComponent<Rigidbody2D>().AddForce(new Vector3(-1, 2, 0) * 300);
                    EnemyBulletManager.GetBullet(st1).GetComponent<Rigidbody2D>().AddForce(new Vector3(-1, -2, 0) * 300);
                    EnemyBulletManager.GetBullet(st1).GetComponent<Rigidbody2D>().AddForce(new Vector3(-1, -1.5f, 0) * 300);
                    EnemyBulletManager.GetBullet(st1).GetComponent<Rigidbody2D>().AddForce(new Vector3(-1, 1.5f, 0) * 300);
                    EnemyBulletManager.GetBullet(st1).GetComponent<Rigidbody2D>().AddForce(new Vector3(-1, 0.5f, 0) * 300);
                    EnemyBulletManager.GetBullet(st1).GetComponent<Rigidbody2D>().AddForce(new Vector3(-1, -0.5f, 0) * 300);




                    bullet_fire = false;
                }



            }

            if (time > 1.7)
            {

                if (bullet_fire2)
                {


                    EnemyBulletManager.GetBullet(st1).GetComponent<Rigidbody2D>().AddForce(new Vector3(-1, 1, 0) * 300);
                    EnemyBulletManager.GetBullet(st1).GetComponent<Rigidbody2D>().AddForce(new Vector3(-1, -1.5f, 0) * 300);
                    EnemyBulletManager.GetBullet(st1).GetComponent<Rigidbody2D>().AddForce(new Vector3(-1, 1.5f, 0) * 300);
                    EnemyBulletManager.GetBullet(st1).GetComponent<Rigidbody2D>().AddForce(new Vector3(-1, 0.5f, 0) * 300);
                    EnemyBulletManager.GetBullet(st1).GetComponent<Rigidbody2D>().AddForce(new Vector3(-1, -0.5f, 0) * 300);
                    EnemyBulletManager.GetBullet(st1).GetComponent<Rigidbody2D>().AddForce(new Vector3(-1, -1, 0) * 300);
                    EnemyBulletManager.GetBullet(st1).GetComponent<Rigidbody2D>().AddForce(new Vector3(-1, 0, 0) * 300);
                    EnemyBulletManager.GetBullet(st1).GetComponent<Rigidbody2D>().AddForce(new Vector3(-1, 2, 0) * 300);
                    EnemyBulletManager.GetBullet(st1).GetComponent<Rigidbody2D>().AddForce(new Vector3(-1, -2, 0) * 300);




                    bullet_fire2 = false;
                }



            }

            if (time > 1.9)
            {

                if (bullet_fire3)
                {


                    EnemyBulletManager.GetBullet(st1).GetComponent<Rigidbody2D>().AddForce(new Vector3(-1, 1, 0) * 300);
                    EnemyBulletManager.GetBullet(st1).GetComponent<Rigidbody2D>().AddForce(new Vector3(-1, -1, 0) * 300);
                    EnemyBulletManager.GetBullet(st1).GetComponent<Rigidbody2D>().AddForce(new Vector3(-1, 0, 0) * 300);
                    EnemyBulletManager.GetBullet(st1).GetComponent<Rigidbody2D>().AddForce(new Vector3(-1, 2, 0) * 300);
                    EnemyBulletManager.GetBullet(st1).GetComponent<Rigidbody2D>().AddForce(new Vector3(-1, -2, 0) * 300);
                    EnemyBulletManager.GetBullet(st1).GetComponent<Rigidbody2D>().AddForce(new Vector3(-1, -1.5f, 0) * 300);
                    EnemyBulletManager.GetBullet(st1).GetComponent<Rigidbody2D>().AddForce(new Vector3(-1, 1.5f, 0) * 300);
                    EnemyBulletManager.GetBullet(st1).GetComponent<Rigidbody2D>().AddForce(new Vector3(-1, 0.5f, 0) * 300);
                    EnemyBulletManager.GetBullet(st1).GetComponent<Rigidbody2D>().AddForce(new Vector3(-1, -0.5f, 0) * 300);




                    bullet_fire3 = false;
                }



            }







            if (time >= 2.3)
            {
                bullet_fire = true;
                bullet_fire2 = true;
                bullet_fire3 = true;
                shottime++;
                time = 0.1f;
            }

        }


       /* if (time > 1.7)
        {
            if (bullet_fire)
            {
                EnemyBulletManager.GetBullet(gameObject).GetComponent<Rigidbody2D>().AddForce(Vector3.left * bullet_speed);
                bullet_fire = false;
            }
        }
        if (time > 1.9)
        {

           // this.GetComponent<Rigidbody2D>().AddForce(new Vector3(0, 15, 0));
        }
        if (time > 2.5)
        {
            if (bullet_fire2)
            {
                EnemyBulletManager.GetBullet(gameObject).GetComponent<Rigidbody2D>().AddForce(Vector3.left * bullet_speed);
                bullet_fire2 = false;
            }
        }*/

    }
}
