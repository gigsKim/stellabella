using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TouchToStart : MonoBehaviour
{
    bool active = true;
    bool coactive = true;

    // Start is called before the first frame update
    void Start()
    {
        active = true;
        this.transform.gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (coactive)
        {
            StartCoroutine(ActiveDeActive());
            coactive = false;
        }
        if (Input.anyKey)
        {
            this.transform.gameObject.SetActive(false);
        }
    }
    IEnumerator ActiveDeActive()
    {
        if (active)
        {
            this.transform.GetComponent<Text>().enabled=false;
            
            yield return new WaitForSeconds(0.5f);
            active = false;
            coactive = true;

        }
        else if (active==false)
        {
            this.transform.GetComponent<Text>().enabled = true;
            
            yield return new WaitForSeconds(0.5f);
            active = true;
            coactive = true;

        }
    }
}
