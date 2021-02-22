using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TopBarSP : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        Player_status.PS_maxsp = Player_status.PS_stage * 2 + (Player_status.PS_stage - 3);
        this.transform.GetChild(0).GetComponent<Text>().text = "SP\n" + Player_status.PS_sp + "/" + Player_status.PS_maxsp;
    }
}
