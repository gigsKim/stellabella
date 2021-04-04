using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Combo : MonoBehaviour
{


    // Update is called once per frame
    void Update()
    {

        if (Player_status.combo < 1)
        {
            this.GetComponent<Text>().text = "";
        }

        if (Player_status.combo >= 1)
        {
            this.GetComponent<Text>().text = "<color=#ff0000>" + Player_status.combo + "</color>" + " Combo";
        }
    }
}
