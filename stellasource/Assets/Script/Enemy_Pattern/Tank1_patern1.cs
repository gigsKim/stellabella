using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tank1_patern1 : MonoBehaviour
{

    float time = 0;
    bool bullet_fire = true;
    bool bullet_fire2 = true;
    bool bullet_fire3 = true;
    bool bullet_fire4 = true;
    bool bullet_fire5 = true;
    bool bullet_fire6 = true;

    void OnDisable()
    {
        this.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
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

                EnemyBulletManager.GetBullet(gameObject).GetComponent<Rigidbody2D>().AddForce(new Vector3(-1,1,0) * 500) ;
                bullet_fire = false;
            }
        }
        if (time > 1.7)
        {
            if (bullet_fire2)
            {
                EnemyBulletManager.GetBullet(gameObject).GetComponent<Rigidbody2D>().AddForce(new Vector3(-1, 1, 0) * 500);
                bullet_fire2 = false;
            }
        }
        if (time > 2.5)
        {
            if (bullet_fire3)
            {
                EnemyBulletManager.GetBullet(gameObject).GetComponent<Rigidbody2D>().AddForce(new Vector3(-1, 1, 0) * 500);
                bullet_fire3 = false;
            }
        }
        if (time > 2.7)
        {
            if (bullet_fire4)
            {
                EnemyBulletManager.GetBullet(gameObject).GetComponent<Rigidbody2D>().AddForce(new Vector3(-1, 1, 0) * 500);
                bullet_fire4 = false;
            }
        }
        if (time > 3.5)
        {
            if (bullet_fire5)
            {
                EnemyBulletManager.GetBullet(gameObject).GetComponent<Rigidbody2D>().AddForce(new Vector3(-1, 1, 0) * 500);
                bullet_fire5 = false;
            }
        }
        if (time > 3.7)
        {
            if (bullet_fire6)
            {
                EnemyBulletManager.GetBullet(gameObject).GetComponent<Rigidbody2D>().AddForce(new Vector3(-1, 1, 0) * 500);
                bullet_fire6 = false;
            }
        }
    }


}
