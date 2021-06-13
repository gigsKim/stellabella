using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBulletStep : MonoBehaviour
{
    float time;
    Vector2 temp;
    bool stop = false;
    public bool bossgone = false;
     EnemyBossHiddenPattern5 enemyBossHiddenPattern5;
    public BossStepBullet bossStepBullet;

    private void Start()
    {
        enemyBossHiddenPattern5 = GameObject.Find("spawnBulletSpace").GetComponent<EnemyBossHiddenPattern5>();
    }
    // Start is called before the first frame update
    private void OnEnable()
    {
      
        time = 0;
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if (bossStepBullet.bossdead)
        {
        }
        else if (!bossStepBullet.bossdead)
        
        {
            if (!enemyBossHiddenPattern5.bulletmove && !stop)
            {
                temp = this.GetComponent<Rigidbody2D>().velocity;
                this.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
                stop = true;
            }

            else if ((enemyBossHiddenPattern5.bulletmove && stop))
            {
                stop = false;
                this.GetComponent<Rigidbody2D>().velocity = temp;
                time = 0f;
            }
        }
        

    }
}
