using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Boss_status : MonoBehaviour
{
    //보스프리팹에 달 것
    //보스 체력
    public float boss_hp = 300;
    //초기 보스 출현시 이동할 거리(x)값
    public float boss_move = -300f;

    public bool boss_positionstop = true;
    float time;
    public ScoreManager_Finish ScoreManager_Finish;
 


    //최초 출현 시 이동
    private void OnEnable()
    {
        this.GetComponent<Rigidbody2D>().AddForce(new Vector3(boss_move, 0, 0));
        ScoreManager_Finish = GameObject.Find("Finish_screen").GetComponent<ScoreManager_Finish>();
    }

    private void Update()
    {
        time+=Time.deltaTime;
        //1초후 이동 멈춤
        if (time > 1)
        {
            if (boss_positionstop)
            {
                this.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
                boss_positionstop = false;
            }
        }
        //보스사망체크
        if (boss_hp <= 0)
        {
            
             Player_status.PS_score+=50000;

            ScoreManager_Finish.bossdead = true;
            Destroy(gameObject);
        }
    }
    //탄, 폭탄 피격시
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Bullet_Player")
        {
            if(collision.gameObject.name == "DroneBullet")
            {
                boss_hp -= collision.GetComponent<BulletDamage>().damage;
                StartCoroutine(bossHit());
            }
            else
            {
                boss_hp -= collision.GetComponent<Player_Bullet>().damage;
                StartCoroutine(bossHit());
            }
            
        }
        if(collision.tag == "Boom")
        {
            boss_hp -= 10;
            StartCoroutine(bossHit());
            
        }
    }
    //레이저 피격시
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == "Lazer")
        {

            Debug.Log("레이저에 타격받음");
            boss_hp -= 0.5f;
            StartCoroutine(bossHit());
        }
    }
    IEnumerator bossHit()
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
}

