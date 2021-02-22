using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TuToToStart : MonoBehaviour
{
    // Start is called before the first frame update
    public void TuToToStartB()
    {
        Time.timeScale = 1f;
        Player_status.DBSetUser();
        LoadingSceneManager.LoadScene("TitleScene");

    }
}
