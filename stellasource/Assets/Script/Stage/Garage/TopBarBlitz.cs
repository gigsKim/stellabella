using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TopBarBlitz : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        for(int i = 0; i < 5; i++)
        {
            this.transform.GetChild(i).GetComponent<Image>().color = new Color(0, 0, 0, 255);
        }
        for(int i = 0; i < Player_status.PS_blitz; i++)
        {
            this.transform.GetChild(i).GetComponent<Image>().color = new Color(255, 255, 255, 255);
        }
    }
}
