using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage_3_bosspatten_3 : MonoBehaviour
{
   
    int time = 0;
    int bossbullet = 2;
    public float bulletposition = 0;
 
    public GameObject bullet;
    public bool updown = false;

    Stage_3_pt1_mager manager;

    private void Start()
    {
        manager = gameObject.GetComponent<Stage_3_pt1_mager>();
    }

    void FixedUpdate()
    {

        if (manager.firstmove == false && manager.hp >= 150)
        {
            time++;



            if (time % bossbullet == 0)
            {


                if (bulletposition == 91.5f)
                {
                    updown = true;

                    //bulletposition = 0;
                }
                if (bulletposition == -91.5f)
                {
                    updown = false;
                }

                if (updown == false)
                {
                    bulletposition += 3.5f;
                }
                else
                {
                    bulletposition -= 3.5f;
                }





                this.transform.rotation = Quaternion.Euler(0, 180, 0);
                this.transform.Rotate(1, -0.4f, bulletposition);

                bullet = BossBullet.GetBossBullet(this.gameObject);
                bullet.transform.rotation = this.transform.rotation;
                bullet.GetComponent<Rigidbody2D>().AddForce(new Vector2(bullet.transform.right.x, bullet.transform.right.y) * 500);
                






            }


        }


    }
}
