using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_boss_pattern1 : MonoBehaviour
{
    //사용하는 오브젝트 모음

    //보스 컨트롤 관련 변수
    public int bullet_speed = 100;
    public float bullet_term = 0.3f;
    public float bullet_yspeed = 10f;
    public int bullet_num = 0;
    public float bullet_yslide = 0.5f;

    float time = 0;
    bool bullet_fire = true;
    bool bullet_fire2 = true;
    float bullet_firecontrol = 0;
    int bullet_counter = 0;
    Vector3 bullet_position = new Vector3(-1, 0, 0);

    bool boss_positionstop = true;
    bool trigger = true;

    //이동관련 스크립트
    Vector3 pos = Vector3.zero; //현재위치
    float delta = 2.0f; // 상하로 이동가능한 (y)최대값
    float speed = 1.0f; // 이동속도
    void FixedUpdate()
    {

        time += Time.deltaTime;
        bullet_firecontrol += Time.deltaTime;
        if (!boss_positionstop)
        {
            Vector3 v = pos;

            v.y += delta * Mathf.Sin(Time.time * speed);

            transform.position = v;
        }
        ////////////////////////////////////////////////

        //총알발사간격 짧을수록 빨리쏨
        if (bullet_firecontrol > bullet_term)
        {
            bullet_fire = true;

        }

        //실제 사격 부 생성되고 2초후 사격시작
        if (time > 2)
        {
            //최대 y범위(yslide)보다 크면 감소시키고 작으면 증가시킴
            if (bullet_fire)
            {
                if (bullet_position.y > bullet_yslide)
                {
                    trigger = false;
                }
                if (trigger)
                {
                    bullet_position.y += Time.deltaTime * bullet_yspeed;
                }
                else if (bullet_position.y < -bullet_yslide)
                {
                    trigger = true;
                }
                else
                {
                    bullet_position.y -= Time.deltaTime * bullet_yspeed;
                }

                bullet_firecontrol = 0;
                bullet_fire = false;
                bullet_fire2 = true;
            }
            //최초 y위치가 정해졌을때 그 좌표를 기준으로 y를 움직이면서 bullet_num만큼 탄환을 발사 후 false됨
            else if (bullet_fire2)
            {
                bullet_counter++;
                if (bullet_counter == bullet_num)
                {
                    bullet_counter = 0;
                    bullet_fire2 = false;
                }
                else
                {
                    BossBullet.GetBossBullet(this.gameObject.transform.GetChild(0).gameObject).GetComponent<Rigidbody2D>().AddForce(bullet_position * (bullet_speed* bullet_counter));
                    BossBullet.GetBossBullet(this.gameObject.transform.GetChild(1).gameObject).GetComponent<Rigidbody2D>().AddForce(bullet_position * (bullet_speed* bullet_counter));
                    BossBullet.GetBossBullet(this.gameObject.transform.GetChild(2).gameObject).GetComponent<Rigidbody2D>().AddForce(bullet_position * (bullet_speed* bullet_counter));
                    if (bullet_position.y > bullet_yslide)
                    {
                        trigger = false;
                    }
                    if (trigger)
                    {
                        bullet_position.y += Time.deltaTime / bullet_yspeed;
                    }
                    else if (bullet_position.y < -bullet_yslide)
                    {
                        trigger = true;
                    }
                    else
                    {
                        bullet_position.y -= Time.deltaTime / bullet_yspeed;
                    }
                }

            }
        }
    }




}



