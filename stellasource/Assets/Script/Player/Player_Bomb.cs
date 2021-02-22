using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Player_Bomb : MonoBehaviour, IPointerDownHandler
{

    public bool boomOn = false;         //Boom_area에서 참조함
    public GameObject[] activeBomb;

    public Image[] bombImg;

    public int maxBomb;
    public int bombCount;

    private void Start()
    {
        maxBomb = Player_status.PS_maxBomb;
        bombCount = Player_status.PS_bomb;
        activeBomb = new GameObject[maxBomb];
        bombImg = new Image[5];
        
        for (int i = 0; i < maxBomb; i++)
        {
            activeBomb[i] = this.transform.GetChild(i).gameObject;
            activeBomb[i].SetActive(true);
            bombImg[i] = this.transform.GetChild(i).GetComponent<Image>();
        }
        for (int i = 0; i < maxBomb; i++)
        {
            bombImg[i].color = new Color(1, 1, 1, 0.2f);
        }
        for (int i = 0; i < Player_status.PS_bomb; i++)
        {
            bombImg[i].color = new Color(1, 1, 1, 1);
        }
    }

    public void OnPointerDown(PointerEventData ped)
    {
        if (bombCount > 0 && !boomOn)
        {
            boomOn = true;
            Image temp = bombImg[bombCount - 1].GetComponent<Image>();

            temp.color = new Color(temp.color.r, temp.color.g, temp.color.b, 0.2f);

            bombCount--;
            Player_status.PS_bomb--;
        }
    }

}
