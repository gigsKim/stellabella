using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitBtn : MonoBehaviour
{
    // Start is called before the first frame update
    public void ToExitBtn()
    {
        Player_status.combo = 0;
        Time.timeScale = 1.0f;
        LoadingSceneManager.LoadScene("TitleScene");
    }
}
