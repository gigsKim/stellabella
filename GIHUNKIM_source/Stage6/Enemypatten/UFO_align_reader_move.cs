using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UFO_align_reader_move : MonoBehaviour
{
    float time = 0;
    float shootime = 0;

    public int check;

    public int rotSpeed = 20;
    //회전속도
    public int bulletTerm = 10;

    float z = 0;

    bool move = false;

    void OnDisable()
    {
        this.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        time = 0;
        z = 0;
        shootime = 0;

    }


    private void Update()
    {
        shootime++;
            if (time == 0)
            {

                if (transform.position.y < 0)
                {

                    move = false;
                }
                if (transform.position.y >= 0)
                {

                    move = true;
                }


            }

            time++;

            if (move == false)
            {

                if ((int)time % bulletTerm == 0)
                {
                    z += rotSpeed;
                    if (z >= 360) z = 0;
                    this.transform.rotation = Quaternion.Euler(new Vector3(0, 180, 0));
                    this.transform.Rotate(0, 0, z);
                    this.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
                    this.GetComponent<Rigidbody2D>().AddForce((new Vector2(gameObject.transform.right.x, gameObject.transform.right.y) * 300));
                if (shootime > 110 && shootime < 270)
                {
                    EnemyBulletManager.GetBullet(gameObject).GetComponent<Rigidbody2D>().AddForce(new Vector3(-200, 0, 0));
                }
                }

            }

            if (move == true)
            {

                if ((int)time % bulletTerm == 0)
                {
                    z += rotSpeed;
                    if (z >= 360) z = 0;
                    this.transform.rotation = Quaternion.Euler(new Vector3(0, 180, 0));
                    this.transform.Rotate(0, 0, z);
                    this.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
                    this.GetComponent<Rigidbody2D>().AddForce((new Vector2(gameObject.transform.right.x, -(gameObject.transform.right.y)) * 300));
                if (shootime > 110 && shootime < 300)
                {
                    EnemyBulletManager.GetBullet(gameObject).GetComponent<Rigidbody2D>().AddForce(new Vector3(-200, 0, 0));
                }

                }
            }


    }


    /*void Update()
    {


    if ((int)time % bulletTerm == 0)
        {
            z += rotSpeed;
            if (z >= 360) z = 0;
            this.transform.rotation = Quaternion.Euler(new Vector3(0, 180, 0));
            this.transform.Rotate(0, 0, z);
            this.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
            this.GetComponent<Rigidbody2D>().AddForce((new Vector2(gameObject.transform.right.x, -(gameObject.transform.right.y)) * 400));
        }


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


        time += Time.deltaTime;

        if(checkUpdate == true)
        {

            shootime += Time.deltaTime;


            if(shootime > (check / 10))
            {
                if (bullet_fire)
                {
                    EnemyBulletManager.GetBullet(gameObject).GetComponent<Rigidbody2D>().AddForce(new Vector3(-300, 100, 0));
                    EnemyBulletManager.GetBullet(gameObject).GetComponent<Rigidbody2D>().AddForce(new Vector3(-300, 0, 0));
                    EnemyBulletManager.GetBullet(gameObject).GetComponent<Rigidbody2D>().AddForce(new Vector3(-300, -100, 0));
                 
                    bullet_fire = false;
                }

            }
        }




        if (move == false)
        {

            if (transform.position.y >= 0)
            {
                if (checkUpdate == false)
                {
                    this.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
                    this.GetComponent<Rigidbody2D>().AddForce(new Vector3(200, 100, 0));
                    
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
                    this.GetComponent<Rigidbody2D>().AddForce(new Vector3(200, -100, 0));
                    
                    checkUpdate = true;

                }

            }

        }


    }*/
}
