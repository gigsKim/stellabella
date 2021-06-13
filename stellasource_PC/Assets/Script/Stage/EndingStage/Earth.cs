using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Earth : MonoBehaviour
{
    public float moveSpeed = 10.0f;
    bool move = true;
    public EndingPlayerMove endingPlayerMove;
    // Start is called before the first frame update

    void Update()
    {
        if (move)
        {
            this.transform.Translate(Vector2.left * moveSpeed);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(collision.tag);
        if (collision.tag == "background")
        {
            endingPlayerMove.endingplayermove = true;
            move = false;
        }
    }
}
