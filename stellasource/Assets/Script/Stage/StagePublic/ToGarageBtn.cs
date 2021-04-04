using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToGarageBtn : MonoBehaviour
{
    // Start is called before the first frame update
    public void GoToHanGar()
    {
        
        Player_status.PS_stage++;
        Player_status.PS_sp += 3;
        Player_status.PS_bomb = Player_status.PS_maxBomb;
        Player_status.PS_instanceDrone = 0;
        
        if (Player_status.PS_stage < 7)
        {
            Player_status.combo = 0;
            LoadingSceneManager.LoadScene("Garage");
           
        }
        else if(Player_status.PS_stage  == 7)
        {
            Player_status.combo = 0;
            SceneManager.LoadScene("LoadingScene2");
        }
    }
}
