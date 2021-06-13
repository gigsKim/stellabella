using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finalbosspatten3 : MonoBehaviour
{

    GameObject bullet2;
    int speed = 450;
    int twoShoting = 50;
    float time = 0;
    bool first = true;
    public GameObject bullet;
    IEnumerator SpellStart_2()
    {
        float angle = 360 / twoShoting;

        do
        {

            for (int i = 0; i < twoShoting; i++)
            {


                bullet2 = BossBullet.GetBossBullet(this.gameObject);


                bullet2.GetComponent<Rigidbody2D>().AddForce(new Vector2(speed * Mathf.Cos(Mathf.PI * 2 * i / twoShoting), speed * Mathf.Sin(Mathf.PI * i * 2 / twoShoting)));


                bullet2.transform.Rotate(new Vector3(0f, 0f, 180 * i / twoShoting - 90));
            }




            yield return new WaitForSeconds(1.5f);
        } while (true);
    }
    private void Update()
    {
        time += Time.deltaTime;

      
        if (time >= 3)
        {

            if (first == true)
            {

               
                StartCoroutine("SpellStart_2");
                first = false;
            }

            time = 0;
        }
    }


}
