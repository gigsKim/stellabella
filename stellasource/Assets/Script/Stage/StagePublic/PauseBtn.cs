using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseBtn : MonoBehaviour
{
    public bool pause = false;
    // Start is called before the first frame update
   public void pausePressed()
    {
        if (pause == false)
        {
            Time.timeScale = 0f;
            this.transform.GetChild(0).gameObject.SetActive(true);
            pause = true;
        }
        else if(pause== true)
        {
            Time.timeScale = 1.0f;
            this.transform.GetChild(0).gameObject.SetActive(false);
            pause = false;
        }
    }
}
