﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class GarageManager : MonoBehaviour
{
    private GameObject Btn;
    public Transform[] Items;
    //UpgradeBtn이나 GearBtn을 누르면 작동(걸어줄것)
    //temp는 Upgrade 또는 Gear의 오브젝트
    public void OnSaleBtn()
    {
        Btn = EventSystem.current.currentSelectedGameObject;                        //버튼객체담고

        GameObject temp = Btn.transform.parent.gameObject;                          //버튼의 부모객체담고
        Debug.Log(temp);
        if (temp.name.Equals("Upgrade"))                               //맨처음 두개의 ui 이미지 끄기
        {
            this.transform.GetChild(0).GetComponent<Image>().enabled = false;
            this.transform.GetChild(1).gameObject.SetActive(false);

            Items[0].parent.gameObject.SetActive(true);
            for (int i = 0; i < Items.Length/2; i++)
            {
                Items[i].gameObject.SetActive(true);
                Items[i].GetComponent<Image>().enabled = true;
                Items[i].GetComponent<Button>().enabled = true;
            }
        }
        else if (temp.name.Equals("Gear"))
        {
            this.transform.GetChild(0).gameObject.SetActive(false);
            this.transform.GetChild(1).GetComponent<Image>().enabled = false;

            Items[5].parent.gameObject.SetActive(true);
            for (int i = Items.Length / 2; i < Items.Length; i++)
            {
                Items[i].gameObject.SetActive(true);
                Items[i].GetComponent<Image>().enabled = true;
                Items[i].GetComponent<Button>().enabled = true;
            }
        }

        //버튼의 부모에서 상점만켜고 버튼은 끄기
        temp.transform.GetChild(0).gameObject.SetActive(true);
        temp.transform.GetChild(1).gameObject.SetActive(false);

    }

    public void OnCloseBtn()
    {
        Btn = EventSystem.current.currentSelectedGameObject;
        GameObject temp = Btn.transform.parent.parent.gameObject;

        this.transform.GetChild(0).GetComponent<Image>().enabled = true;       //맨처음 두개의 ui 이미지 켜기
        this.transform.GetChild(1).GetComponent<Image>().enabled = true;

        this.transform.GetChild(0).gameObject.SetActive(true);
        this.transform.GetChild(1).gameObject.SetActive(true);


        temp.transform.GetChild(0).gameObject.SetActive(false);
        temp.transform.GetChild(1).gameObject.SetActive(true);

        for (int i = 0; i < Items.Length; i++)
        {
            Items[i].GetChild(0).gameObject.SetActive(false);
            Items[i].GetChild(1).GetChild(0).gameObject.SetActive(false);
            Items[i].GetChild(1).gameObject.SetActive(false);
        }
    }
}
