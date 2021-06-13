using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenStartConfig : MonoBehaviour
{
    public GameObject configplate;
    private void Start()
    {
        configplate = GameObject.Find("GameStartConfig");
        configplate.SetActive(false);
        
    }
   
    // Start is called before the first frame update
    public void OPen_StartConfig()
    {
        configplate.SetActive(true);
    }
}
