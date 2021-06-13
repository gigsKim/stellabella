using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mine_status : MonoBehaviour
{
    public ScoreManager scoreManager;
    public GameObject vehicle;




    public int life = 1;
    public int damage = 1;
    int score = 0;
    
    public GameObject bullet;
    public GameObject bullet2;
    public GameObject bullet3;
    public GameObject bullet4;

    private void Start()
    {
        scoreManager = GameObject.Find("Score").GetComponent<ScoreManager>();
        vehicle = GameObject.Find("Vehicle");
    }
    public void OnTriggerExit2D(Collider2D other)
    {
        if(other.tag == "Finish")
        {
            transform.parent = vehicle.transform;
            gameObject.SetActive(false);
            life = 1;
        }
    }



    public void OnEnable()
    {
      
    }

    public void Update()
    {
        
        if(this.transform.position.y <-8)
        {
            transform.parent = vehicle.transform;
            gameObject.SetActive(false);
            life = 1;
        }
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
            bullet = EnemyBulletManager.GetBullet(gameObject);
            bullet.GetComponent<Rigidbody2D>().velocity = Vector3.zero;
            bullet.GetComponent<Rigidbody2D>().AddForce(new Vector3(1, 0, 0) * 600);


            bullet2 = EnemyBulletManager.GetBullet(gameObject);
            bullet2.GetComponent<Rigidbody2D>().velocity = Vector3.zero;
            bullet2.GetComponent<Rigidbody2D>().AddForce(new Vector3(-1, 0, 0) * 600);

            bullet3 = EnemyBulletManager.GetBullet(gameObject);
            bullet3.GetComponent<Rigidbody2D>().velocity = Vector3.zero;
            bullet3.GetComponent<Rigidbody2D>().AddForce(new Vector3(0, -1, 0) * 600);

            bullet4 = EnemyBulletManager.GetBullet(gameObject);
            bullet4.GetComponent<Rigidbody2D>().velocity = Vector3.zero;
            bullet4.GetComponent<Rigidbody2D>().AddForce(new Vector3(0, 1, 0) * 600);

         
            ExplosionManager.GetExplosion(this.gameObject);



            transform.parent = vehicle.transform;
            gameObject.SetActive(false);
            life = 1;
            
           

        }



    }
   
}
