using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverBgm : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       

    }
    private void Update()
    {
        if (Player_status.PS_hp <= 0)
        {
            this.transform.GetChild(1).gameObject.SetActive(false);
        }
        else if(Player_status.PS_hp > 0)
        {
            this.transform.GetChild(2).gameObject.SetActive(false);
        }
    }
    // Update is called once per frame

}
