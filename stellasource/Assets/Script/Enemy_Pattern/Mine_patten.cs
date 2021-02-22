using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mine_patten : MonoBehaviour
{

    float time = 0;

    void OnEnable()
    {
    }

    void OnDisable()
    {


     
        this.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        time = 0;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
      
    }

    void Update()
    {
        /*if (time == 0)
        {
            
            this.GetComponent<Rigidbody2D>().AddForce(new Vector3(0, -200, 0));
        }*/
        gameObject.transform.Translate(0, -0.1f, 0);
       // time += Time.deltaTime;
    }
}
