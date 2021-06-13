using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBossPatternOvertake : MonoBehaviour
{
   
    private GameObject[] bp;
    public GameObject playerO;
    private Vector3 player;
    int f2fTerm = 0;
    int fireTerm = 0;
    float b2bTerm = 1f;
    bool temp = true;
    GameObject pamp;
    public GameObject bullet;
    private void Start()
    {
        player = playerO.transform.position;
        bp = new GameObject[7];
        for (int i = 0; i < 7; i++)
        {
            bp[i] = this.transform.GetChild(i).gameObject;
        }
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        /*
         7개 방향에서 방향당 10발씩 한발쏠때마다 y축 이동 및 속도증가
         각 7개 방향은 일정간격을 가지고 있고 플레이어를 기준점으로 날아감
         */
        f2fTerm++;
        
        if (f2fTerm % 100 == 0)
        {
            temp = true;
            player = playerO.transform.position;
        }
        else if (temp)
        {
            
            fireTerm++;
            if (b2bTerm == 11)
            {
                temp = false;
                b2bTerm = 1f;
            }
            if ((int)fireTerm % 10 == 0)
            {
                float role = 0.3f;
                for (int i = 0; i < 7; i++)
                {

                    BossBullet.GetBossBullet(bp[i]).GetComponent<Rigidbody2D>().AddForce(new Vector2(-1, ((i + 1) * 0.15f) - (b2bTerm / 10f)) * ((b2bTerm + 2) * 30));

                    /*BossBullet.GetBossBullet(bp[i]).GetComponent<Rigidbody2D>().AddForce(new Vector2(-1 + role, ((i)-role)*((b2bTerm/10f)-role)) * (b2bTerm + 2) * 50);
                    /*BossBullet.GetBossBullet(bp[i]).GetComponent<Rigidbody2D>().AddForce(new Vector2(-1 + role, ((i - 3 + role + Mathf.Acos(b2bTerm / 10f)) / 3f) * 0.5f + (player.y * 0.1f) / 2) * (b2bTerm + 3) * 25);

                    /*BossBullet.GetBossBullet(bp[i]).GetComponent<Rigidbody2D>().AddForce(new Vector2(-1 + role, Mathf.Sin(player/100f) + (i+role) * 0.1f ) * (b2bTerm + 3) * 20);*/

                    if (i < 3)
                    {
                        role -= 0.1f;
                    }
                    else if(i > 3)
                    {
                        role += 0.1f;
                    }
                }
                b2bTerm++;
            }
        }

    }


}
