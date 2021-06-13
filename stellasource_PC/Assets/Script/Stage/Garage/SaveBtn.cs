using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveBtn : MonoBehaviour
{
    public void OnSaveBtn()
    {
        Player_status.DBUpdate();
        this.transform.GetChild(0).gameObject.SetActive(true);
    }
}
