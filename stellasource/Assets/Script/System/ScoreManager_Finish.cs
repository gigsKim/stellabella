using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager_Finish : MonoBehaviour
{
    public int invCount = 0;
    public int bombCount = 0;
    public BlitzInvincible blitzInvincible;
    public Player_Bomb player_Bomb;
    public bool bossdead = false;
    public GameObject scoreManager_Finish;
    private float finishScreenTimer = 0;
    private bool finishScreen = true;

    public bool ismissionon= true;
    public bool missionclear = false;
    public int missionscore = 0;
    public bool lastscore = true;


    private double score;
    private void Start()
    {
        blitzInvincible = GameObject.Find("Core").GetComponent<BlitzInvincible>();
        player_Bomb = GameObject.Find("BombB").GetComponent<Player_Bomb>();
        scoreManager_Finish = GameObject.Find("Finish_screen");
        bombCount = player_Bomb.bombCount;
        

    }

    private void setsocre()
    {
        if(lastscore == true)
        {

            
            score -= (invCount * 3000);
            score -= (bombCount * 15000);
            score += missionscore;
            lastscore = false;
            
        }

    }
    private void Update()
    {
        invCount = blitzInvincible.blitz_used_count;
        if (bossdead && finishScreen)
        {
            score = Player_status.PS_score;
            bombCount -= Player_status.PS_bomb;
            scoreManager_Finish.transform.GetChild(0).gameObject.SetActive(true);
            scoreManager_Finish.transform.GetChild(1).gameObject.SetActive(true);
            finishScreen = false;
           
        }
        if (bossdead)
        {
            player_Bomb.boomOn = true;
            player_Bomb.enabled=false;
            scoreManager_Finish.transform.GetChild(1).GetComponent<Text>().text = "Score : " + Player_status.PS_score;
            finishScreenTimer += Time.deltaTime;
            if (finishScreenTimer > 1.0f)
            {
               
                scoreManager_Finish.transform.GetChild(0).transform.GetChild(0).gameObject.SetActive(true);
                scoreManager_Finish.transform.GetChild(0).transform.GetChild(1).gameObject.SetActive(true);
                if (invCount < 10)
                {
                    scoreManager_Finish.transform.GetChild(0).transform.GetChild(1).GetComponent<Text>().text = "X     " + invCount + ":     -" + (invCount * 3000);
                }
                else if (invCount >= 10)
                {

                    scoreManager_Finish.transform.GetChild(0).transform.GetChild(1).GetComponent<Text>().text = "X    " + invCount + ":     -" + (invCount * 3000);
                }
            }
            if (finishScreenTimer > 2.0f)
            {
                
                scoreManager_Finish.transform.GetChild(0).transform.GetChild(2).gameObject.SetActive(true);
                scoreManager_Finish.transform.GetChild(0).transform.GetChild(3).gameObject.SetActive(true);
                scoreManager_Finish.transform.GetChild(0).transform.GetChild(3).GetComponent<Text>().text = "X     " + bombCount + ":     -" + (bombCount * 15000);


                /* finishScreenTimer = 0;*/
            }

            if (ismissionon == true)
            {
                if (finishScreenTimer > 2.5f)
                {
                    
                    scoreManager_Finish.transform.GetChild(0).transform.GetChild(4).gameObject.SetActive(true);
                    scoreManager_Finish.transform.GetChild(0).transform.GetChild(5).gameObject.SetActive(true);

                    if (missionclear == true)
                    {
                        scoreManager_Finish.transform.GetChild(0).transform.GetChild(4).GetComponent<Text>().text = "Mission clear";
                        scoreManager_Finish.transform.GetChild(0).transform.GetChild(5).GetComponent<Text>().text = "+" + missionscore;
                        

                    }

                    if (missionclear == false)
                    {
                        scoreManager_Finish.transform.GetChild(0).transform.GetChild(4).GetComponent<Text>().text = "Mission fail";
                        scoreManager_Finish.transform.GetChild(0).transform.GetChild(5).GetComponent<Text>().text = " +0" ;
                        

                    }

                    /* finishScreenTimer = 0;*/
                }

            }

            if(finishScreenTimer > 3.0f)
            {
                
                scoreManager_Finish.transform.GetChild(0).transform.GetChild(6).gameObject.SetActive(true);
                scoreManager_Finish.transform.GetChild(0).transform.GetChild(7).gameObject.SetActive(true);

                if (Player_status.PS_easyMode == 1)
                {
                    scoreManager_Finish.transform.GetChild(0).transform.GetChild(7).GetComponent<Text>().text = "Easy     *    1.0";

                }
                if (Player_status.PS_easyMode == 0)
                {
                    scoreManager_Finish.transform.GetChild(0).transform.GetChild(7).GetComponent<Text>().text = "Hard     *    1.2";

                }

               

            }

            if (finishScreenTimer > 3.5f)
            {
                
                setsocre();
                if(Player_status.PS_easyMode == 1)
                {
                    
                    Player_status.PS_score = (int)score;
                    

                }
                if (Player_status.PS_easyMode == 0)
                {

                    score = score * 1.2;
                    
                    Player_status.PS_score = (int)score;
                    

                }
                


                scoreManager_Finish.transform.GetChild(2).gameObject.SetActive(true);
                scoreManager_Finish.transform.GetChild(3).gameObject.SetActive(true);


                if (Player_status.PS_score > 0)
                {
                    scoreManager_Finish.transform.GetChild(2).GetComponent<Text>().text = "Score : " + Player_status.PS_score;
                }
                else if (Player_status.PS_score <= 0)
                {
                    Player_status.PS_score = 0;
                    scoreManager_Finish.transform.GetChild(2).GetComponent<Text>().text = "Score : " + Player_status.PS_score;
                }
                bossdead = false;

            }
        }
    }

}
