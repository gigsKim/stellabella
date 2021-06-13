using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Combo : MonoBehaviour
{


    // Update is called once per frame
    void Update()
    {
        //콤보가 없을 경우 0으로 표시
        if (Player_status.combo < 1)
        {
            this.GetComponent<Text>().text = "";
        }

        //콤보가 있을 경우 표시
        if (Player_status.combo >= 1)
        {
            this.GetComponent<Text>().text = "<color=#ff0000>" + Player_status.combo + "</color>" + " Combo";
        }
    }
}
