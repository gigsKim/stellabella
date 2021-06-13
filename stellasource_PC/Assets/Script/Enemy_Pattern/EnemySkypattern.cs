using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySkypattern : MonoBehaviour
{
    int time = 0;

    private void OnEnable()
    {
        this.GetComponent<Rigidbody2D>().AddForce(new Vector3(-400, 0, 0));
    }
    void OnDisable()
    {
        this.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        time = 0;
    }

    private void Update()
    {
        if (time == 50)
        {
            this.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
            if (this.gameObject.name == "EnemySky2")
            {
                Debug.Log("드감");
                this.GetComponent<Rigidbody2D>().AddForce(new Vector3(-200, -100, 0));
            }
            else
            {
                this.GetComponent<Rigidbody2D>().AddForce(new Vector3(-200, 100, 0));
            }
        }
        time++;
        if (time % 50 == 0)
        {
            EnemyBulletManager.GetBullet(gameObject).GetComponent<Rigidbody2D>().AddForce(Vector3.left * 600);

        }

    }


}

