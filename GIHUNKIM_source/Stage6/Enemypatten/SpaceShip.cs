using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceShip : MonoBehaviour
{
    float time = 0;

    bool bullet_fire = true;
    bool bullet_fire2 = true;
    bool bullet_fire3 = true;

    bool checkUpdate = false;
    bool move = false;


    void OnDisable()
    {
        checkUpdate = false;
        this.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        time = 0;
        bullet_fire = true;
        bullet_fire2 = true;
        bullet_fire3 = true;
    }

    void Update()
    {

        if (time == 0)
        {

            if (transform.position.y < 0)
            {
                this.GetComponent<Rigidbody2D>().AddForce(new Vector3(-200, 100, 0));
                move = false;
            }

            if (transform.position.y > 0)
            {
                this.GetComponent<Rigidbody2D>().AddForce(new Vector3(-200, -100, 0));
                move = true;
            }

        }


        if (move == false)
        {

            if (transform.position.y >= 0)
            {
                if (checkUpdate == false)
                {
                    this.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
                    this.GetComponent<Rigidbody2D>().AddForce(new Vector3(200, 200, 0));
                    checkUpdate = true;

                }

            }

        }

        if (move == true)
        {

            if (transform.position.y <= 0)
            {
                if (checkUpdate == false)
                {
                    this.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
                    this.GetComponent<Rigidbody2D>().AddForce(new Vector3(200, -200, 0));
                    checkUpdate = true;

                }

            }

        }




        time += Time.deltaTime;

        if (checkUpdate == false)
        {


            if (time > 1.5f)
            {
                if (bullet_fire)
                {
                    MissileManager.GetMissile(this.gameObject).GetComponent<Rigidbody2D>().AddForce(Vector3.left * 250);

                    bullet_fire = false;
                }

            }

            if (time > 2f)
            {
                if (bullet_fire2)
                {
                    MissileManager.GetMissile(this.gameObject).GetComponent<Rigidbody2D>().AddForce(Vector3.left * 250);

                    bullet_fire2 = false;
                }

            }


            if (time > 3f)
            {
                if (bullet_fire3)
                {
                    MissileManager.GetMissile(this.gameObject).GetComponent<Rigidbody2D>().AddForce(Vector3.left * 250);

                    bullet_fire3 = false;
                }

            }

            if (time >= 4.6f)
            {

                time = 0;
                bullet_fire = true;
                bullet_fire2 = true;
                bullet_fire3 = true;
            }


        }


    }


}
