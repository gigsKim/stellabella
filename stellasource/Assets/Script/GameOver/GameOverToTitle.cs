using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverToTitle : MonoBehaviour
{
    public void Start()
    {
        Player_status.DBEndGame();
    }

    // Start is called before the first frame update
    public void gameOverToTitle()
    {
        LoadingSceneManager.LoadScene("TitleScene");
    }
}
