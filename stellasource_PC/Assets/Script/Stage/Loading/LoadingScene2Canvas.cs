using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadingScene2Canvas : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        switch (Player_status.PS_stage)
        {
            case 1:
                for (int i = 0; i < this.transform.childCount; i++)
                {
                    if (this.transform.GetChild(i).gameObject.name == "Stage1")
                    {
                        this.transform.GetChild(i).gameObject.SetActive(true);
                    }
                }
                break;
            case 2:
                for (int i = 0; i < this.transform.childCount; i++)
                {
                    if (this.transform.GetChild(i).gameObject.name == "Stage2")
                    {
                        this.transform.GetChild(i).gameObject.SetActive(true);
                    }
                }
                break;
           
            case 3:
                for (int i = 0; i < this.transform.childCount; i++)
                {
                    if (this.transform.GetChild(i).gameObject.name == "Stage3")
                    {
                        this.transform.GetChild(i).gameObject.SetActive(true);
                    }
                }
                break;
            case 4:
                for (int i = 0; i < this.transform.childCount; i++)
                {
                    if (this.transform.GetChild(i).gameObject.name == "Stage4")
                    {
                        this.transform.GetChild(i).gameObject.SetActive(true);
                    }
                }
                break;
            case 5:
                for (int i = 0; i < this.transform.childCount; i++)
                {
                    if (this.transform.GetChild(i).gameObject.name == "Stage5")
                    {
                        this.transform.GetChild(i).gameObject.SetActive(true);
                    }
                }
                break;
            case 6:
                for (int i = 0; i < this.transform.childCount; i++)
                {
                    if (this.transform.GetChild(i).gameObject.name == "Stage6")
                    {
                        this.transform.GetChild(i).gameObject.SetActive(true);
                    }
                }
                break;
            case 7:
                for (int i = 0; i < this.transform.childCount; i++)
                {
                    if (this.transform.GetChild(i).gameObject.name == "Stage7")
                    {
                        this.transform.GetChild(i).gameObject.SetActive(true);
                    }
                }
                break;
        }
    }

    // Update is called once per frame
  
}
