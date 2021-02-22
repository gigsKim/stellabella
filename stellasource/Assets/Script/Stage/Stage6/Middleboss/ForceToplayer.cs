using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForceToplayer : MonoBehaviour
{
    public bool isbossdead = false;
    public GameObject player;

    public void Start()
    {
        player = GameObject.Find("Player_alpha_flyver");
    }

        public void OnTriggerEnter2D(Collider2D collision)
    {
        if(isbossdead == true)
        {
           
            if(collision.tag == "Player")
            {
                player.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
                player.GetComponent<Rigidbody2D>().AddForce(new Vector3(350,0, 0));
                player.GetComponent<Player_AutoShoot>().enabled = false;
                isbossdead = false;
            }

           
        }
    }

    public void OnTriggerStay2D(Collider2D collision)
    {
        if (isbossdead == true)
        {
           
            if (collision.tag == "Player")
            {

                player.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
                player.GetComponent<Rigidbody2D>().AddForce(new Vector3(350, 0, 0));
                player.GetComponent<Player_AutoShoot>().enabled = false;
                isbossdead = false;
            }


        }


    }
}
