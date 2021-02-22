using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_normal_just_move_1 : MonoBehaviour
{
    void OnEnable()
    {
        this.GetComponent<Rigidbody2D>().AddForce(new Vector3(-200, 0, 0));
    }
  
    void OnDisable()
    {
        this.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
    }

}
