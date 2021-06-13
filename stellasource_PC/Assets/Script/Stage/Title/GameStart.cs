using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameStart : MonoBehaviour
{
    // Start is called before the first frame update
    public InputField ip;
    public Toggle easy;
    public Toggle hard;
    public GameObject needNick;
    private void Start()
    {
        this.transform.GetChild(0).gameObject.SetActive(false);
        this.transform.GetChild(1).gameObject.SetActive(false);
    }
    //닉네임과 이지모드 받고 슬롯 켬
    public void Game_Start()
    {
        if (ip.text == "")
        {
            needNick.SetActive(true);
            needNick.GetComponent<Text>().text = "Need Write Name";
            return;
        }
        else if (ip.text != "")
        {
            Player_status.PS_name = ip.text;
            Debug.Log("nickname :" + Player_status.PS_name);
            if (easy.isOn)
            {
                Player_status.PS_easyMode = 1;
                Debug.Log("현재 난이도 : "+Player_status.PS_easyMode);
            }
            else if (hard.isOn)
            {
                Player_status.PS_easyMode = 0;
                Debug.Log("현재 난이도 : " + Player_status.PS_easyMode);
            }
            this.GetComponent<Load>().GameLoad();
        }
    }
}
