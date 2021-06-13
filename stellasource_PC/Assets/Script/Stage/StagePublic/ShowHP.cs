using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowHP : MonoBehaviour
{

    void Update()
    {
        this.GetComponent<Text>().text = Player_status.PS_hp+"";
    }
}
