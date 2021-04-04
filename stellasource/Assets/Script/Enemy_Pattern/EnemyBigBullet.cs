using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBigBullet : MonoBehaviour
{
    public float bulletSpeed=20f;
    // Start is called before the first frame update
    private Transform player;
    bool bounceCheck = false;
    private void Start()
    {
        player = GameObject.Find("Player_alpha_flyver").transform;
    }
    private void OnEnable()
    {
        bounceCheck = false;
    }
    // Update is called once per frame


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "WallForPattern")
        {
            if (!bounceCheck)
            {
                
                this.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
                this.GetComponent<Rigidbody2D>().AddForce(new Vector2(-this.transform.position.x + player.position.x, -this.transform.position.y + player.position.y) * bulletSpeed);
                bounceCheck = true;
            }
        }
    }
}
