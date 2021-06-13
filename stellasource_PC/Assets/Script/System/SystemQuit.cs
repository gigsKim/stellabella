using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SystemQuit : MonoBehaviour
{
    bool flag = false;
    float checktime = 0;

    // Update is called once per frame
    void Update()
    {

        if (flag)
        {

            checktime += Time.deltaTime;
            Debug.Log("뒤로가기 누른지 "+checktime + "초 지남");

            if(checktime >= 2)
            {
                flag = false;
                checktime = 0;
            }

           else if (checktime <= 2 && Input.GetKeyUp(KeyCode.Escape))
            {
                Application.Quit();
            }
        }

        if (Input.GetKeyUp(KeyCode.Escape))
        {
            flag = true;

        }
    }

    public void OnQuitBtn()
    {
        Debug.Log("종료");
        Application.Quit();
    }
}
