using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ufo_align_childs_status : MonoBehaviour
{
    public ScoreManager scoreManager;
    public GameObject vehicle;

   
    public int life = 1;
    public int damage = 1;
    int score = 500;
    public bool imdead = false;
  


    public void OnEnable()
    {


        imdead = false;
        


    }

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
            Debug.Log("터짐");
            Player_status.PS_score += score;
            transform.parent = vehicle.transform;
            ExplosionManager.GetExplosion(this.gameObject);
            imdead = true;
            gameObject.SetActive(false);
            life = 1;

        }
    }
}
