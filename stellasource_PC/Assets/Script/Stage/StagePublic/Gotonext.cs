using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Gotonext : MonoBehaviour
{
    public bool alldie = false;

    IEnumerator next()
    {
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene("stage3_2");
        yield return null;

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            if(alldie == true)
            {
                StartCoroutine("next");
            }

            Debug.Log("와 샌즈");

        }



    }
}
