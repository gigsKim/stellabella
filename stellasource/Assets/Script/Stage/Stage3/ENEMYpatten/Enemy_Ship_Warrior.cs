using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Ship_Warrior : MonoBehaviour
{

    //총알 달아줘야함
    public GameObject enemy_bullet;

    GameObject instance;
   public GameObject Firezone;
    float time = 0;

    int shottime = 0;
    bool bullet_fire = true;
    bool bullet_fire1 = true;
    bool bullet_fire2 = true;
    bool bullet_fire3 = true;
    bool bullet_fire4 = true;
    bool bullet_fire5 = true;
    bool bullet_fire6 = true;
    bool bullet_fire7 = true;
    bool bullet_fire8 = true;





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
        bullet_fire1 = true;
        bullet_fire2 = true;
        bullet_fire3 = true;
        bullet_fire4 = true;
        bullet_fire5 = true;
     
        shottime = 0;
    }

    private void Start()
    {
       
    }

    void Update()
    {
        
        time += Time.deltaTime;


        if(shottime >= 2)
        {
            gameObject.transform.Translate(-0.1f, 0.1f, 0);
        }

        if (time >= 1.2f)
        {
            //this.GetComponent<Rigidbody2D>().AddForce(new Vector3(-200, 0, 0));
            this.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        }


        if (time > 1.5)
        {
            if (bullet_fire)
            {
                EnemyBulletManager.GetBullet(Firezone).GetComponent<Rigidbody2D>().AddForce(new Vector3(-1, 0, 0) * 1300);
                bullet_fire = false;
            }
        }
        if (time > 1.6)
        {
            if (bullet_fire1)
            {
                EnemyBulletManager.GetBullet(Firezone).GetComponent<Rigidbody2D>().AddForce(new Vector3(-1, 0, 0) * 1300);
                bullet_fire1 = false;
            }
        }

        if (time > 1.7)
        {
            if (bullet_fire2)
            {
                EnemyBulletManager.GetBullet(Firezone).GetComponent<Rigidbody2D>().AddForce(new Vector3(-1, 0, 0) * 1300);
                bullet_fire2 = false;
            }
        }


        if (time > 3.5)
        {
            if (bullet_fire3)
            {
                EnemyBulletManager.GetBullet(Firezone).GetComponent<Rigidbody2D>().AddForce(new Vector3(-1, 0, 0) * 1300);
                bullet_fire3 = false;
            }
        }
        if (time > 3.6)
        {
            if (bullet_fire4)
            {
                EnemyBulletManager.GetBullet(Firezone).GetComponent<Rigidbody2D>().AddForce(new Vector3(-1, 0, 0) * 1300);
                bullet_fire4 = false;
            }
        }

        if (time > 3.7)
        {
            if (bullet_fire5)
            {
                EnemyBulletManager.GetBullet(Firezone).GetComponent<Rigidbody2D>().AddForce(new Vector3(-1, 0, 0) * 1300);
                bullet_fire5 = false;
            }
        }



    


        if(time >= 3.9)
        {

            time = 0;
             bullet_fire = true;
             bullet_fire1 = true;
             bullet_fire2 = true;
             bullet_fire3 = true;
             bullet_fire4 = true;
             bullet_fire5 = true;
            shottime++;
        }


    }
}
