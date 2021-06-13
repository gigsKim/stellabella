using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_shoot : MonoBehaviour
{
    //오디오 소스 걸어줘야함
    public AudioSource shotbgm;

    //총알과 슈팅버튼 관리
    private GameObject[] bullet;
    public Player_charge stb;

    //12의 약수만 설정가능
    public int player_fire_max = 4;

    //사격관련 변수
    private int delay = 0;
    private int bullet_shoot_count = 0;
    private int bullet_shoot_stay = 0;
    private bool shoot_check = true;

    //총알 이미지스프라이트(하이어라키에서 달아줘야됨) 0,1,2 레벨별로 0은 명시적으로 생성함
    public Sprite[] sprites = new Sprite[3];

    // 하이어라키에 오브젝트 찾기
    void Awake()
    {
        stb = GameObject.Find("A_but").GetComponent<Player_charge>();
        bullet = new GameObject[12];
        for(int i = 0; i < 12; i++)
        {
            bullet[i] = this.transform.GetChild(3).GetChild(i).gameObject;
        }
    }

    private void Start()
    {
        switch (Player_status.PS_bulletLevel)
        {
            case 1:
                for(int i = 0; i < 12; i++)
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
    // A버튼이 눌리면 시간이 증가하고(탄환간격) bullet_shoot_stay;
    // z축앞으로 꺼내서 부모관계를 끊고 콜라이더 활성화 후 자체스크립트에서 이동명령수행
    // 발사후 for문 탈출 A버튼 누른거 비활성화
    // stay가 10이될때까지 기다림
    // 한번발사에 i가 player_fire_max에 도달하면 배열인덱스위치값(bullet_shoot_count)제외 초기값으로
    void FixedUpdate()
    {
        if (stb.player_fired_check && delay % 20 == 0)
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
                    if (i % player_fire_max == player_fire_max-1)
                    {
                        bullet_shoot_count++;
                        bullet[i].transform.localPosition = new Vector3(0, 0, 1);
                        bullet[i].GetComponent<CapsuleCollider2D>().enabled = true;
                        bullet[i].transform.parent = null;
                        bullet_shoot_stay = 0;
                        shotbgm.Play();
                        stb.player_fired_check = false;
                        break;
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
                    break;
                }
                else
                {
                    break;
                }
            }
        }
        else
        {
            delay++;
        }
    }

   
}
