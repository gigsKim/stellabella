using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Container : MonoBehaviour
{

    public GameObject obj;
    public Enemy_spawn_2 create;
    float time = 0;
    int createtime = 0;
    public bool firstmove = false;
    int Randomint = 0;


    void OnDisable()
    {
        this.gameObject.transform.Translate(0, 0, 0);
        //this.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        time = 0;
        createtime = 0;
        firstmove = false;

    }

    private void FixedUpdate()
    {
        if (firstmove == false)
        {
            this.gameObject.transform.Translate(-0.2f, 0, 0);
        }

        if(firstmove == false && createtime  < 1 )
        {
            if (time >= 0.6f)
            {
                this.gameObject.transform.Translate(0, 0, 0);
                firstmove = true;
            }

        }


        if(this.transform.position.y < 0)
        Randomint = 5;
        else
            Randomint = Random.Range(4, 6);

        time += Time.deltaTime;
        if(time >= 3.5f)
        {
            create.PrintEnemy2(obj, Randomint);
            time = 0;
            createtime++;
        }

        if(createtime >= 3)
        {
            transform.Translate(0.1f, 0, 0);

        }
    }


}
