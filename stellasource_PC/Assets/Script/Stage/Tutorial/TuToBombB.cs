using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class TuToBombB : MonoBehaviour
{
    // Start is called before the first frame update
    public Player_Bomb Pb;        //Boom_area에서 참조함
    public GameObject[] activeBomb;
    public TutoralStage tutoralStage;


    public int maxBomb = Player_status.PS_maxBomb;
    public int bombCount = Player_status.PS_bomb;
    private void Start()
    {
        Pb = GameObject.Find("BombB").GetComponent<Player_Bomb>();
       
        tutoralStage = GameObject.Find("MainCamera").GetComponent<TutoralStage>();
    }

    public void Update()
    {
        if (Input.GetKey(KeyCode.X))
        {
            boobdown();
        }
    }
    public void boobdown()
    {
        if (tutoralStage.boomtuto)
        {
            Time.timeScale = 1f;
            Pb.boomOn = true;
            tutoralStage.boomtuto = false;
        }
           
        
    }
}
