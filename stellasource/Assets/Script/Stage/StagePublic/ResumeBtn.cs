using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResumeBtn : MonoBehaviour
{
    public PauseBtn pauseBtn;
    public GameObject pauseplate;
    // Start is called before the first frame update
    public void resumePressed()
    {
        Time.timeScale = 1.0f;

        pauseBtn.pause = false;
        pauseplate.SetActive(false);
        
    }
    }
