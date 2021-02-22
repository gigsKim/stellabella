using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_boss_stage1_phase : MonoBehaviour
{
    float time;
    float hp;
    bool phase_change =true;
    bool boss_positionstop = true;

        // Start is called before the first frame update
    void Start()
    {
        time = 0;
        
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        hp = this.GetComponent<Boss_status>().boss_hp;
        boss_positionstop = this.GetComponent<Boss_status>().boss_positionstop;
        if (!boss_positionstop && time <= 1.5)
        {
            this.GetComponent<Enemy_boss_patternX4>().enabled = true;
            boss_positionstop = true;


        }
         if (hp <= 150f&&phase_change)
        {
            Debug.Log("phase change");
            this.GetComponent<Enemy_boss_patternX4>().enabled = false;
            this.GetComponent<Enemy_boss_pattern1>().enabled = true;
            
            phase_change = false;
        }
    }
}
