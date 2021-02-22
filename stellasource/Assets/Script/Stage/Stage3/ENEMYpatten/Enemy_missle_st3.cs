

    

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_missle_st3 : MonoBehaviour
{
    //미사일 달아줘야함
    public GameObject enemy_missile;

    GameObject instance;
    float time = 0;
    public int check;
    bool bullet_fire = true;
    bool bullet_fire2 = true;
    bool bullet_fire3 = true;
    bool checkUpdate = false;

    void OnEnable()
    {
        checkUpdate = true;

    }

    void OnDisable()
    {
        checkUpdate = false;
        this.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        time = 0;
    }


    private void Start()
    {
        check = Random.Range(0, 2);
    }

    void Update()
    {
        if (time == 0)
        {
            this.GetComponent<Rigidbody2D>().AddForce(new Vector3(-200, 0, 0));
        }

        time += Time.deltaTime;

        if (time > 2.3f)
        {

            if (check == 0)
            {
                this.GetComponent<Rigidbody2D>().AddForce(new Vector3(0, 3, 0));
            }

            if (check != 0)
            {
                this.GetComponent<Rigidbody2D>().AddForce(new Vector3(0, -3, 0));
            }


            if (bullet_fire)
            {
                MissileManager.GetMissile(this.gameObject).GetComponent<Rigidbody2D>().AddForce(Vector3.left * 250);

                bullet_fire = false;
            }
        }


        if (time > 3.5f)
        {
            if (bullet_fire2)
            {
                MissileManager.GetMissile(this.gameObject).GetComponent<Rigidbody2D>().AddForce(Vector3.left * 250);

                bullet_fire2 = false;
            }

        }


        if (time > 4.2f)
        {
            if (bullet_fire3)
            {
                MissileManager.GetMissile(this.gameObject).GetComponent<Rigidbody2D>().AddForce(Vector3.left * 250);

                bullet_fire3 = false;
            }

        }




        /*if (time > 1.5)
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
            if (bullet_fire3)
            {
                MissileManager.GetMissile(this.gameObject).GetComponent<Rigidbody2D>().AddForce(Vector3.left * 250);

                bullet_fire3 = false;
            }
        }
   
    }*/
    }


}
