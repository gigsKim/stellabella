using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_boss_patternX4 : MonoBehaviour
{
    float time = 0;
    public int bullet_speed=60;
    public float bullet_term_time = 0.5f;
    public int fire_term = 5;
    public int wait_term = 2;
    public int shooting_term_angle=5 ;
    int oneShoting;
    float num =0;
    bool co_check = true;
    int index = 0;
    

    // Update is called once per frame
    void FixedUpdate()
    {
        time += Time.deltaTime;
        
        if (time > bullet_term_time && co_check)
        {
            
            time = 0;
            StartCoroutine(SpellStart());
            
        }
        else if(time > wait_term)
        {
            co_check = true;
        }
    }

    IEnumerator SpellStart()
    {
        oneShoting = 360 / shooting_term_angle;
        index++;
        num ++;
        if (index == oneShoting)
        {
            index = 0;
        }


                BossBullet.GetBossBullet(this.gameObject).GetComponent<Rigidbody2D>().AddForce(new Vector2(bullet_speed * Mathf.Cos(Mathf.PI * 2 * index * shooting_term_angle/360 ), bullet_speed * Mathf.Sin(Mathf.PI * index * 2 *shooting_term_angle / 360)));

              
                BossBullet.GetBossBullet(this.gameObject).GetComponent<Rigidbody2D>().AddForce(new Vector2(bullet_speed * Mathf.Cos((Mathf.PI * 2 * index * shooting_term_angle / 360) +90), bullet_speed * Mathf.Sin((Mathf.PI * index * 2 * shooting_term_angle / 360) +90)));

             
                BossBullet.GetBossBullet(this.gameObject).GetComponent<Rigidbody2D>().AddForce(new Vector2(bullet_speed * Mathf.Cos((Mathf.PI * 2 * index * shooting_term_angle / 360) +180), bullet_speed * Mathf.Sin((Mathf.PI * index * 2 * shooting_term_angle / 360) +180)));

          
                BossBullet.GetBossBullet(this.gameObject).GetComponent<Rigidbody2D>().AddForce(new Vector2(bullet_speed * Mathf.Sin(Mathf.PI * 2 * index * shooting_term_angle / 360), bullet_speed * Mathf.Cos(Mathf.PI * index * 2 * shooting_term_angle / 360)));

      
                BossBullet.GetBossBullet(this.gameObject).GetComponent<Rigidbody2D>().AddForce(new Vector2(bullet_speed * Mathf.Sin((Mathf.PI * 2 * index * shooting_term_angle / 360) + 90), bullet_speed * Mathf.Cos((Mathf.PI * index * 2 * shooting_term_angle / 360) + 90)));


                BossBullet.GetBossBullet(this.gameObject).GetComponent<Rigidbody2D>().AddForce(new Vector2(bullet_speed * Mathf.Sin((Mathf.PI * 2 * index * shooting_term_angle / 360) + 180), bullet_speed * Mathf.Cos((Mathf.PI * index * 2 * shooting_term_angle / 360) + 180)));

        
        if (num > fire_term)
        {

            Debug.Log("in rutine num : " + num);
            num = 0;
            co_check = false;
            Debug.Log("const num : " + num);
            yield return new WaitForSeconds(5f);

        }
        else
        {
            yield return new WaitForSeconds(0f);
        }
             
       
    }

}
