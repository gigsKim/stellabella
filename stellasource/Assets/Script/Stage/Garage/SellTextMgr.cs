using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SellTextMgr : MonoBehaviour
{
    private Text itemText;
    public void Start()
    {
        itemText = this.transform.GetChild(0).GetChild(0).GetComponent<Text>();
    }

    public void TextEditBullet()
    {
        if (Player_status.PS_bulletLevel == 0)
        {
            itemText.text = "구매하시겠습니까?\n필요 SP포인트  :  2";
        }
        if (Player_status.PS_bulletLevel == 1)
        {
            itemText.text = "구매하시겠습니까?\n필요 SP포인트  :  3";
        }
        if (Player_status.PS_bulletLevel == 2)
        {
            itemText.text = "최대치까지\n구매하셨습니다.";
        }
    }

    public void TextEditHp()
    {
        if (Player_status.PS_sp == 0)
        {
            itemText.text = "남은 SP가 없습니다.";
        }
        else
        {
            if (Player_status.PS_maxHp < 25)
            {
                itemText.text = "구매하시겠습니까?\n필요 SP포인트  :  1";
            }
            else if (Player_status.PS_maxHp == 25)
            {
                itemText.text = "최대치까지\n구매하셨습니다.";
            }
        }
    }

    public void TextEditBomb()
    {
        if (Player_status.PS_maxBomb == 3)
        {
            itemText.text = "구매하시겠습니까?\n필요 SP포인트  :  2";
        }
        else if (Player_status.PS_maxBomb == 4)
        {
            itemText.text = "구매하시겠습니까?\n필요 SP포인트  :  3";
        }
        else if (Player_status.PS_maxBomb == 5)
        {
            itemText.text = "최대치까지\n구매하셨습니다.";
        }
    }

    public void TextEditBlitz()
    {
        if (Player_status.PS_blitz == 3)
        {
            itemText.text = "구매하시겠습니까?\n필요 SP포인트  :  2";
        }
        else if (Player_status.PS_blitz == 4)
        {
            itemText.text = "구매하시겠습니까?\n필요 SP포인트  :  3";
        }
        else if (Player_status.PS_blitz == 5)
        {
            itemText.text = "최대치까지\n구매하셨습니다.";
        }
    }

    public void TextEditDrone()
    {
        if (Player_status.PS_bulletLevel == 0)
        {
            itemText.text = "구매하시겠습니까?\n필요 SP포인트  :  3";
        }
        if (Player_status.PS_bulletLevel == 1)
        {
            itemText.text = "구매하시겠습니까?\n필요 SP포인트  :  5";
        }
        if (Player_status.PS_bulletLevel == 2)
        {
            itemText.text = "최대치까지\n구매하셨습니다.";
        }
    }
    //---------------------------------------------------여기밑으로 gearshop

    public void TextEditRecoveryHp()
    {
        if (Player_status.PS_maxHp == Player_status.PS_hp)
        {
            itemText.text = "현재 최대 체력입니다.";
        }
        else if (Player_status.PS_score < 2500)
        {
            itemText.text = "스코어가 부족합니다.";
        }
        else
        {
            itemText.text = "구매하시겠습니까?\n스코어 2500 차감";
        }
    }

    public void TextEditInstanceDrone()
    {
        if (Player_status.PS_score < 25000)
        {
            itemText.text = "스코어가 부족합니다.";
        }
        else
        {
            itemText.text = "구매하시겠습니까?\n스코어 25000 차감";
        }
    }

    public void TextEditSellBomb()
    {
        if (Player_status.PS_bomb == 0)
        {
            itemText.text = "남은 폭탄이 없습니다.";

        }
        else
        {
            itemText.text = "판매하시겠습니까?\n스코어 10000 증가";
        }
    }

    public void TextEditSellSP()
    {
        if (Player_status.PS_sp == 0)
        {
            itemText.text = "남은 SP가 없습니다.";

        }
        else
        {
            itemText.text = "판매하시겠습니까?\n스코어 20000 증가";
        }
    }

    public void TextEditResetSP()
    {
        if (Player_status.PS_sp == Player_status.PS_maxsp)
        {
            itemText.text = "초기화 할 SP가 없습니다.";
        }
        else if (Player_status.PS_score < 5000)
        {
            itemText.text = "스코어가 부족합니다.";
        }
        else
        {
            itemText.text = "구매하시겠습니까?\n스코어 5000 차감";
        }
    }
}
