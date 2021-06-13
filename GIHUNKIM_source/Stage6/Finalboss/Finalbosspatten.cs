using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finalbosspatten : MonoBehaviour
{
    int time = 0;
    int bossbullet = 10;

    public float bulletposition = 0;
    float bossbullet2 = 0;

    public GameObject bullet;
    public GameObject bullet2;
    public GameObject bullet3;
    public bool updown = false;

 

    private void Start()
    {
      
    }

    void FixedUpdate()
    {

       
            time++;



            if (time % bossbullet == 0)
            {


                if (bulletposition == 70)
                {
                    updown = false;

                    //bulletposition = 0;
                }
                if (bulletposition == -70)
                {
                    updown = true;
                }

            if (bossbullet2 >= 50)
                bossbullet2 = 0;

                if (updown == false)
                {
                    bulletposition -= 5;
                     bossbullet2 += 5;
                }
                else
                {
                    bulletposition += 5;
                    bossbullet2 += 5;
            }   





            this.transform.rotation = Quaternion.Euler(0, 0, 0);
            this.transform.Rotate(0,-180, bulletposition);

            bullet = BossBullet.GetBossBullet(this.gameObject);
            bullet.transform.rotation = this.transform.rotation;
            bullet.GetComponent<Rigidbody2D>().AddForce(new Vector2(2, bullet.transform.right.y) * -250);



            //bullet.GetComponent<Rigidbody2D>().AddForce(new Vector2(bullet.transform.right.x, bullet.transform.right.y) * -200);


           



        }

        




    }
}
