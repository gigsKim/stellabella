using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rador : MonoBehaviour
{


    public float boss_hp = 150;
    public GameObject move;
    public GameObject a;
    public GameObject b;


    public GameObject bbullet;
    public GameObject attack;

    bool first = true;
    float time = 0; 
    int speed = 450;
    int oneShoting = 30;
    int twoShoting = 50;
    GameObject bullet;
    GameObject bullet2;
    public MiddlebossMove middlemove;
    public Player_Bomb player_Bomb;

    IEnumerator bosshit()
    {
        int blinkTime = 0;
        while (blinkTime < 2)
        {
            if (blinkTime % 2 == 0)
            {
                this.GetComponent<SpriteRenderer>().color = new Color32(180, 180, 180, 180);
                yield return new WaitForSeconds(0.2f);

            }
            else
            {
                this.GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 255);
                yield return new WaitForSeconds(0.2f);
            }
            blinkTime++;
        }

        yield return null;
    }



    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Bullet_Player")
        {
            if (collision.gameObject.name == "DroneBullet")
            {
                boss_hp -= collision.GetComponent<BulletDamage>().damage;
                StartCoroutine("bosshit");
            }
            else
            {
                boss_hp -= collision.GetComponent<Player_Bullet>().damage;
                StartCoroutine("bosshit");
            }
        }
        if (collision.tag == "Boom")
        {
            boss_hp -= 10;
        }
    }
    //레이저 피격시
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == "Lazer")
        {
          
            boss_hp -= 0.5f;
            StartCoroutine("bosshit");
        }
    }


    public void Start()
    {
        middlemove = GameObject.Find("Stage3middleboss").GetComponent<MiddlebossMove>();
        player_Bomb = GameObject.Find("BombB").GetComponent<Player_Bomb>();
    }


    IEnumerator SpellStart()
    {
        float angle = 360 / oneShoting;

        do
        {

            for (int i = 0; i < oneShoting; i++)
            {


                attack = Instantiate(bullet, new Vector3(this.gameObject.transform.position.x, this.gameObject.transform.position.y), Quaternion.identity);

                //보스의 위치에 bullet을 생성합니다.
                attack.GetComponent<Rigidbody2D>().AddForce(new Vector2(speed * Mathf.Cos(Mathf.PI * 2 * i / oneShoting), speed * Mathf.Sin(Mathf.PI * i * 2 / oneShoting)));


                bullet.transform.Rotate(new Vector3(0f, 0f, 360 * i / oneShoting - 90));
            }




            yield return new WaitForSeconds(1f);
        } while (true);
    }



    IEnumerator SpellStart_2()
    {
        float angle = 360 / twoShoting;

        do
        {

            for (int i = 0; i < twoShoting; i++)
            {


                attack = Instantiate(bullet, new Vector3(this.gameObject.transform.position.x, this.gameObject.transform.position.y), Quaternion.identity);


                attack.GetComponent<Rigidbody2D>().AddForce(new Vector2(speed * Mathf.Cos(Mathf.PI * 2 * i / twoShoting), speed * Mathf.Sin(Mathf.PI * i * 2 / twoShoting)));


                bullet2.transform.Rotate(new Vector3(0f, 0f, 180 * i / twoShoting - 90));
            }




            yield return new WaitForSeconds(1.5f);
        } while (true);
    }


    public void Update()
    {
        time += Time.deltaTime;

       
        if(time >=3)
        {

            if (first == true)
            {
               
                StartCoroutine("SpellStart");
                StartCoroutine("SpellStart_2");
                first = false;
            }
          
            time = 0;
        }


        if (boss_hp <= 0)
        {
            Player_status.PS_score += 100;
            
            ExplosionManager.GetExplosion(this.gameObject);
            player_Bomb.boomOn = true;
            player_Bomb.enabled = false;
            middlemove.radordie = true;
            Destroy(gameObject);


        }
    }

}
