using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_normal_missile_1 : MonoBehaviour
{

    float time = 0;
    bool bullet_fire = true;
    bool bullet_fire2 = true;
    void OnDisable()
    {
        this.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        time = 0;
    }

    void Update()
    {
        if (time == 0)
        {
            this.GetComponent<Rigidbody2D>().AddForce(new Vector3(-200, 0, 0));
        }

        time += Time.deltaTime;

        if (time > 1.0)
        {
            this.GetComponent<Rigidbody2D>().AddForce(new Vector3(0, -5, 0));
        }
        if (time > 1.5)
        {

            if (bullet_fire)
            {
                MissileManager.GetMissile(this.gameObject).GetComponent<Rigidbody2D>().AddForce(Vector3.left * 250);

                bullet_fire = false;
            }
        }
        if (time > 1.7)
        {
            this.GetComponent<Rigidbody2D>().AddForce(new Vector3(0, 8, 0));

        }
        if (time > 2.5)
        {
            if (bullet_fire2)
            {
                MissileManager.GetMissile(this.gameObject).GetComponent<Rigidbody2D>().AddForce(Vector3.left * 250);

                bullet_fire2 = false;
            }
        }
   
    }


}
