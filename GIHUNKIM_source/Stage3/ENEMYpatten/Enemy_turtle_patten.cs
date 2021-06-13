using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_turtle_patten : MonoBehaviour
{
    public GameObject shoot1;
    public GameObject shoot2;
    public GameObject shoot3;

    public float time = 0;
    bool bullet_fire = true;
    bool bullet_fire2 = true;
    bool bullet_fire3 = true;
    bool bullet_fire4 = true;
    bool bullet_fire5 = true;
    bool bullet_fire6 = true;




    void OnEnable()
    {
        time = 0;

    }

    void OnDisable()
    {
        this.GetComponent<Rigidbody2D>().velocity = Vector2.zero;

        bullet_fire = true;
        bullet_fire2 = true;
        bullet_fire3 = true;
        bullet_fire4 = true;
        bullet_fire5 = true;
        bullet_fire6 = true;
        time = 0;
    }

    void Update()
    {
        if (time == 0)
        {
            this.GetComponent<Rigidbody2D>().AddForce(new Vector3(-200, 0, 0));
        }
        time += Time.deltaTime;

        if (time > 1.5)
        {
            if (bullet_fire)
            {

                EnemyBulletManager.GetBullet(shoot1).GetComponent<Rigidbody2D>().AddForce(new Vector3(-1, 1, 0) * 300);
                EnemyBulletManager.GetBullet(shoot2).GetComponent<Rigidbody2D>().AddForce(new Vector3( 0, 1, 0) * 300);
                EnemyBulletManager.GetBullet(shoot1).GetComponent<Rigidbody2D>().AddForce(new Vector3(1, 1, 0) * 300);

                bullet_fire = false;
            }
        }
        if (time > 3.5)
        {
            if (bullet_fire2)
            {
                EnemyBulletManager.GetBullet(shoot1).GetComponent<Rigidbody2D>().AddForce(new Vector3(-1, 1, 0) * 300);
                EnemyBulletManager.GetBullet(shoot1).GetComponent<Rigidbody2D>().AddForce(new Vector3(0, 1, 0) * 300);
                EnemyBulletManager.GetBullet(shoot1).GetComponent<Rigidbody2D>().AddForce(new Vector3(1, 1, 0) * 300);
                bullet_fire2 = false;
            }
        }


        if (time > 5.5)
        {
            if (bullet_fire3)
            {
                EnemyBulletManager.GetBullet(shoot1).GetComponent<Rigidbody2D>().AddForce(new Vector3(-1, 1, 0) * 300);
                EnemyBulletManager.GetBullet(shoot1).GetComponent<Rigidbody2D>().AddForce(new Vector3(0, 1, 0) * 300);
                EnemyBulletManager.GetBullet(shoot1).GetComponent<Rigidbody2D>().AddForce(new Vector3(1, 1, 0) * 300);
                bullet_fire3 = false;
            }
        }
        if (time > 7.5)
        {
            if (bullet_fire4)
            {
                EnemyBulletManager.GetBullet(shoot1).GetComponent<Rigidbody2D>().AddForce(new Vector3(-1, 1, 0) * 300);
                EnemyBulletManager.GetBullet(shoot1).GetComponent<Rigidbody2D>().AddForce(new Vector3(0, 1, 0) * 300);
                EnemyBulletManager.GetBullet(shoot1).GetComponent<Rigidbody2D>().AddForce(new Vector3(1, 1, 0) * 300);
                bullet_fire4 = false;
            }
        }
        if (time > 8.5)
        {
            if (bullet_fire5)
            {
                EnemyBulletManager.GetBullet(shoot1).GetComponent<Rigidbody2D>().AddForce(new Vector3(-1, 1, 0) * 300);
                EnemyBulletManager.GetBullet(shoot1).GetComponent<Rigidbody2D>().AddForce(new Vector3(0, 1, 0) * 300);
                EnemyBulletManager.GetBullet(shoot1).GetComponent<Rigidbody2D>().AddForce(new Vector3(1, 1, 0) * 300);
                bullet_fire5 = false;
            }
        }
        if (time > 9.5)
        {
            if (bullet_fire6)
            {
                  EnemyBulletManager.GetBullet(shoot1).GetComponent<Rigidbody2D>().AddForce(new Vector3(-1, 1, 0) * 300);
                EnemyBulletManager.GetBullet(shoot1).GetComponent<Rigidbody2D>().AddForce(new Vector3( 0, 1, 0) * 300);
                EnemyBulletManager.GetBullet(shoot1).GetComponent<Rigidbody2D>().AddForce(new Vector3(1, 1, 0) * 300);
                bullet_fire6 = false;
            }
        }

        if(time >= 9.6)
        {

            time = 0.1f;
            bullet_fire = true;
            bullet_fire2 = true;
            bullet_fire3 = true;
            bullet_fire4 = true;
            bullet_fire5 = true;
            bullet_fire6 = true;
        }


    } 
}
