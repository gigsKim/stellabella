using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TopBarHP : MonoBehaviour
{
    private void Update()
    {
        this.transform.GetChild(0).GetComponent<Text>().text = "HP\n" + Player_status.PS_hp +"/" + Player_status.PS_maxHp;
    }
}
