using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_normal_2 : MonoBehaviour
{
    //총알 달아줘야함
    public GameObject enemy_bullet;
    public int bullet_speed = 600;

    GameObject instance;
    float time = 0;
    bool bullet_fire = true;
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
        if (time > 1)
        {

            this.GetComponent<Rigidbody2D>().AddForce(new Vector3(0, -3, 0));
        }
        if (time > 2)
        {
            if (bullet_fire)
            {
                //적 탄환 생성및 발사
                EnemyBulletManager.GetBullet(gameObject).GetComponent<Rigidbody2D>().AddForce(Vector3.left * bullet_speed);
                bullet_fire = false;
            }
        }

    }


}
