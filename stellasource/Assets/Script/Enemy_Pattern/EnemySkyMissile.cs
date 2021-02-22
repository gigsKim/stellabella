using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySkyMissile : MonoBehaviour
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
           
            if (bullet_fire)
            {
                this.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
                MissileManager.GetMissile(this.gameObject).GetComponent<Rigidbody2D>().AddForce(Vector3.left * 250);

                bullet_fire = false;
            }
        }
        if (time > 2.5)
        {
            if (bullet_fire2)
            {
                MissileManager.GetMissile(this.gameObject).GetComponent<Rigidbody2D>().AddForce(Vector3.left * 250);
                this.GetComponent<Rigidbody2D>().AddForce(new Vector3(0, 150, 0));
                this.GetComponent<Rigidbody2D>().AddForce(new Vector3(-200, 0, 0));
                bullet_fire2 = false;
            }
            
        }

    }


}