using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class showdiff : MonoBehaviour
{


    // Update is called once per frame
    void Update()
    {

        if (Player_status.PS_easyMode == 1)
        {
            this.GetComponent<Text>().text = "Easy";
        }

        if (Player_status.PS_easyMode == 0)
        {
            this.GetComponent<Text>().text = "Hard";
        }

    }
}
