using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Matteo : MonoBehaviour
{
    public GameObject player;
    float time = 0;

    // Update is called once per frame

    private void Start()
    {
        player = GameObject.Find("Player_alpha_flyver");
    }

    public void Update()
    {
        time++;

        if (time == 100)
        {
            this.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(-10, (player.transform.position.y * 0.2f)) * 70);
            time = 0;

        }


    }
}
