using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy_normal_status : MonoBehaviour
{
    public ScoreManager scoreManager;
    public GameObject vehicle;

    public int life = 1;
    public int returnlife = 1;
    public int damage = 1;
    public int score = 500;

    private void Start()
    {
        scoreManager = GameObject.Find("Score").GetComponent<ScoreManager>();
        vehicle = GameObject.Find("Vehicle");
    }
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Bullet_Player")
        {
            if (other.gameObject.name == "DroneBullet")
            {
                life -= other.GetComponent<BulletDamage>().damage;
            }
            else
            {
                life -= other.GetComponent<Player_Bullet>().damage;
            }
        }
        if (other.tag == "Boom")
        {
            life -= 10;
        }

        if (other.tag == "Lazer")
        {
            life -= 5;
        }

        if (life <= 0)
        {
            Player_status.PS_score += score;
            ExplosionManager.GetExplosion(this.gameObject);
            transform.parent = vehicle.transform;
            gameObject.SetActive(false);
            life = returnlife;
            
        }
    }
}