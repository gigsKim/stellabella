using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TopBarStage : MonoBehaviour
{
    void Start()
    {
        this.GetComponent<Text>().text = "다음스테이지:" + (Player_status.PS_stage);
    }

}
