using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explode_Delete : MonoBehaviour
{
    bool SetActiveSensor = false;
    float time = 0f;
    private void Update()
    {
        if (SetActiveSensor)
        {
            time += Time.deltaTime;
            if (time > 2.0f)
            {
                time = 0;
                this.SetActiveSensor = false;

                this.gameObject.SetActive(false);
            }
        }
    }
    private void OnEnable()
    {
        SetActiveSensor = true;
    }
}
