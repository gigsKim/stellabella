using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBossLongPhase : MonoBehaviour
{
    float time;
    public float speed = 4.0f;
    float delta = 3f;
    Vector3 pos = new Vector3();
    bool moveStartCheck = false;

    // Start is called before the first frame update
    void OnEnable()
    {
        this.GetComponent<EnemyLongBossPattern1>().enabled = false;
        time = 0;

    }


    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;

        if (time >= 1.0f)
        {
            if (moveStartCheck == false)
            {
                pos = this.transform.position;
                moveStartCheck = true;
            }
            Vector2 v = pos;
            v.x = this.transform.position.x;
            v.y += delta * Mathf.Sin((time - 1) * speed * 0.5f);


            // 좌우 이동의 최대치 및 반전 처리를 이렇게 한줄에 멋있게 하네요.

            this.transform.position = v;
        }
        if (this.GetComponent<Boss_status>().boss_hp < 120)
        {
            this.GetComponent<EnemyBossHiddenPattern3>().enabled = false;
            this.GetComponent<EnemyLongBossPattern1>().enabled = true;
        }
    }
}
