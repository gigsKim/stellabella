using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Space_warrior_move : MonoBehaviour
{

    float time = 0;
    public float maxtime = 2.2f;
    public float backtime = 6.0f;
    public float moveint = -300;
    bool back = false;
    bool go = false;

  

    private void Start()
    {
       
    }

    void OnEnable()
    {
        this.GetComponent<Rigidbody2D>().AddForce(new Vector3(moveint, 0, 0));
    
    }

    void OnDisable()
    {

        back = false;
        go = false;
        this.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        time = 0;

        
    }
    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
     
        
        if (time >= maxtime)
        {
            //this.GetComponent<Rigidbody2D>().AddForce(new Vector3(-200, 0, 0));
            this.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        }


        if (time >= backtime)
        {

            if(gameObject.name == "Robot")
            this.GetComponent<Rigidbody2D>().AddForce(new Vector3(-moveint, 0, 0));

            if(gameObject.name == "Door")
                this.GetComponent<Rigidbody2D>().AddForce(new Vector3(0, moveint, 0));


        }
          
        
    }
}
