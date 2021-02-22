using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySkyTerror : MonoBehaviour
{
    void OnEnable()
    {
        this.GetComponent<Rigidbody2D>().AddForce(new Vector3(-1100, 0, 0));
    }
    void OnDisable()
    {
        this.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
    }

}
