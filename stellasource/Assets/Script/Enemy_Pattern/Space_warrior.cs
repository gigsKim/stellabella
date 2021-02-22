using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Space_warrior : MonoBehaviour
{
    int time = 0;
    int bossbullet = 10;
    public float bulletposition = 0;
    public GameObject bullet;
    public bool updown = false;

    void FixedUpdate()
    {
        time++;



        if (time % bossbullet == 0)
        {


            /*if (bulletposition == 70)
            {
                updown = false;

                //bulletposition = 0;
            }
            if (bulletposition == -70)
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
            }*/



            if (bulletposition == 360)
                bulletposition = 0;




            this.transform.rotation = Quaternion.Euler(0, 0, 0);
            this.transform.Rotate(1, 0, bulletposition);

            bullet = BossBullet.GetBossBullet(this.gameObject);
            bullet.transform.rotation = this.transform.rotation;
            bullet.GetComponent<Rigidbody2D>().AddForce(new Vector2(bullet.transform.right.x, bullet.transform.right.y) * 400);
            //bullet.GetComponent<Rigidbody2D>().AddForce(new Vector2(bullet.transform.right.x, bullet.transform.right.y) * -200);


            bulletposition +=10 ;



        }





    }
}
