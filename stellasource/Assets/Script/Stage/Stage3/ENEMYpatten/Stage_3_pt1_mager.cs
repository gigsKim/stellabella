using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage_3_pt1_mager : MonoBehaviour
{
    Boss_status killerwhalest;


    int time = 0;
    int bossbullet = 2;
    public float bulletposition = 0;
    Stage_3_pt1_mager manager;
    GameObject bullet;

    GameObject Killer;

    public bool patten1;

    public float hp;

    public bool firstmove = true;
    public bool secondmove = false;
    bool updown = true;

    bool goup = false;
    bool pt2 =false;
    
    float pattentime = 0;

    public void Start()
    {
        Killer = GameObject.Find("Killer");
        killerwhalest = GameObject.Find("Killer").GetComponent<Boss_status>();
    }

    private void Update()
    {

        hp = killerwhalest.boss_hp;
        Debug.Log(hp);

        if(firstmove ==true)
        {

            pattentime += Time.deltaTime;

            if(pattentime >=3f)
            {
                pattentime = 0;
                firstmove = false;
            }

        }


        if (hp < 150)
        {
            secondmove = true;
            
            if(updown ==true)
            {
                pattentime += Time.deltaTime;

                if (pattentime >= 3f)
                {
                    pattentime = 0;
                    updown = false;
                    pt2 = true;
                }

            }
        }

        if(updown == false)
        {


            if (goup == false)
            {

                Killer.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
                Killer.GetComponent<Rigidbody2D>().AddForce(new Vector3(0, 200, 0));
                goup = true;
                }

        
            if(transform.position.y <= -4 && goup == true)
            {
                Killer.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
                Killer.GetComponent<Rigidbody2D>().AddForce(new Vector3(0, 200, 0));

            }


            if (transform.position.y >= 4 && goup == true)
            {
                Killer.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
                Killer.GetComponent<Rigidbody2D>().AddForce(new Vector3(0, -200, 0));

            }

        }


        if(pt2 == true)
        {


            time++;



            if (time % bossbullet == 0)
            {


                if (bulletposition == 35)
                {
                    updown = true;

                    //bulletposition = 0;
                }
                if (bulletposition == -35)
                {
                    updown = false;
                }

                if (updown == false)
                {
                    bulletposition += 5;
                }
                else
                {
                    bulletposition -= 5;
                }





                this.transform.rotation = Quaternion.Euler(0, 180, 0);
                this.transform.Rotate(1, -0.4f, bulletposition);

                bullet = BossBullet.GetBossBullet(this.gameObject);
                bullet.transform.rotation = this.transform.rotation;
                bullet.GetComponent<Rigidbody2D>().AddForce(new Vector2(-bullet.transform.right.x, bullet.transform.right.y) * -250);
                






            }


        }




    }
}
