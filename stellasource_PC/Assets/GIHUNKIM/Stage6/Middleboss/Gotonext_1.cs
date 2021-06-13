using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Gotonext_1 : MonoBehaviour
{
    
    public bool isgo = false;
    public bool into = false;
    public GameObject player;
    public ForceToplayer FPC;
    bool timecheck;
    float time = 0;
    public void Start()
    {
        player = GameObject.Find("Player_alpha_flyver");
        FPC = GameObject.Find("Gozone").GetComponent<ForceToplayer>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(into == true)
        {
            if(collision.gameObject.tag=="Player")
            {

                timecheck= true;
                
               

            }


          
        }

        Debug.Log("!왜");
    }

    private void Update()
    {
        

        if(timecheck ==true)
        {
            time += Time.deltaTime;

            if(time > 0.8f)
            {
                SceneManager.LoadScene("Stage6_2");
            }
        }

        if(isgo == true)
        {

            into = true;
            
            if(player.transform.position.y < 0)
            {
                player.GetComponent<Rigidbody2D>().AddForce(new Vector3(0, 200, 0));

            }
            if (player.transform.position.y > 0)
            {
                player.GetComponent<Rigidbody2D>().AddForce(new Vector3(0, -200, 0));

            }

            FPC.isbossdead = true;
            isgo = false;

        }

      

    }

}
