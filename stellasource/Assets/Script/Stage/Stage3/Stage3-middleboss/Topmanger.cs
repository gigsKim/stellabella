using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Topmanger : MonoBehaviour
{

   
    public int bullet_speed = 60;
    public float bullet_term_time = 0.5f;
    public int fire_term = 5;
    public int shooting_term_angle = 5;
    public float wait_term = 1f;
    int oneShoting;


     bool co_check = true;


    
     float firsttime = 0;
    float checktime = 0;
    int check = 0;


    Vector3 bullet_position = new Vector3(-3, 0, 0);



    // Start is called before the first frame update
   

    private void FixedUpdate()
    {
        if (firsttime <= 2)
        {
            firsttime += Time.deltaTime;

        }
        if (firsttime > 2)
        {
            if (co_check)
            {
               
                co_check = false;
            }
        }



        if(checktime < 4)
        {

            checktime += Time.deltaTime;
        }

        if(checktime > 4)
        {

            if (check <= 2)
            {
                check++;

                    }

            if(check > 2)
            {
                check = 0;

            }
            checktime = 0;
        }

    }
}
