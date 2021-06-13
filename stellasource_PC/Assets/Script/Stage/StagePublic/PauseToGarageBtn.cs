using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseToGarageBtn : MonoBehaviour
{
    // Start is called before the first frame update
   public void ToGarage()
    {
        if (Player_status.PS_stage != 1)
        {
            Time.timeScale = 1.0f;
            Player_status.DBLoadPreference();
            LoadingSceneManager.LoadScene("Garage");
        }

    }
}
