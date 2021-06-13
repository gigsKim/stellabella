using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class LoadingToStage : MonoBehaviour
{
    // Start is called before the first frame update

    public void Start()
    {
        
    }
    public void OnNextStageBtn()
    {
        SceneManager.LoadScene("Stage" + Player_status.PS_stage);
    }
}
