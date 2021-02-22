using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rapidmissle_patten : MonoBehaviour

{

    void OnEnable()
    {
        GetComponent<Rigidbody2D>().AddForce(new Vector3(-900, 0, 0));
    }

    void OnDisable()
    {
        this.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        
    }

    // Start is called before the first frame update
    /*void Start()
    {
        GetComponent<Rigidbody2D>().AddForce(new Vector3(-450, 0, 0));
    }*/

 
}
