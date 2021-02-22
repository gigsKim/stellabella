using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main_Area : MonoBehaviour
{
    public GameObject Player;
    public GameObject vehicle;
    private void Start()
    {
        Player = GameObject.Find("Player_alpha_flyver");
        vehicle = GameObject.Find("Vehicle");
    }
    //메인카메라 콜라이더를 벗어나면 폭발시킴
    private void OnTriggerExit2D(Collider2D other)
    {

        if (other.tag == "Bullet_Player")
        {
            if (other.gameObject.name == "DroneBullet") { }
            else
            {
                other.gameObject.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
                other.gameObject.transform.parent = Player.transform;
                other.gameObject.transform.localPosition = new Vector3(0, 0, 10);
                other.gameObject.GetComponent<CapsuleCollider2D>().enabled = false;
                other.gameObject.GetComponent<Player_Bullet>().shoot_trigger = true;
            }
        }
        else if (other.tag == "Enemy_missile")
        {
            other.gameObject.SetActive(false);
        }
        else if (other.tag == "Enemy_normal")
        {
            other.transform.parent = vehicle.transform;
            other.gameObject.SetActive(false);
        }
        else if (other.tag == "Enemy_bullet")
        {
            this.transform.rotation = Quaternion.Euler(new Vector3(0, 0, 0));
            EnemyBulletManager.RetireBullet(other.gameObject);
        }

    }
}
