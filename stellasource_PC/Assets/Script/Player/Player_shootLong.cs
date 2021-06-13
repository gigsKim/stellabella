using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_shootLong : MonoBehaviour
{
    public AudioSource shotbgm;
    public GameObject[] bullet;


    //12의 약수만 설정가능
    public int player_fire_max = 4;

    int bullet_shoot_count = 0;
    int bullet_shoot_stay = 0;
    private bool shoot_check = true;


    // 하이어라키에 오브젝트 찾기
    void Awake()
    {
       
        for (int i = 0; i < 12; i++)
        {
            bullet[i] = GameObject.Find("bullet_green" + i);
        }
    }

    // A버튼이 눌리면 시간이 증가하고(탄환간격) bullet_shoot_stay;
    // z축앞으로 꺼내서 부모관계를 끊고 콜라이더 활성화 후 자체스크립트에서 이동명령수행
    // 발사후 for문 탈출 A버튼 누른거 비활성화
    // stay가 10이될때까지 기다림
    // 한번발사에 i가 player_fire_max에 도달하면 배열인덱스위치값(bullet_shoot_count)제외 초기값으로
    void FixedUpdate()
    {
        
            if (bullet_shoot_count == 12)
            {
                bullet_shoot_count = 0;
            }
            bullet_shoot_stay++;
            for (int i = bullet_shoot_count; i <= bullet.Length; i++)
            {

                if (shoot_check)
                {
                    if (i % player_fire_max == player_fire_max - 1)
                    {
                        bullet_shoot_count++;
                        bullet[i].transform.localPosition = new Vector3(0, 0, 1);
                        bullet[i].GetComponent<CapsuleCollider2D>().enabled = true;
                        bullet[i].transform.parent = null;
                        bullet_shoot_stay = 0;
                        shotbgm.Play();

                 
                    }
                    else
                    {
                        bullet_shoot_count++;
                        bullet[i].transform.localPosition = new Vector3(0, 0, 1);
                        bullet[i].GetComponent<CapsuleCollider2D>().enabled = true;
                        bullet[i].transform.parent = null;
                        bullet_shoot_stay = 0;
                        shotbgm.Play();
                    }
                    shoot_check = false;
                }
                else if (bullet_shoot_stay >= 10)
                {
                    shoot_check = true;
                    bullet_shoot_stay = 0;
                    
                }
                else
                {
                    
                }
            }
        
    }
}
