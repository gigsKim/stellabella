using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitBtn : MonoBehaviour
{
    // Start is called before the first frame update
    public void ToExitBtn()
    {
        Time.timeScale = 1.0f;
        LoadingSceneManager.LoadScene("TitleScene");
    }
}
