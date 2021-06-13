using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_missile_idle : MonoBehaviour
{
    public GameObject explosion;
    GameObject instance;
    // Start is called before the first frame update
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player"||other.tag=="Lazer"||other.tag== "Bullet_Player"||other.tag=="Boom")
        {
            ExplosionManager.GetExplosion(gameObject);
            this.gameObject.SetActive(false);
        }
       
    }
}
