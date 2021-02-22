using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DroneBullet : MonoBehaviour
{
    public Transform parent;
    private void OnEnable()
    {
        this.transform.parent = null;
        this.GetComponent<Rigidbody2D>().AddForce(Vector2.right * 1000);
    }
    private void OnDisable()
    {
        this.transform.parent = parent;
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Enemy_normal" || other.tag == "Enemy_missile" || other.tag == "Boss")
        {
            this.transform.parent = parent;
            this.gameObject.SetActive(false);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.tag == "MainCamera")
        {
            
            this.transform.parent = parent;
            this.gameObject.SetActive(false);
        }
    }
}
