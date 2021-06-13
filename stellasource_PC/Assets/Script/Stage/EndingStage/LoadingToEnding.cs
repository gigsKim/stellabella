using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadingToEnding : MonoBehaviour
{
    // Start is called before the first frame update
    public void OnEndingStageBtn()
    {
        SceneManager.LoadScene("Stage7");
    }
}
