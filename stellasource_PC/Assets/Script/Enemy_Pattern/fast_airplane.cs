using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fast_airplane : MonoBehaviour
{
    public GameObject enemy_bullet;
    public int bullet_speed = 600;

    GameObject instance;
    float time = 0;
    bool bullet_fire = true;


    void OnEnable()
    {

    }

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
            if(transform.position.y < 0)
            this.GetComponent<Rigidbody2D>().AddForce(new Vector3(-300, 100, 0));

            if (transform.position.y >= 0)
                this.GetComponent<Rigidbody2D>().AddForce(new Vector3(-300, -100, 0));

        }
        time += Time.deltaTime;

        if (time > 0.7)
        {
            if (bullet_fire)
            {
                //적 탄환 생성및 발사
                EnemyBulletManager.GetBullet(gameObject).GetComponent<Rigidbody2D>().AddForce(Vector3.left * bullet_speed);
                bullet_fire = false;
            }
        }


        if(time >= 0.8f)
        {

            bullet_fire = true;
            time = 0.1f;
        }

    }
}
