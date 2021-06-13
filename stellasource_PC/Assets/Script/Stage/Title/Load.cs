using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Load : MonoBehaviour
{
    public LoadSlot loadSlot;

    public void Start()
    {
        this.transform.GetChild(0).gameObject.SetActive(false);
        this.transform.GetChild(1).gameObject.SetActive(false);
    }
    // Start is called before the first frame update
    public void GameLoad()
    {
        this.transform.GetChild(0).gameObject.SetActive(true);
        this.transform.GetChild(1).gameObject.SetActive(true);

        string temp = Player_status.DBLoadPlayerSlot();
        Debug.Log("템프"+temp);
        string[] slots = temp.Split(';');

        for(int i = 0; i < slots.Length - 1; i++)
        {
            Debug.Log("-------------------------------------\n"+
                "이 슬롯의 id = "+slots[i]);
            if (Convert.ToInt32(slots[i]) != 0)
            {
                loadSlot.OnSlot(i, Convert.ToInt32(slots[i]));
            }
        }
        print("슬롯 불러오기 완료");

    }
}
