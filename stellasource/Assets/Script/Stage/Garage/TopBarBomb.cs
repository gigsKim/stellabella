using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TopBarBomb : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        for(int i = 0; i < 5; i++)
        {
            this.transform.GetChild(i).GetComponent<Image>().color = new Color(0, 0, 0, 1f);
        }
        for (int i = 0; i < Player_status.PS_maxBomb; i++)
        {
            this.transform.GetChild(i).GetComponent<Image>().color = new Color(1, 1, 1, 0.2f);
        }
        for(int i = 0; i < Player_status.PS_bomb; i++)
        {
            this.transform.GetChild(i).GetComponent<Image>().color = new Color(1, 1, 1, 1f);
        }
    }
}
