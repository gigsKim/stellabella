using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBossHiddenPattern5 : MonoBehaviour
{
    //회전속도
    public int rotSpeed = 5;
    //총알 속도
    public int bulletSpeed = 100;
    //총알 간격
    public int bulletTerm = 10;

    float leftz = 0;
    GameObject temp;
    float time;
    bool start;
    float starttime;
    float bullettime;
    public bool bulletmove = true;
    public HiddenMidBossStatus hiddenMidBossStatus;
    public BossStepBullet bossStepBullet;

    private void OnEnable()
    {
        start = false;
    }
    void FixedUpdate()
    {
        starttime += Time.deltaTime;
        time++;
        bullettime += Time.deltaTime;
        if (starttime >= 1f)
        {
            start = true;
        }
        
            if (bullettime>=2&&bulletmove)
            {
                bulletmove = false;
                 bullettime = 0f;
            }
            else if (bullettime>=0.5&&!bulletmove)
            {
                bulletmove = true;
                bullettime = 0f;
            }
        

        if (start)
        {
            if (bulletmove) { 
                if ((int)time % bulletTerm == 0)
                {
                    /////////////////////////////////////////////////////////좌방향///////////////////////////////////////////////////////////////////////////
                    leftz += rotSpeed;
                    if (leftz >= 360) leftz = 0;

                    this.transform.rotation = Quaternion.Euler(new Vector3(0, 0, 0));
                    this.transform.Rotate(0, 0, leftz);

                    temp = BossStepBullet.GetBossBulletStep(this.gameObject);
                    temp.transform.rotation = this.transform.rotation;
                    temp.GetComponent<Rigidbody2D>().AddForce(new Vector2(temp.transform.right.x, temp.transform.right.y) * bulletSpeed);

                    temp = BossStepBullet.GetBossBulletStep(this.gameObject);
                    temp.transform.rotation = this.transform.rotation;
                    temp.GetComponent<Rigidbody2D>().AddForce(new Vector2(temp.transform.up.x, temp.transform.up.y) * bulletSpeed);

                    temp = BossStepBullet.GetBossBulletStep(this.gameObject);
                    temp.transform.rotation = this.transform.rotation;
                    temp.GetComponent<Rigidbody2D>().AddForce(new Vector2(temp.transform.right.x, temp.transform.right.y) * -bulletSpeed);

                    temp = BossStepBullet.GetBossBulletStep(this.gameObject);
                    temp.transform.rotation = this.transform.rotation;
                    temp.GetComponent<Rigidbody2D>().AddForce(new Vector2(temp.transform.up.x, temp.transform.up.y) * -bulletSpeed);
                    /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                }
        }
        }
        if (hiddenMidBossStatus.boss_hp <= 1)
        {
            bossStepBullet.bossdead = true;
        }
    }

}
