using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Middlebosspatten : MonoBehaviour
{
    public float boss_hp = 10;


    public Gotonext_1 go_st5;

    bool co_check = true;


    int num = 0;
    float firsttime = 0;
    float checktime = 0;
    int check = 0;
    int Randomattack = 0;
    bool pattencheck = false;
    bool gotopatten = false;

    public GameObject attackball1;
    public GameObject attackball2;


    public GameObject chaser1;
    public GameObject chaser2;
    public GameObject chaser3;
    public GameObject chaser4;
    public GameObject chaser5;

    // Start is called before the first frame update
    void Start()
    {
        go_st5 = transform.parent.gameObject.GetComponent<Gotonext_1>();
        attackball1 = transform.GetChild(0).gameObject.transform.GetChild(0).gameObject;
        attackball2 = transform.GetChild(0).gameObject.transform.GetChild(1).gameObject;

        chaser1 = transform.GetChild(1).gameObject.transform.GetChild(0).gameObject;
        chaser2 = transform.GetChild(1).gameObject.transform.GetChild(1).gameObject;
        chaser3 = transform.GetChild(1).gameObject.transform.GetChild(2).gameObject;
        chaser4 = transform.GetChild(1).gameObject.transform.GetChild(3).gameObject;
        chaser5 = transform.GetChild(1).gameObject.transform.GetChild(4).gameObject;
        


    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Bullet_Player")
        {
            if (collision.gameObject.name == "DroneBullet")
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
        if (collision.tag == "Boom")
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

    IEnumerator patten2()
    {

        chaser1.SetActive(true);
        chaser2.SetActive(true);
        chaser3.SetActive(true);
        chaser4.SetActive(true);
        chaser5.SetActive(true);


        chaser1.GetComponent<Rigidbody2D>().AddForce(new Vector3(-200, -140, 0));
        chaser2.GetComponent<Rigidbody2D>().AddForce(new Vector3(-200, -70, 0));
        chaser3.GetComponent<Rigidbody2D>().AddForce(new Vector3(-200, 0, 0));
        chaser4.GetComponent<Rigidbody2D>().AddForce(new Vector3(-200, 70, 0));
        chaser5.GetComponent<Rigidbody2D>().AddForce(new Vector3(-200, 140, 0));

       yield return new WaitForSeconds(1.8f); 
        
        chaser1.GetComponent<Chaser>().chaseon = true;
        chaser2.GetComponent<Chaser>().chaseon = true;
        chaser3.GetComponent<Chaser>().chaseon = true;
        chaser4.GetComponent<Chaser>().chaseon = true;
        chaser5.GetComponent<Chaser>().chaseon = true;

        yield return new WaitForSeconds(3f);
    
        chaser1.GetComponent<Chaser>().deleteon = true;
        chaser2.GetComponent<Chaser>().deleteon = true;
        chaser3.GetComponent<Chaser>().deleteon = true;
        chaser4.GetComponent<Chaser>().deleteon = true;
        chaser5.GetComponent<Chaser>().deleteon = true;


        yield return new WaitForSeconds(0.5f);
        pattencheck = false;
        Debug.Log("패턴종료");
        yield return null;
    }


        IEnumerator patten1()
    {
        attackball1.SetActive(true);
        attackball2.SetActive(true);
        attackball1.GetComponent<Rigidbody2D>().AddForce(new Vector3(-200, -100, 0));
        attackball2.GetComponent<Rigidbody2D>().AddForce(new Vector3(-200, 100, 0));
        yield return new WaitForSeconds(1.8f);
        attackball1.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        attackball1.transform.GetChild(0).GetComponent<Attackballsc>().min = false;
        attackball2.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        attackball2.transform.GetChild(0).GetComponent<Attackballsc>().min = false;
        yield return new WaitForSeconds(10);

       
        attackball1.transform.GetChild(0).GetComponent<Attackballsc>().min = true;
        attackball2.transform.GetChild(0).GetComponent<Attackballsc>().min = true;
        yield return new WaitForSeconds(1.3f);

        attackball1.transform.GetChild(0).GetComponent<Attackballsc>().pattenend = true;
        attackball2.transform.GetChild(0).GetComponent<Attackballsc>().pattenend = true;

        yield return new WaitForSeconds(0.5f);
        pattencheck = false;

        yield return null;
    }

    public void Update()
    {

      
       if(boss_hp <= 0)
        {

            go_st5.isgo = true;
            this.gameObject.SetActive(false);
         }


        if(pattencheck == false)
        firsttime += Time.deltaTime;
        

            if(firsttime >= 3f && pattencheck == false)
            {
            Randomattack = Random.Range(0, 2);
            firsttime = 0;
            pattencheck = true;
            gotopatten = true;
            }


        if (pattencheck == true)
        {

            if (gotopatten == true)
            {
                switch (Randomattack)
                {

                    case 0:
                        {
                            StartCoroutine("patten1");
                            Debug.Log("패턴시작");
                            gotopatten = false;
                            
                        }
                        break;

                    case 1:
                        {
                            StartCoroutine("patten2");
                            Debug.Log("패턴시작2");
                            gotopatten = false;
                           
                        }
                        break;

               


                }
            }

        }



    }
}
