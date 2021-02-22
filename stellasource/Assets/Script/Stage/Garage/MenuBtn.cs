using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuBtn : MonoBehaviour
{
    private bool checkOn = true;

    public void OnMenu()
    {
        if (checkOn)
        {
            checkOn = false;
            this.transform.GetChild(0).gameObject.SetActive(true);
        }
        else
        {
            checkOn = true;
            this.transform.GetChild(0).gameObject.SetActive(false);
        }
    }
}
