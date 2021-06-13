using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TopBarNextStageBtn : MonoBehaviour
{

    public void OnNextStageBtn()
    {


        SceneManager.LoadScene("LoadingScene2");
       
    }
}
