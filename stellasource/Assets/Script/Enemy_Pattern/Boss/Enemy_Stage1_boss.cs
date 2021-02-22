using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Stage1_boss : MonoBehaviour
{
    
    public GameObject enemy_bullet;
    GameObject instanse;
    float time = 0;
    bool bullet_fire = true;
    bool stop = true;
    GameObject enemy_bullet2;

    public float bullet_y_max = 10;
    public float bullet_term = 5;
    public float bullet_speed = 100;

    int bulet_limit = 0;
    int bulet_limit_time = 0;

    float x1;
    float x2;
    float x3;
    float x4;

    float y1;
    float y2;
    float y3;
    float y4;
    int z = 1;

    int bullet_time = 0;

    // Start is called before the first frame update
    void Start()
    {
        y1 = 0;
        y2 = bullet_y_max;
        y3 = 0;
        y4 = -bullet_y_max;

        this.GetComponent<Rigidbody2D>().AddForce(new Vector3(-200, 0, 0));
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        bullet_time++;
        
        if (time > 2.0)
        {
            if (stop)
            {
                this.GetComponent<Rigidbody2D>().AddForce(new Vector3(200, 0, 0));
                stop = false;
            }

        }
        if (time > 2.3)
        {
            if (bullet_time > 20)
            {
                if (bulet_limit < 5)
                {
                    bullet_fire = true;
                    bullet_time = 0;
                    bulet_limit++;
                }
                else {
                    if (bulet_limit_time < 5)
                    {
                        bulet_limit_time++;
                    }
                    else
                    {
                        bulet_limit_time = 0;
                        bulet_limit = 0;
                    }
                }
            }
            if (bullet_fire)
            {
                if (z == 1)
                {
                    x1 = bullet_y_max - y1;
                    BossBullet.GetBossBullet(gameObject).GetComponent<Rigidbody2D>().AddForce(new Vector3(x1, y1, 0) * bullet_speed);
                    y1 = y1 + bullet_term;
                    bullet_fire = false;

                    x2 = y2 - bullet_y_max;
                    BossBullet.GetBossBullet(gameObject).GetComponent<Rigidbody2D>().AddForce(new Vector3(x2, y2, 0) * bullet_speed);
                    y2 = y2 - bullet_term;
                    bullet_fire = false;

                    x3 = -bullet_y_max - y3;
                    BossBullet.GetBossBullet(gameObject).GetComponent<Rigidbody2D>().AddForce(new Vector3(x3, y3, 0) * bullet_speed);
                    y3 = y3 - bullet_term;
                    bullet_fire = false;

                    x4 = bullet_y_max + y4;
                    BossBullet.GetBossBullet(gameObject).GetComponent<Rigidbody2D>().AddForce(new Vector3(x4, y4, 0) * bullet_speed);
                    y4 = y4 + bullet_term;
                    bullet_fire = false;


                    if (y1 > bullet_y_max)
                    {
                        z = 2;
                        y1 = bullet_y_max;
                        y2 = 0;
                        y3 = -bullet_y_max;
                        y4 = 0;

                    }

                }
                else if (z == 2)
                {
                    x4 = bullet_y_max - y4;
                    BossBullet.GetBossBullet(gameObject).GetComponent<Rigidbody2D>().AddForce(new Vector3(x4, y4, 0) * bullet_speed);
                    y4 = y4 + bullet_term;
                    bullet_fire = false;

                    x1 = y1 - bullet_y_max;
                    BossBullet.GetBossBullet(gameObject).GetComponent<Rigidbody2D>().AddForce(new Vector3(x1, y1, 0) * bullet_speed);
                    y1 = y1 - bullet_term;
                    bullet_fire = false;

                    x2 = -bullet_y_max - y2;
                    BossBullet.GetBossBullet(gameObject).GetComponent<Rigidbody2D>().AddForce(new Vector3(x2, y2, 0) * bullet_speed);
                    y2 = y2 - bullet_term;
                    bullet_fire = false;

                    x3 = bullet_y_max + y3;
                    BossBullet.GetBossBullet(gameObject).GetComponent<Rigidbody2D>().AddForce(new Vector3(x3, y3, 0) * bullet_speed);
                    y3 = y3 + bullet_term;
                    bullet_fire = false;


                    if (y1 < 0)
                    {
                        z = 3;
                        y4 = bullet_y_max;
                        y1 = 0;
                        y2 = -bullet_y_max;
                        y3 = 0;

                    }

                }
                else if (z == 3)
                {
                    x3 = bullet_y_max - y3;
                    BossBullet.GetBossBullet(gameObject).GetComponent<Rigidbody2D>().AddForce(new Vector3(x3, y3, 0) * bullet_speed);
                    y3 = y3 + bullet_term;
                    bullet_fire = false;

                    x4 = y4 - bullet_y_max;
                    BossBullet.GetBossBullet(gameObject).GetComponent<Rigidbody2D>().AddForce(new Vector3(x4, y4, 0) * bullet_speed);
                    y4 = y4 - bullet_term;
                    bullet_fire = false;

                    x1 = -bullet_y_max - y1;
                    BossBullet.GetBossBullet(gameObject).GetComponent<Rigidbody2D>().AddForce(new Vector3(x1, y1, 0) * bullet_speed);
                    y1 = y1 - bullet_term;
                    bullet_fire = false;

                    x2 = bullet_y_max + y2;
                    BossBullet.GetBossBullet(gameObject).GetComponent<Rigidbody2D>().AddForce(new Vector3(x2, y2, 0) * bullet_speed);
                    y2 = y2 + bullet_term;
                    bullet_fire = false;


                    if (y1 < -bullet_y_max)
                    {
                        z = 4;
                        y3 = bullet_y_max;
                        y4 = 0;
                        y1 = -bullet_y_max;
                        y2 = 0;

                    }

                }
                else if (z == 4)
                {
                    x2 = bullet_y_max - y2;
                    BossBullet.GetBossBullet(gameObject).GetComponent<Rigidbody2D>().AddForce(new Vector3(x2, y2, 0) * bullet_speed);
                    y2 = y2 + bullet_term;
                    bullet_fire = false;

                    x3 = y3 - bullet_y_max;
                    BossBullet.GetBossBullet(gameObject).GetComponent<Rigidbody2D>().AddForce(new Vector3(x3, y3, 0) * bullet_speed);
                    y3 = y3 - bullet_term;
                    bullet_fire = false;

                    x4 = -bullet_y_max - y4;
                    BossBullet.GetBossBullet(gameObject).GetComponent<Rigidbody2D>().AddForce(new Vector3(x4, y4, 0) * bullet_speed);
                    y4 = y4 - bullet_term;
                    bullet_fire = false;

                    x1 = bullet_y_max + y1;
                    BossBullet.GetBossBullet(gameObject).GetComponent<Rigidbody2D>().AddForce(new Vector3(x1, y1, 0) * bullet_speed);
                    y1 = y1 + bullet_term;
                    bullet_fire = false;


                    if (y1 > 0)
                    {
                        z = 1;
                        y2 = bullet_y_max;
                        y3 = 0;
                        y4 = -bullet_y_max;
                        y1 = 0;


                    }

                }
            }
            bullet_time++;
        }



    }

}
