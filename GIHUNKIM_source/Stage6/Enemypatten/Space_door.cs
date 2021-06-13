using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Space_door : MonoBehaviour
{
    int oneShoting;
    int time = 0;
    int bossbullet = 20;
    public float bulletposition = 25;
    bool min = true;
    public GameObject bullet;
    public bool updown = false;

    void FixedUpdate()
    {
        time++;

        if (min == true)
        {
            if (time > 120)
            {
                time = 0;
                min = false;
            }

        }
        if (min == false)
        {

            if (time % bossbullet == 0)
            {


                if (bulletposition == 25)
                {
                    updown = false;

                    //bulletposition = 0;
                }
                if (bulletposition == -25)
                {
                    updown = true;
                }

                if (updown == false)
                {
                    bulletposition -= 5;
                }
                else
                {
                    bulletposition += 5;
                }






                this.transform.rotation = Quaternion.Euler(0, 180, 0);
                this.transform.Rotate(0, 0, bulletposition);

                bullet = BossBullet.GetBossBullet(this.gameObject);
                bullet.transform.rotation = this.transform.rotation;
                bullet.GetComponent<Rigidbody2D>().AddForce(new Vector2(bullet.transform.right.x, bullet.transform.right.y) * 400);
                //bullet.GetComponent<Rigidbody2D>().AddForce(new Vector2(bullet.transform.right.x, bullet.transform.right.y) * -200);





            }

        }

    }
}