using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chaser : MonoBehaviour
{
    public GameObject player;
    public bool chaseon = false;
    public bool deleteon = false;

    float time = 0;

    // Update is called once per frame


    public int damage;
    public void OnTriggerEnter2D(Collider2D other)
    {
      


    }

    private void Start()
    {
        player = GameObject.Find("Player_alpha_flyver");
    }


    public void OnEnable()
    {
        this.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        

    }

    public void OnDisable()
    {
        time = 0;
        chaseon = false;
        
        deleteon = false;
    }


    public void Update()
    {
        if (chaseon == true)

        {
            time += Time.deltaTime;
            gameObject.SetActive(true);
            this.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        }

        if (time >= 1.5f)
        {

            if (player.transform.position.x <= 0)
            {
                chaseon = false;
                gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(-900, (player.transform.position.y * 100)));
                time = 0;
                
                

            }

            if (player.transform.position.x > 0)
            {
                chaseon = false;
               
                gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(900, (player.transform.position.y *100)));
                time = 0;
                


            }

        }

        if (deleteon == true)
        {

            gameObject.transform.position = transform.parent.position;
          
            gameObject.SetActive(false);

        }
        


    }
}
