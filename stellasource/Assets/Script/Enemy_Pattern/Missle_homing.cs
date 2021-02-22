using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missle_homing : MonoBehaviour
{
    public GameObject explosion;
    public GameObject player;
    // Start is called before the first frame update


    private void Start()
    {
        player = GameObject.Find("Player_alpha_flyver");
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player" || other.tag == "Lazer" || other.tag == "Bullet_Player" || other.tag == "Boom")
        {
            ExplosionManager.GetExplosion(gameObject);
            this.gameObject.SetActive(false);
        }

    }

    // Update is called once per frame
    void Update()
    {
        this.gameObject.transform.Translate(-0.2f, player.transform.position.y * 0.01f, 0);
    }
}
