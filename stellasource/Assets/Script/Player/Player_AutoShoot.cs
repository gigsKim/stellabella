using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_AutoShoot : MonoBehaviour
{
    public AudioSource shotbgm;
    private GameObject[] bullet = new GameObject[12];

    //12의 약수만 설정가능
    
    public bool canshoot = true;
    private int delay = 0;
    private int bullet_shoot_count = 0;

    //총알 이미지스프라이트(하이어라키에서 달아줘야됨) 0,1,2 레벨별로 0은 명시적으로 생성함
    public Sprite[] sprites = new Sprite[3];

    private void Start()
    {
        for (int i = 0; i < 12; i++)
        {
            bullet[i] = GameObject.Find("bullet_green" + i);
        }
        switch (Player_status.PS_bulletLevel)
        {
            case 1:
                for (int i = 0; i < 12; i++)
                {
                    bullet[i].GetComponent<Player_Bullet>().damage = 2;
                    bullet[i].GetComponent<SpriteRenderer>().sprite = sprites[1];
                }
                Debug.Log("Bullet_Level1");
                break;
            case 2:
                for (int i = 0; i < 12; i++)
                {
                    bullet[i].GetComponent<Player_Bullet>().damage = 3;
                    bullet[i].GetComponent<SpriteRenderer>().sprite = sprites[2];
                }
                Debug.Log("Bullet_Level2");
                break;
            default:
                Debug.Log("Bullet_Level0");
                break;
        }

    }

    void FixedUpdate()
    {
        if (!Player_status.isDead)
        {
            if (canshoot)
            {
                if (delay % 15 == 0)
                {
                    if (bullet_shoot_count == 12)
                    {
                        bullet_shoot_count = 0;
                    }
                  
                    for (int i = bullet_shoot_count; i <= bullet.Length; i++)
                    {
                       
                            if (i % 12 == 12 - 1)
                            {
                                bullet_shoot_count++;
                                bullet[i].transform.localPosition = new Vector3(0, 0, 1);
                                bullet[i].GetComponent<CapsuleCollider2D>().enabled = true;
                                bullet[i].transform.parent = null;
                                shotbgm.Play();
                                break;
                            }
                            else
                            {
                                bullet_shoot_count++;
                                bullet[i].transform.localPosition = new Vector3(0, 0, 1);
                                bullet[i].GetComponent<CapsuleCollider2D>().enabled = true;
                                bullet[i].transform.parent = null;
                                shotbgm.Play();
                            break;
                            }
                            
                        
                    
                    }
                }
                
                delay++;
            }
        }
    }
}
