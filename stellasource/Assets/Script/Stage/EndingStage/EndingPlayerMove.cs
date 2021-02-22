using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndingPlayerMove : MonoBehaviour
{
    public float moveSpeed = 0.2f;
    public bool endingplayermove = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (endingplayermove)
        {
            this.transform.Translate(Vector2.right * moveSpeed);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(collision.tag);
        if (collision.tag == "earth")
        {
            endingplayermove = false;
            SceneManager.LoadScene("GameOver");
        }
    }
}
