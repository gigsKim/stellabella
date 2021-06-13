using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_ufo_align_status : MonoBehaviour
{
    public ScoreManager scoreManager;
    public GameObject vehicle;

    public int life = 1;
    public int damage = 1;
    public int maxlife = 1;
    int score = 500;
    int bouns = 0;
    int bounsscore = 10000;

    public GameObject[] ufos;
    public Ufo_align_childs_status[] stat2;
    public bool imdeadtoo = false;

    public void OnEnable()
    {
        bouns = 0;
        imdeadtoo = false;
        life = maxlife;
        
    }


    public void OnDisable()
    {
        bouns = 0;

    }
    private void Start()
    {
        for (int i = 0; i < ufos.Length; i++)
        {
            
            stat2[i] = ufos[i].GetComponent<Ufo_align_childs_status>();
        }
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

        if (other.tag == "MainCamera")
        {
            gameObject.transform.DetachChildren();
            

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
            
          

           for (int i = 0; i < ufos.Length; i++)
                {
                
                
                if (stat2[i].imdead == false )
                    {
                    bouns++;
                    }

                }

            if (bouns >= 9)
            {

                for (int i = 0; i < ufos.Length; i++)
                {
                   

                    if (stat2[i].imdead == false)
                    {
                        stat2[i].life = 0;
                    }


                }
             
                Player_status.PS_score += bounsscore;
            }


            Debug.Log("터짐");
            Player_status.PS_score += score;
            ExplosionManager.GetExplosion(this.gameObject);
            transform.parent = vehicle.transform;
            gameObject.SetActive(false);
            life = life = maxlife;

        }
    }
}
