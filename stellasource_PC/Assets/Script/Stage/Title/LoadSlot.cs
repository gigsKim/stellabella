using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadSlot : MonoBehaviour
{
    GameObject slot;
    string[] temp = null;

    public void OnSlot(int idx, int value)
    {
       
        //db에서 값 가져옴
        slot = this.transform.GetChild(idx).GetChild(0).gameObject;
        temp = Player_status.DBLoadPlayerSlotDB(value);
        
    
        
        Debug.Log("LoadSlot = " + temp[0] + "," + temp[1] + "," + temp[2]);

        //NotEmpty 켜주고 empty꺼줌
        slot.SetActive(true);
        this.transform.GetChild(idx).GetChild(1).gameObject.SetActive(false);

        //내용 삽입
        slot.transform.GetChild(1).GetComponent<Text>().text = "NickName : " + temp[0];
        slot.transform.GetChild(2).GetComponent<Text>().text = "Stage : " + temp[1];
        slot.transform.GetChild(3).GetComponent<Text>().text = "Score : " + temp[2];
        
    }
}
