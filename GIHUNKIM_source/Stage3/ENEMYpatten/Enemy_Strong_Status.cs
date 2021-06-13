using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Strong_Status : MonoBehaviour
{
    public ScoreManager scoreManager;
    public GameObject vehicle;

    public int life = 20;
    public int damage = 1;
    int score = 2200;

    private void Start()
    {
        scoreManager = GameObject.Find("Score").GetComponent<ScoreManager>();
        vehicle = GameObject.Find("Vehicle");
    }
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Bullet_Player")
        {
            if(other.gameObject.name == "DroneBullet")
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
            Debug.Log("강적터짐");
            Player_status.PS_score += score;
            ExplosionManager.GetExplosion(this.gameObject);
            transform.parent = vehicle.transform;
            gameObject.SetActive(false);
            life = 20;

        }
    }
}
