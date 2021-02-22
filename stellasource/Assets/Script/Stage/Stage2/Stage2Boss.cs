using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage2Boss : MonoBehaviour
{
    public float step;
    public float steptime;
    public bool phase1 = true;
    // Update is called once per frame
    void Update()
    {
        if(step >= steptime)
        {
            phase1 = !phase1;
            step = 0;
        }
        step += Time.deltaTime;
        if (phase1)
        {
            this.transform.GetChild(0).gameObject.SetActive(true);
            this.transform.GetChild(1).gameObject.SetActive(true);
            this.transform.GetChild(2).gameObject.SetActive(false);
        }
        else
        {
            this.transform.GetChild(0).gameObject.SetActive(false);
            this.transform.GetChild(1).gameObject.SetActive(false);
            this.transform.GetChild(2).gameObject.SetActive(true);
        }
    }
}
