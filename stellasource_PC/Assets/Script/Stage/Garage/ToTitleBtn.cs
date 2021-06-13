using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToTitleBtn : MonoBehaviour
{
    public void OnTitleBtn()
    {
        LoadingSceneManager.LoadScene("TitleScene");
    }
}
