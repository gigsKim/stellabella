using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UFO_vertical_move : MonoBehaviour
{
    public float time = 0;

   public bool checkUpdate = false;
   public bool move = false;
    


    void OnDisable()
    {
        checkUpdate = false;
        move = false;
        this.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        time = 0;
        


    }

    void Update()
    {

        if (time == 0)
        {

            if (transform.position.y < 0)
            {
                this.GetComponent<Rigidbody2D>().AddForce(new Vector3(-400, 100, 0));
                move = false;
            }

            if (transform.position.y >= 0)
            {
                this.GetComponent<Rigidbody2D>().AddForce(new Vector3(-400, -100, 0));
                move = true;
            }

        }


        if (move == false)
        {

            if (transform.position.x <= 9 )
            {
                if (checkUpdate == false)
                {
                    this.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
                    this.GetComponent<Rigidbody2D>().AddForce(new Vector3(0, 200, 0));
                    checkUpdate = true;

                }

            }

            if(checkUpdate == true && transform.position.y >= 4.5)
            {
                this.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
                this.GetComponent<Rigidbody2D>().AddForce(new Vector3(0, -200, 0));
                


            }

            if (checkUpdate == true && transform.position.y <= -4.5)

            {
                this.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
                this.GetComponent<Rigidbody2D>().AddForce(new Vector3(0, 200, 0));



            }



        }

        if (move == true)
        {

            if (transform.position.x <= 9)
            {
                if (checkUpdate == false)
                {
                    this.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
                    this.GetComponent<Rigidbody2D>().AddForce(new Vector3(0, -200, 0));
                    checkUpdate = true;

                }

            }

            if (checkUpdate == true && transform.position.y <= -4.5)
            {
                this.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
                this.GetComponent<Rigidbody2D>().AddForce(new Vector3(0, 200, 0));

            }

            if (checkUpdate == true && transform.position.y >= 4.5)
            {
                this.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
                this.GetComponent<Rigidbody2D>().AddForce(new Vector3(0, -200, 0));



            }


        }




        time += Time.deltaTime;

     

            if (time > 2f)
            {
               
                  
                 EnemyBulletManager.GetBullet(gameObject).GetComponent<Rigidbody2D>().AddForce(Vector3.left * 450);
                 time = 0.1f;
                    
            

            }

            

            if(time > 1.7 && transform.position.x > 13)
        {
            time = 0;
        }
            


        


    }
}
