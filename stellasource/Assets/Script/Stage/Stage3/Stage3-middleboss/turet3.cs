using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turet3 : MonoBehaviour
{
    public float boss_hp = 100;

  

    int bullet_speed = 60;

    public GameObject bt1;
    public GameObject bt2;
    public GameObject bt3;

    bool co_check = true;
    public GameObject bullet;

    GameObject a;
    GameObject b;
    GameObject c;

  
    float firsttime = 0;
    float checktime = 0;
    int check = 0;


    IEnumerator bosshit()
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
                StartCoroutine("bosshit");
            }
            else
            {
                boss_hp -= collision.GetComponent<Player_Bullet>().damage;
                StartCoroutine("bosshit");
            }
        }
        if (collision.tag == "Boom")
        {
            boss_hp -= 10;
            StartCoroutine("bosshit");
        }
    }
    //레이저 피격시
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == "Lazer")
        {
            
            boss_hp -= 1;
            StartCoroutine("bosshit");
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
                        a = Instantiate(bullet, new Vector3(bt1.gameObject.transform.position.x, bt1.gameObject.transform.position.y), Quaternion.identity);
                        
                        c = Instantiate(bullet, new Vector3(bt3.gameObject.transform.position.x, bt3.gameObject.transform.position.y), Quaternion.identity);


                       a.GetComponent<Rigidbody2D>().AddForce(bullet_speed * new Vector3(-3, 0.6f, 0));
                        // BossBullet.GetBossBullet(bt2).GetComponent<Rigidbody2D>().AddForce(bullet_speed * new Vector3(-3, 0, 0));
                       c.GetComponent<Rigidbody2D>().AddForce(bullet_speed * new Vector3(-3, -0.6f, 0));





                        yield return new WaitForSeconds(0.35f);



                    }

                    break;



                case 1:
                    for (int i = 3; i > 1; i--)
                    {

                        a = Instantiate(bullet, new Vector3(bt1.gameObject.transform.position.x, bt1.gameObject.transform.position.y), Quaternion.identity);
                       
                        c = Instantiate(bullet, new Vector3(bt3.gameObject.transform.position.x, bt3.gameObject.transform.position.y), Quaternion.identity);


                       a.GetComponent<Rigidbody2D>().AddForce(bullet_speed * new Vector3(-3, 0.6f, 0));
                        //BossBullet.GetBossBullet(bt2).GetComponent<Rigidbody2D>().AddForce(bullet_speed * new Vector3(-3, 0, 0));
                       c.GetComponent<Rigidbody2D>().AddForce(bullet_speed * new Vector3(-3, -1f, 0));




                        yield return new WaitForSeconds(0.35f);



                    }

                    break;



                default:
                    for (int i = 3; i > 1; i--)
                    {

                        a = Instantiate(bullet, new Vector3(bt1.gameObject.transform.position.x, bt1.gameObject.transform.position.y), Quaternion.identity);
                        b = Instantiate(bullet, new Vector3(bt2.gameObject.transform.position.x, bt2.gameObject.transform.position.y), Quaternion.identity);
                        c = Instantiate(bullet, new Vector3(bt3.gameObject.transform.position.x, bt3.gameObject.transform.position.y), Quaternion.identity);

                        a.GetComponent<Rigidbody2D>().AddForce(bullet_speed * new Vector3(-3, 0.6f, 0));
                        b.GetComponent<Rigidbody2D>().AddForce(bullet_speed * new Vector3(-3, 0, 0));
                        c.GetComponent<Rigidbody2D>().AddForce(bullet_speed * new Vector3(-3, -0.6f, 0));






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
