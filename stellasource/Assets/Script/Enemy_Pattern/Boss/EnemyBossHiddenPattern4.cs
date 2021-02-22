using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBossHiddenPattern4 : MonoBehaviour
{
    float time = 0;
    public int bullet_speed = 60;
    public float bullet_term_time = 0.2f;
    public int fire_term = 5;
    public int wait_term = 1;
    bool co_check = true;
    int index = 0;
    bool fire=false;


    // Update is called once per frame
    void FixedUpdate()
    {
        time += Time.deltaTime;
        if (fire)
        {
            if (time > bullet_term_time && co_check)
            {

                time = 0;
                StartCoroutine("SpellStart");

            }
            else if (time > wait_term)
            {
                co_check = true;
            }
        }
        if (fire==false && time > 5)
        {
            fire = true;
        }
    }

    IEnumerator SpellStart()
    {
    
        index++;

        if (index % 16 == 1)
        {
            BossBullet.GetBossBullet(this.gameObject.transform.GetChild(1).gameObject).GetComponent<Rigidbody2D>().AddForce(3 * new Vector2(-1, 0) * bullet_speed);
            BossBullet.GetBossBullet(this.gameObject.transform.GetChild(2).gameObject).GetComponent<Rigidbody2D>().AddForce(3 * new Vector2(-1, 0) * bullet_speed);
            BossBullet.GetBossBullet(this.gameObject.transform.GetChild(3).gameObject).GetComponent<Rigidbody2D>().AddForce(3 * new Vector2(-1, 0) * bullet_speed);
            BossBullet.GetBossBullet(this.gameObject.transform.GetChild(4).gameObject).GetComponent<Rigidbody2D>().AddForce(3 * new Vector2(-1, 0) * bullet_speed);
            BossBullet.GetBossBullet(this.gameObject.transform.GetChild(5).gameObject).GetComponent<Rigidbody2D>().AddForce(3 * new Vector2(-1, 0) * bullet_speed);
        }
        if (index % 16 == 2)
        {
            BossBullet.GetBossBullet(this.gameObject.transform.GetChild(0).gameObject).GetComponent<Rigidbody2D>().AddForce(3 * new Vector2(-1, 0) * bullet_speed);
            BossBullet.GetBossBullet(this.gameObject.transform.GetChild(6).gameObject).GetComponent<Rigidbody2D>().AddForce(3 * new Vector2(-1, 0) * bullet_speed);
         /*   BossBullet.GetBossBullet(this.gameObject.transform.GetChild(3).gameObject).GetComponent<Rigidbody2D>().AddForce(3 * new Vector2(-1, 0) * bullet_speed);
            BossBullet.GetBossBullet(this.gameObject.transform.GetChild(4).gameObject).GetComponent<Rigidbody2D>().AddForce(3 * new Vector2(-1, 0) * bullet_speed);
            BossBullet.GetBossBullet(this.gameObject.transform.GetChild(5).gameObject).GetComponent<Rigidbody2D>().AddForce(3 * new Vector2(-1, 0) * bullet_speed);*/
        }
        if (index % 16 == 3)
        {
            BossBullet.GetBossBullet(this.gameObject.transform.GetChild(0).gameObject).GetComponent<Rigidbody2D>().AddForce(3 * new Vector2(-1, 0) * bullet_speed);
            BossBullet.GetBossBullet(this.gameObject.transform.GetChild(4).gameObject).GetComponent<Rigidbody2D>().AddForce(3 * new Vector2(-1, 0) * bullet_speed);
            BossBullet.GetBossBullet(this.gameObject.transform.GetChild(6).gameObject).GetComponent<Rigidbody2D>().AddForce(3 * new Vector2(-1, 0) * bullet_speed);
            /*   BossBullet.GetBossBullet(this.gameObject.transform.GetChild(3).gameObject).GetComponent<Rigidbody2D>().AddForce(3 * new Vector2(-1, 0) * bullet_speed);
               BossBullet.GetBossBullet(this.gameObject.transform.GetChild(4).gameObject).GetComponent<Rigidbody2D>().AddForce(3 * new Vector2(-1, 0) * bullet_speed);
               BossBullet.GetBossBullet(this.gameObject.transform.GetChild(5).gameObject).GetComponent<Rigidbody2D>().AddForce(3 * new Vector2(-1, 0) * bullet_speed);*/
        }
        if (index % 16 == 4)
        {
            BossBullet.GetBossBullet(this.gameObject.transform.GetChild(1).gameObject).GetComponent<Rigidbody2D>().AddForce(3 * new Vector2(-1, 0) * bullet_speed);
            BossBullet.GetBossBullet(this.gameObject.transform.GetChild(4).gameObject).GetComponent<Rigidbody2D>().AddForce(3 * new Vector2(-1, 0) * bullet_speed);
            BossBullet.GetBossBullet(this.gameObject.transform.GetChild(5).gameObject).GetComponent<Rigidbody2D>().AddForce(3 * new Vector2(-1, 0) * bullet_speed);
            /*   BossBullet.GetBossBullet(this.gameObject.transform.GetChild(3).gameObject).GetComponent<Rigidbody2D>().AddForce(3 * new Vector2(-1, 0) * bullet_speed);
               BossBullet.GetBossBullet(this.gameObject.transform.GetChild(4).gameObject).GetComponent<Rigidbody2D>().AddForce(3 * new Vector2(-1, 0) * bullet_speed);
               BossBullet.GetBossBullet(this.gameObject.transform.GetChild(5).gameObject).GetComponent<Rigidbody2D>().AddForce(3 * new Vector2(-1, 0) * bullet_speed);*/
        }

        if (index % 16 == 6)
        {
            BossBullet.GetBossBullet(this.gameObject.transform.GetChild(1).gameObject).GetComponent<Rigidbody2D>().AddForce(3 * new Vector2(-1, 0) * bullet_speed);
            BossBullet.GetBossBullet(this.gameObject.transform.GetChild(2).gameObject).GetComponent<Rigidbody2D>().AddForce(3 * new Vector2(-1, 0) * bullet_speed);
            BossBullet.GetBossBullet(this.gameObject.transform.GetChild(3).gameObject).GetComponent<Rigidbody2D>().AddForce(3 * new Vector2(-1, 0) * bullet_speed);
            BossBullet.GetBossBullet(this.gameObject.transform.GetChild(4).gameObject).GetComponent<Rigidbody2D>().AddForce(3 * new Vector2(-1, 0) * bullet_speed);
            BossBullet.GetBossBullet(this.gameObject.transform.GetChild(5).gameObject).GetComponent<Rigidbody2D>().AddForce(3 * new Vector2(-1, 0) * bullet_speed);
/*            BossBullet.GetBossBullet(this.gameObject.transform.GetChild(5).gameObject).GetComponent<Rigidbody2D>().AddForce(3 * new Vector2(-1, 0) * bullet_speed);*/
        }
        if (index % 16 == 7)
        {
            BossBullet.GetBossBullet(this.gameObject.transform.GetChild(0).gameObject).GetComponent<Rigidbody2D>().AddForce(3 * new Vector2(-1, 0) * bullet_speed);
            BossBullet.GetBossBullet(this.gameObject.transform.GetChild(6).gameObject).GetComponent<Rigidbody2D>().AddForce(3 * new Vector2(-1, 0) * bullet_speed);
/*            BossBullet.GetBossBullet(this.gameObject.transform.GetChild(3).gameObject).GetComponent<Rigidbody2D>().AddForce(3 * new Vector2(-1, 0) * bullet_speed);
            BossBullet.GetBossBullet(this.gameObject.transform.GetChild(4).gameObject).GetComponent<Rigidbody2D>().AddForce(3 * new Vector2(-1, 0) * bullet_speed);
            BossBullet.GetBossBullet(this.gameObject.transform.GetChild(5).gameObject).GetComponent<Rigidbody2D>().AddForce(3 * new Vector2(-1, 0) * bullet_speed);*/
            /*            BossBullet.GetBossBullet(this.gameObject.transform.GetChild(5).gameObject).GetComponent<Rigidbody2D>().AddForce(3 * new Vector2(-1, 0) * bullet_speed);*/
        }
        if (index % 16 == 8)
        {
            BossBullet.GetBossBullet(this.gameObject.transform.GetChild(0).gameObject).GetComponent<Rigidbody2D>().AddForce(3 * new Vector2(-1, 0) * bullet_speed);
            BossBullet.GetBossBullet(this.gameObject.transform.GetChild(6).gameObject).GetComponent<Rigidbody2D>().AddForce(3 * new Vector2(-1, 0) * bullet_speed);
            /*            BossBullet.GetBossBullet(this.gameObject.transform.GetChild(3).gameObject).GetComponent<Rigidbody2D>().AddForce(3 * new Vector2(-1, 0) * bullet_speed);
                        BossBullet.GetBossBullet(this.gameObject.transform.GetChild(4).gameObject).GetComponent<Rigidbody2D>().AddForce(3 * new Vector2(-1, 0) * bullet_speed);
                        BossBullet.GetBossBullet(this.gameObject.transform.GetChild(5).gameObject).GetComponent<Rigidbody2D>().AddForce(3 * new Vector2(-1, 0) * bullet_speed);*/
            /*            BossBullet.GetBossBullet(this.gameObject.transform.GetChild(5).gameObject).GetComponent<Rigidbody2D>().AddForce(3 * new Vector2(-1, 0) * bullet_speed);*/
        }
        if (index % 16 == 9)
        {
            BossBullet.GetBossBullet(this.gameObject.transform.GetChild(1).gameObject).GetComponent<Rigidbody2D>().AddForce(3 * new Vector2(-1, 0) * bullet_speed);
            BossBullet.GetBossBullet(this.gameObject.transform.GetChild(5).gameObject).GetComponent<Rigidbody2D>().AddForce(3 * new Vector2(-1, 0) * bullet_speed);
            /*            BossBullet.GetBossBullet(this.gameObject.transform.GetChild(3).gameObject).GetComponent<Rigidbody2D>().AddForce(3 * new Vector2(-1, 0) * bullet_speed);
                        BossBullet.GetBossBullet(this.gameObject.transform.GetChild(4).gameObject).GetComponent<Rigidbody2D>().AddForce(3 * new Vector2(-1, 0) * bullet_speed);
                        BossBullet.GetBossBullet(this.gameObject.transform.GetChild(5).gameObject).GetComponent<Rigidbody2D>().AddForce(3 * new Vector2(-1, 0) * bullet_speed);*/
            /*            BossBullet.GetBossBullet(this.gameObject.transform.GetChild(5).gameObject).GetComponent<Rigidbody2D>().AddForce(3 * new Vector2(-1, 0) * bullet_speed);*/
        }

        if (index % 16 == 11)
        {
            BossBullet.GetBossBullet(this.gameObject.transform.GetChild(0).gameObject).GetComponent<Rigidbody2D>().AddForce(3 * new Vector2(-1, 0) * bullet_speed);
            BossBullet.GetBossBullet(this.gameObject.transform.GetChild(1).gameObject).GetComponent<Rigidbody2D>().AddForce(3 * new Vector2(-1, 0) * bullet_speed);
            BossBullet.GetBossBullet(this.gameObject.transform.GetChild(2).gameObject).GetComponent<Rigidbody2D>().AddForce(3 * new Vector2(-1, 0) * bullet_speed);
            BossBullet.GetBossBullet(this.gameObject.transform.GetChild(3).gameObject).GetComponent<Rigidbody2D>().AddForce(3 * new Vector2(-1, 0) * bullet_speed);
            BossBullet.GetBossBullet(this.gameObject.transform.GetChild(4).gameObject).GetComponent<Rigidbody2D>().AddForce(3 * new Vector2(-1, 0) * bullet_speed);
            BossBullet.GetBossBullet(this.gameObject.transform.GetChild(5).gameObject).GetComponent<Rigidbody2D>().AddForce(3 * new Vector2(-1, 0) * bullet_speed);
            BossBullet.GetBossBullet(this.gameObject.transform.GetChild(6).gameObject).GetComponent<Rigidbody2D>().AddForce(3 * new Vector2(-1, 0) * bullet_speed);
        }
        if (index % 16 == 12)
        {
            BossBullet.GetBossBullet(this.gameObject.transform.GetChild(0).gameObject).GetComponent<Rigidbody2D>().AddForce(3 * new Vector2(-1, 0) * bullet_speed);
/*            BossBullet.GetBossBullet(this.gameObject.transform.GetChild(1).gameObject).GetComponent<Rigidbody2D>().AddForce(3 * new Vector2(-1, 0) * bullet_speed);
            BossBullet.GetBossBullet(this.gameObject.transform.GetChild(2).gameObject).GetComponent<Rigidbody2D>().AddForce(3 * new Vector2(-1, 0) * bullet_speed);*/
            BossBullet.GetBossBullet(this.gameObject.transform.GetChild(3).gameObject).GetComponent<Rigidbody2D>().AddForce(3 * new Vector2(-1, 0) * bullet_speed);
/*            BossBullet.GetBossBullet(this.gameObject.transform.GetChild(4).gameObject).GetComponent<Rigidbody2D>().AddForce(3 * new Vector2(-1, 0) * bullet_speed);
            BossBullet.GetBossBullet(this.gameObject.transform.GetChild(5).gameObject).GetComponent<Rigidbody2D>().AddForce(3 * new Vector2(-1, 0) * bullet_speed);*/
            BossBullet.GetBossBullet(this.gameObject.transform.GetChild(6).gameObject).GetComponent<Rigidbody2D>().AddForce(3 * new Vector2(-1, 0) * bullet_speed);
        }
        if (index % 16 == 13)
        {
            BossBullet.GetBossBullet(this.gameObject.transform.GetChild(0).gameObject).GetComponent<Rigidbody2D>().AddForce(3 * new Vector2(-1, 0) * bullet_speed);
            /*            BossBullet.GetBossBullet(this.gameObject.transform.GetChild(1).gameObject).GetComponent<Rigidbody2D>().AddForce(3 * new Vector2(-1, 0) * bullet_speed);
                        BossBullet.GetBossBullet(this.gameObject.transform.GetChild(2).gameObject).GetComponent<Rigidbody2D>().AddForce(3 * new Vector2(-1, 0) * bullet_speed);*/
            BossBullet.GetBossBullet(this.gameObject.transform.GetChild(3).gameObject).GetComponent<Rigidbody2D>().AddForce(3 * new Vector2(-1, 0) * bullet_speed);
            /*            BossBullet.GetBossBullet(this.gameObject.transform.GetChild(4).gameObject).GetComponent<Rigidbody2D>().AddForce(3 * new Vector2(-1, 0) * bullet_speed);
                        BossBullet.GetBossBullet(this.gameObject.transform.GetChild(5).gameObject).GetComponent<Rigidbody2D>().AddForce(3 * new Vector2(-1, 0) * bullet_speed);*/
            BossBullet.GetBossBullet(this.gameObject.transform.GetChild(6).gameObject).GetComponent<Rigidbody2D>().AddForce(3 * new Vector2(-1, 0) * bullet_speed);
        }
        if (index % 16 == 14)
        {
 /*           BossBullet.GetBossBullet(this.gameObject.transform.GetChild(0).gameObject).GetComponent<Rigidbody2D>().AddForce(3 * new Vector2(-1, 0) * bullet_speed);*/
            BossBullet.GetBossBullet(this.gameObject.transform.GetChild(1).gameObject).GetComponent<Rigidbody2D>().AddForce(3 * new Vector2(-1, 0) * bullet_speed);
            BossBullet.GetBossBullet(this.gameObject.transform.GetChild(2).gameObject).GetComponent<Rigidbody2D>().AddForce(3 * new Vector2(-1, 0) * bullet_speed);
/*          
 *          BossBullet.GetBossBullet(this.gameObject.transform.GetChild(3).gameObject).GetComponent<Rigidbody2D>().AddForce(3 * new Vector2(-1, 0) * bullet_speed);*/
            BossBullet.GetBossBullet(this.gameObject.transform.GetChild(4).gameObject).GetComponent<Rigidbody2D>().AddForce(3 * new Vector2(-1, 0) * bullet_speed);
            BossBullet.GetBossBullet(this.gameObject.transform.GetChild(5).gameObject).GetComponent<Rigidbody2D>().AddForce(3 * new Vector2(-1, 0) * bullet_speed);
/*            BossBullet.GetBossBullet(this.gameObject.transform.GetChild(5).gameObject).GetComponent<Rigidbody2D>().AddForce(3 * new Vector2(-1, 0) * bullet_speed);*/
        }
        yield return new WaitForSeconds(0f);
       


    }
}
