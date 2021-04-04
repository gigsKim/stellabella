using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBossPatternLeftCircle : MonoBehaviour
{
    //회전속도
    public int rotSpeed = 5;
    //총알 속도
    public int bulletSpeed = 100;
    //총알 간격
    public int bulletTerm = 10;
    
    float leftz = 0;
    GameObject temp;
    public GameObject bullet;
    float time;
    void FixedUpdate()
    {
        time++;
        if ((int)time % bulletTerm == 0)
        {
            /////////////////////////////////////////////////////////좌방향///////////////////////////////////////////////////////////////////////////
            leftz += rotSpeed;
            if (leftz >= 360)   leftz = 0;

            this.transform.rotation = Quaternion.Euler(new Vector3(0, 0, 0));
            this.transform.Rotate(0, 0, leftz);
            
            temp = BossBullet.GetBossBullet(this.gameObject);
            temp.transform.rotation = this.transform.rotation;
            temp.GetComponent<Rigidbody2D>().AddForce(new Vector2(temp.transform.right.x, temp.transform.right.y) * bulletSpeed);

            temp = BossBullet.GetBossBullet(this.gameObject);
            temp.transform.rotation = this.transform.rotation;
            temp.GetComponent<Rigidbody2D>().AddForce(new Vector2(temp.transform.up.x, temp.transform.up.y) * bulletSpeed);

            temp = BossBullet.GetBossBullet(this.gameObject);
            temp.transform.rotation = this.transform.rotation;
            temp.GetComponent<Rigidbody2D>().AddForce(new Vector2(temp.transform.right.x, temp.transform.right.y) * -bulletSpeed);

            temp = BossBullet.GetBossBullet(this.gameObject);
            temp.transform.rotation = this.transform.rotation;
            temp.GetComponent<Rigidbody2D>().AddForce(new Vector2(temp.transform.up.x, temp.transform.up.y) * -bulletSpeed);
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        }
    }

}
