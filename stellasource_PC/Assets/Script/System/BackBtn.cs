using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackBtn : MonoBehaviour
{
    public GameObject gameStart;
    public GameObject load;
    public GameObject exit;
    public GameObject gameStartConfig;
    public GameObject loadPlate;
    public GameObject loadImage;
    public GameObject startPlate;
    public GameObject nick;
    public GameObject diff;
    // Start is called before the first frame update
    void Awake()
    {
        gameStart = GameObject.Find("Game_Start");
        load = GameObject.Find("Load");
        exit = GameObject.Find("Exit");
        gameStartConfig = GameObject.Find("GameStartConfig");
        loadPlate = GameObject.Find("LoadPlate");
        loadImage = GameObject.Find("LoadImg");
        startPlate = GameObject.Find("StartPlate");
        nick = GameObject.Find("Nick");
        diff = GameObject.Find("Diff");
    }

    // Update is called once per frame
    public void BackBtnclicked()
    {
        gameStart.SetActive(true);
        load.SetActive(true);
        exit.SetActive(true);
        gameStartConfig.SetActive(false);
        loadPlate.SetActive(false);
        loadImage.SetActive(false);
        startPlate.SetActive(false);
    }
}
