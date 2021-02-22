using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_normal_4 : MonoBehaviour
{
    public int bullet_speed = 600;

    float time = 0;
    bool bullet_fire = true;
    bool bullet_fire2 = true;
    bool stop = true;


    void OnDisable()
    {
        this.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        time = 0;
        bullet_fire = true;
    }

    void Update()
    {
        if (time == 0)
        {
            this.GetComponent<Rigidbody2D>().AddForce(new Vector3(-300, 0, 0));
        }
        time += Time.deltaTime;
        if (time > 1.5)
        {
            if (stop)
            {
                this.GetComponent<Rigidbody2D>().AddForce(new Vector3(100, 0, 0));
                stop = false;
            }
            this.GetComponent<Rigidbody2D>().AddForce(new Vector3(0, -10, 0));
        }
        if (time > 1.7)
        {
            if (bullet_fire)
            {
                EnemyBulletManager.GetBullet(gameObject).GetComponent<Rigidbody2D>().AddForce(Vector3.left * bullet_speed);
                bullet_fire = false;
            }
        }
        if (time > 1.9)
        {

            this.GetComponent<Rigidbody2D>().AddForce(new Vector3(0, 15, 0));
        }
        if (time > 2.5)
        {
            if (bullet_fire2)
            {
                EnemyBulletManager.GetBullet(gameObject).GetComponent<Rigidbody2D>().AddForce(Vector3.left * bullet_speed);
                bullet_fire2 = false;
            }
        }

    }


}
