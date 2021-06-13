using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBulletHoming : MonoBehaviour
{
    // Start is called before the first frame update
    private Transform player;
    bool co = true;
    bool move = true;
    public float bulletSpeed =20f ;
    private float time = 0f;
    private float time2 = 0f;
    private void OnEnable()
    {
        player = GameObject.Find("Player_alpha_flyver").transform;
        co = true;
        time = 0f;
        time2 = 0f;
        move = true;

    }
    private void Update()
    {
        time2 += Time.deltaTime;
        if (move)
        {

            if (co)
            {
                HomingBullet();
                co = false;
            }
            else if (!co)
            {
                time += Time.deltaTime;
                if (time > 1)
                {
                    time = 0f;
                    co = true;
                }

            }
            if (time2 > 6f)
            {
                this.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
                this.GetComponent<Rigidbody2D>().AddForce(new Vector2(-this.transform.position.x + player.position.x, -this.transform.position.y + player.position.y)* bulletSpeed*((bulletSpeed)/ Mathf.Sqrt(( -this.transform.position.x + player.position.x)* (-this.transform.position.x + player.position.x) + ( -this.transform.position.y + player.position.y)* (-this.transform.position.y + player.position.y))));
                move = false;
            }
        }
    }
   
    public void HomingBullet()
    {
        this.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        this.GetComponent<Rigidbody2D>().AddForce(new Vector2(-this.transform.position.x + player.position.x, -this.transform.position.y + player.position.y) * bulletSpeed * ((bulletSpeed ) / Mathf.Sqrt((-this.transform.position.x + player.position.x) * (-this.transform.position.x + player.position.x) + (-this.transform.position.y + player.position.y) * (-this.transform.position.y + player.position.y))));
    

    }


}
