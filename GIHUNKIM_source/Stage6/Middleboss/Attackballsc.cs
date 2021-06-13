using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attackballsc : MonoBehaviour
{
    int oneShoting;
    int time = 0;
    int bossbullet = 8;


    public float bulletposition = 25;

    public bool min = true;
    public bool pattenend = false;
    public GameObject bullet;
    bool updown = false;
   


    private void OnDisable()
    {
        min = true;
        pattenend = false;
        updown = false;
        
    }



    void FixedUpdate()
    {
        if(pattenend == true)
        {
            Debug.Log("실행");
            gameObject.transform.parent.position = transform.parent.gameObject.transform.parent.transform.position;
            gameObject.transform.parent.gameObject.SetActive(false);
        }


        if (min == false)
        {
            if (transform.position.y < 0)
                updown = true;


            if (transform.position.y >= 0)
                updown = false;

        }

        time++;

       
        if (min == false && updown == true)
        {

            if (time % bossbullet == 0)
            {
                if (bulletposition >= 360)
                    bulletposition = 0;

                this.transform.rotation = Quaternion.Euler(0, 180, 0);
                this.transform.Rotate(0, 0, bulletposition);

                bullet = BossBullet.GetBossBullet(this.gameObject);
                bullet.transform.rotation = this.transform.rotation;
                bullet.GetComponent<Rigidbody2D>().AddForce(new Vector2(bullet.transform.right.x, bullet.transform.right.y) * 400);
                //bullet.GetComponent<Rigidbody2D>().AddForce(new Vector2(bullet.transform.right.x, bullet.transform.right.y) * -200);

                bullet = BossBullet.GetBossBullet(this.gameObject);
                bullet.transform.rotation = this.transform.rotation;
                bullet.GetComponent<Rigidbody2D>().AddForce(new Vector2(bullet.transform.right.x, bullet.transform.right.y) * -400);
                bulletposition += 5;

            }

        }


        if (min == false && updown == false)
        {

            if (time % bossbullet == 0)
            {
                if (bulletposition >= 360)
                    bulletposition = 0;

                this.transform.rotation = Quaternion.Euler(0, 180, 0);
                this.transform.Rotate(0, 0, bulletposition);

                bullet = BossBullet.GetBossBullet(this.gameObject);
                bullet.transform.rotation = this.transform.rotation;
                bullet.GetComponent<Rigidbody2D>().AddForce(new Vector2(bullet.transform.up.x, bullet.transform.up.y) * 400);
                //bullet.GetComponent<Rigidbody2D>().AddForce(new Vector2(bullet.transform.right.x, bullet.transform.right.y) * -200);

                bullet = BossBullet.GetBossBullet(this.gameObject);
                bullet.transform.rotation = this.transform.rotation;
                bullet.GetComponent<Rigidbody2D>().AddForce(new Vector2(bullet.transform.up.x, bullet.transform.up.y) * -400);
                bulletposition += 5;

            }

        }

    }
}
