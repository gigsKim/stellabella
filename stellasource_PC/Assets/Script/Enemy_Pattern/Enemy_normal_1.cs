using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_normal_1 : MonoBehaviour
{
    //총알 달아줘야함
    public GameObject enemy_bullet;
    public int bullet_speed =600;
    

    GameObject instance;
    float time=0;
    bool bullet_fire = true;
    bool checkUpdate = false;

    void OnEnable()
    {
        checkUpdate = true;
       
    }

    void OnDisable()
    {

        checkUpdate = false;
        this.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        time = 0;
        bullet_fire = true;
    }

    private void Update()
    {
        if (checkUpdate)
        {
            if (time == 0)
            {
                this.GetComponent<Rigidbody2D>().AddForce(new Vector3(-200, 0, 0));
                //시작할때 물체에게 왼쪽으로 힘을 준다.
            }
            time += Time.deltaTime;
            if (time > 1 && time < 1.1)
            {
                this.GetComponent<Rigidbody2D>().AddForce(new Vector3(0, 5, 0));
                //일정 시간후에 위로 계속 힘을 줌

            }
            else if (time > 1.5)
            {
                if (bullet_fire)
                {
                    //탄환 생성 및 발사
                    EnemyBulletManager.GetBullet(gameObject).GetComponent<Rigidbody2D>().AddForce(Vector3.left * bullet_speed);
                    bullet_fire = false;
                }
            }
        }
    }


}
