using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TopBarScore : MonoBehaviour
{

    void Update()
    {
        this.transform.GetChild(0).GetComponent<Text>().text = "Score\n" + Player_status.PS_score;
    }
}
