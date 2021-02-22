using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Bullet : MonoBehaviour
{
    // Start is called before the first frame update
    public int damage;
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            this.transform.rotation = Quaternion.Euler(new Vector3(0, 0, 0));
            EnemyBulletManager.RetireBullet(gameObject);
        }
 

    }
}
