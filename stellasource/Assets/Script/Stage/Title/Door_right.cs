using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door_right : MonoBehaviour
{
    float speed = 0.1f;
    int moveTime = 0;
    bool check = false;
    int distance = 0;
    float xMove = 0;
    bool pushedcheck_right=false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {


        

    }
    private void FixedUpdate()
    {

        if (Input.anyKey)
        {
            if (pushedcheck_right == false)
            {
                check = true;
                pushedcheck_right = true;
            }
        }
        
            
 
        move();




    }
    void move()
    {
        if (check == true)
        {
            
            for (moveTime = 0; moveTime <= 200; moveTime++)
            {
                xMove = speed * Time.deltaTime * 6;
                this.transform.Translate(new Vector3(xMove, 0, 0));
                
            }
            distance++;
            if (distance > 5)
            {
                check = false;
            }
        }
    }
}
