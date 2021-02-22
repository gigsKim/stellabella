using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boom_area : MonoBehaviour
{
    Player_Bomb PB;

    int boomdmg;
    float time;

    private BoxCollider2D boomZone;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Enemy_bullet")
        {
            
            EnemyBulletManager.RetireBullet(collision.gameObject);
        }

    }

    void Start()
    {
        PB = GameObject.Find("BombB").GetComponent<Player_Bomb>();
        boomZone = this.GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        if(PB.boomOn == true)
        {
            boomZone.enabled = true;
            this.transform.GetChild(0).gameObject.SetActive(true);
            time += Time.deltaTime;

            if(time >= 1.5f)
            {
                time = 0;
                this.transform.GetChild(0).gameObject.SetActive(false);
                boomZone.enabled = false;
                PB.boomOn = false;
            }
        }
    }
}
