using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spaceDoormove : MonoBehaviour
{
    float time;

    // Update is called once per frame
    void Update()
    {


        time += Time.deltaTime;

        if(time >= 8)
        {

            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector3(0, -200, 0));
        }
    }
}
