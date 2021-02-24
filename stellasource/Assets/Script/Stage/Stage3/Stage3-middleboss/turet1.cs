using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turet1 : MonoBehaviour
{

    public float boss_hp = 100;

   

    int bullet_speed = 60;

    public GameObject tt1;
    public GameObject tt2;
    public GameObject tt3;

    bool co_check = true;


    
    float firsttime = 0;
    float checktime = 0;
    int check = 0;


    IEnumerator bossHit()
    {
        int blinkTime = 0;
        while (blinkTime < 2)
        {
            if (blinkTime % 2 == 0)
            {
                this.GetComponent<SpriteRenderer>().color = new Color32(180, 180, 180, 180);
                yield return new WaitForSeconds(0.2f);
            }
            else
            {
                this.GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 255);
                yield return new WaitForSeconds(0.2f);
            }
            blinkTime++;
        }

        yield return null;
    }



    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Bullet_Player")
        {
            if (collision.gameObject.name == "DroneBullet")
            {
                boss_hp -= collision.GetComponent<BulletDamage>().damage;
                StartCoroutine("bossHit");
            }
            else
            {
                boss_hp -= collision.GetComponent<Player_Bullet>().damage;
                StartCoroutine("bossHit");
            }
        }
        if (collision.tag == "Boom")
        {
            boss_hp -= 10;
            StartCoroutine("bossHit");
        }
    }
    //레이저 피격시
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == "Lazer")
        {
          
            boss_hp -= 1f;
            StartCoroutine("bossHit");
        }
    }

    IEnumerator shoot()
    {


        do
        {

            switch (check)
            {

                case 0:
                    for (int i = 3; i > 1; i--)
                    {



                        BossBullet.GetBossBullet(tt1).GetComponent<Rigidbody2D>().AddForce(bullet_speed * new Vector3(-3, 0.5f, 0));
                        BossBullet.GetBossBullet(tt2).GetComponent<Rigidbody2D>().AddForce(bullet_speed * new Vector3(-3, 0, 0));
                        BossBullet.GetBossBullet(tt3).GetComponent<Rigidbody2D>().AddForce(bullet_speed * new Vector3(-3, -0.5f, 0));




                   
                        yield return new WaitForSeconds(0.35f);



                    }

                    break;



                case 1:
                    for (int i = 3; i > 1; i--)
                    {



                        BossBullet.GetBossBullet(tt1).GetComponent<Rigidbody2D>().AddForce(bullet_speed * new Vector3(-3, 0.5f, 0));
                        //BossBullet.GetBossBullet(tt2).GetComponent<Rigidbody2D>().AddForce(bullet_speed * new Vector3(-3, 0, 0));
                        // BossBullet.GetBossBullet(tt3).GetComponent<Rigidbody2D>().AddForce(bullet_speed * new Vector3(-3, -0.5f, 0));




                        yield return new WaitForSeconds(0.35f);



                    }

                    break;



                default:
                    for (int i = 3; i > 1; i--)
                    {



                        BossBullet.GetBossBullet(tt1).GetComponent<Rigidbody2D>().AddForce(bullet_speed * new Vector3(-3, 0.5f, 0));
                        // BossBullet.GetBossBullet(tt2).GetComponent<Rigidbody2D>().AddForce(bullet_speed * new Vector3(-3, 0, 0));
                        BossBullet.GetBossBullet(tt3).GetComponent<Rigidbody2D>().AddForce(bullet_speed * new Vector3(-3, -0.5f, 0));




                       
                        yield return new WaitForSeconds(0.35f);



                    }

                    break;



            }





        } while (true);
    }








    // Update is called once per frame
    void Update()
    {
        if (firsttime <= 2)
        {
            firsttime += Time.deltaTime;

        }
        if (firsttime > 2)
        {
            if (co_check)
            {

                StartCoroutine("shoot");
                co_check = false;
            }
        }



        if (checktime < 4)
        {

            checktime += Time.deltaTime;
        }

        if (checktime > 4)
        {

            if (check <= 2)
            {
                check++;

            }

            if (check > 2)
            {
                check = 0;

            }
            checktime = 0;
        }


      
        if (boss_hp <= 0)
        {

            Player_status.PS_score += 100;
            Destroy(gameObject);
            ExplosionManager.GetExplosion(this.gameObject);
            
           
        }
    }
}
