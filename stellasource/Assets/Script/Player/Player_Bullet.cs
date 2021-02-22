using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player_Bullet : MonoBehaviour
{
    public int damage;
    public GameObject Player;
    bool setfirsttime = true;
    public bool shoot_trigger = true;
    private void Start()
    {
        Player = GameObject.Find("Player_alpha_flyver");
    }
    private void Update()
    {
        if (setfirsttime)
        {
            this.gameObject.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
            this.gameObject.GetComponent<CapsuleCollider2D>().enabled = false;
            /*this.gameObject.SetActive(false);*/
            setfirsttime = false;
        }
        if (this.gameObject.GetComponent<CapsuleCollider2D>().enabled && shoot_trigger)
        {
            this.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.right * 1000);
            shoot_trigger = false;
        }

    }
    // Start is called before the first frame update
    public void OnTriggerEnter2D(Collider2D other)
    {
       
        if (other.tag == "Enemy_normal" || other.tag == "Enemy_missile" || other.tag == "Boss")
        {
            gameObject.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
            gameObject.transform.parent = Player.transform;
            gameObject.transform.localPosition = new Vector3(0, 0, 10);
            gameObject.GetComponent<CapsuleCollider2D>().enabled = false;
            shoot_trigger = true;
        }
      

    }
}
