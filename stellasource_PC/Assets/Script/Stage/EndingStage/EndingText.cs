using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndingText : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        this.GetComponent<Text>().text = "지구를 구한 플레이어\n\n" + Player_status.PS_name;
    }

    // Update is called once per frame
  
}
