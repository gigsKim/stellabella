using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ufo_align_move : MonoBehaviour
{
  
    float time = 0;
    float shootime = 0;

    private int check = 3;

    public int rotSpeed = 20;
    //회전속도
    public int bulletTerm = 10;

    float z = 0;


    bool checkUpdate = false;
    bool move = false;

    void OnDisable()
    {
        checkUpdate = false;
        this.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        time = 0;
        z = 0;
        shootime = 0;
     
    }


    private void Update()
    {
        shootime += Time.deltaTime;

        if(shootime >= check)
        {
            Debug.Log("드감");
            if (checkUpdate == false)
            {
                
                EnemyBulletManager.GetBullet(gameObject).GetComponent<Rigidbody2D>().AddForce(new Vector3(-300, 0, 0));
                shootime = 0;
                checkUpdate = true;
            }
            


        }

        if(time == 0)
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
            }
        }


    }

}
