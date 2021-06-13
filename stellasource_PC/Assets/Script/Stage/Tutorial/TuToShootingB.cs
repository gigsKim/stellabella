using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TuToShootingB : MonoBehaviour
{
    public Player_charge stb;
    public TutoralStage tutoralStage;
    // Start is called before the first frame update
    void Start()
    {
        stb = GameObject.Find("A_but").GetComponent<Player_charge>();
        tutoralStage = GameObject.Find("MainCamera").GetComponent<TutoralStage>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.Z))
        {
            tutoshoot();
        }
    }

    public void tutoshoot()
    {
        if (tutoralStage.shoottuto)
        {
            stb.player_fired_check = true;
            tutoralStage.shoottuto = false;
            Time.timeScale = 1f;
        }
    }
}
