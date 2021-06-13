using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SlotClicked : MonoBehaviour
{
    public GameObject overwrite;

    //스타트를 통해 들어간 슬롯 클릭 시
    public void StartSlotClicked()
    {
        string slotIdx = this.gameObject.name;
        Debug.Log(slotIdx);
        slotIdx = slotIdx.Replace("LoadSlot", "");
        Player_status.slotNow = Convert.ToInt32(slotIdx);
        if (Player_status.DBSavePreference(Convert.ToInt32(slotIdx)))
        {
            SceneManager.LoadScene("LoadingScene2");
        }
        else
        {
            overwrite.SetActive(true);
        }
    }

    //로드를 통해 들어간 슬롯 클릭 시
    public void LoadSlotClicked()
    {
        if (this.transform.GetChild(0).gameObject.activeSelf == true)
        {
            string temp = this.transform.GetChild(0).GetChild(1).GetComponent<Text>().text;
            string[] txt = temp.Split(':');

            Player_status.DBLoadPreference(txt[1].Trim());

            if (Player_status.PS_stage == 1)
            {
                SceneManager.LoadScene("LoadingScene2");
            }
            else
            {
                LoadingSceneManager.LoadScene("Garage");
            }
        }
    }

    
}
