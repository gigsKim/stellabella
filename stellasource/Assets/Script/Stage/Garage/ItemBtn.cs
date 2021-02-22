using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ItemBtn : MonoBehaviour
{
    private GameObject Btn;

    public void OnItemBtn()
    {
        Btn = EventSystem.current.currentSelectedGameObject;
        //최초에 스크립트에 달려있는 자식의 텍스트 다끄고
        for (int i = 0; i < this.transform.childCount; i++)
        {
            transform.GetChild(i).GetChild(0).gameObject.SetActive(false);
            transform.GetChild(i).GetChild(1).gameObject.SetActive(false);
        }
        //눌린 버튼의 자식과 버튼 켬
        Btn.transform.GetChild(0).gameObject.SetActive(true);
        Btn.transform.GetChild(1).gameObject.SetActive(true);

    }

    //구매(장바구니모양 버튼)
    //OnItemQuestion이 눌리면 구매확인창이 뜨고
    //현재 스크립트 주인의 부모의 자식인덱스 5마리의 버튼과 이미지 컴포넌트 다끈다.
    //버튼의 부모의 이미지는 켠다.
    public void OnItemQuestion()
    {
        Btn = EventSystem.current.currentSelectedGameObject;
        Btn.transform.GetChild(0).gameObject.SetActive(true);
        for (int i = 0; i < this.transform.childCount; i++)
        {
            this.transform.GetChild(i).GetComponent<Image>().enabled = false;
            this.transform.GetChild(i).GetComponent<Button>().enabled = false;
        }
    }

    //구매 확인창 취소버튼
    public void OnItemQuestionClose()
    {
        Btn = EventSystem.current.currentSelectedGameObject;
        Btn.transform.parent.gameObject.SetActive(false);

        for (int i = 0; i < this.transform.childCount; i++)
        {
            this.transform.GetChild(i).GetComponent<Image>().enabled = true;
            this.transform.GetChild(i).GetComponent<Button>().enabled = true;
        }
    }

    //Upgrade = bulletlevel, hp, bomb, blitz, drone
    //Gear      = recoveryhp, instancedrone, sellbomb, sellsp, resetsp
    //구매 확인창 구매버튼
    public void OnItemSale()
    {
        Btn = EventSystem.current.currentSelectedGameObject;

        if (Btn.gameObject.name.Equals("Bullet"))
        {
            //bulletLevel한계값 2 총알업그레이드 첫번째 구매
            if (Player_status.PS_sp >= 2 && Player_status.PS_bulletLevel == 0)
            {
                Player_status.PS_sp -= 2;
                Player_status.PS_bulletLevel = 1;
                Btn.transform.parent.GetChild(0).GetComponent<Text>().text = "구매하시겠습니까?\n필요 SP포인트  :  3";
                return;
            }
            else if (Player_status.PS_sp < 2)
            {
                Btn.transform.parent.GetChild(0).GetComponent<Text>().text = "남은 SP가 없습니다.";
                return;
            }

            //총알업그레이드 두번째 구매
            if (Player_status.PS_sp >= 3 && Player_status.PS_bulletLevel == 1)
            {
                Player_status.PS_sp -= 3;
                Player_status.PS_bulletLevel = 2;
                Btn.transform.parent.GetChild(0).GetComponent<Text>().text = "최대치까지\n구매하셨습니다.";
                return;
            }
        }

        if (Btn.gameObject.name.Equals("Hp"))
        {
            if (Player_status.PS_sp == 0)
            {
                Btn.transform.parent.GetChild(0).GetComponent<Text>().text = "남은 SP가 없습니다.";
                return;
            }
                //maxhp 한계값 25
                if (Player_status.PS_maxHp <= 24 && Player_status.PS_sp >= 1)
                {
                    Player_status.PS_sp--;
                    Player_status.PS_maxHp++;
                    Player_status.PS_hp++;
                    if (Player_status.PS_maxHp == 25)
                    {
                        Btn.transform.parent.GetChild(0).GetComponent<Text>().text = "최대치까지\n구매하셨습니다.";
                    }
                    return;
                }

        }

        if (Btn.gameObject.name.Equals("Bomb"))
        {
            if (Player_status.PS_sp < 2)
            {
                Btn.transform.parent.GetChild(0).GetComponent<Text>().text = "남은 SP가 없습니다.";
                return;
            }
            else
            {
                //maxbomb한계값 5 첫번째 구매
                if (Player_status.PS_sp >= 2 && Player_status.PS_maxBomb == 3)
                {
                    Player_status.PS_sp -= 2;
                    Player_status.PS_maxBomb++;
                    Player_status.PS_bomb++;
                    Debug.Log(Player_status.PS_maxBomb);
                    Btn.transform.parent.GetChild(0).GetComponent<Text>().text = "구매하시겠습니까?\n필요 SP포인트  :  3";
                    return;
                }
            }

            //두번째 구매
            if (Player_status.PS_sp >= 3 && Player_status.PS_maxBomb == 4)
            {
                Player_status.PS_sp -= 3;
                Player_status.PS_maxBomb++;
                Player_status.PS_bomb++;
                Btn.transform.parent.GetChild(0).GetComponent<Text>().text = "최대치까지\n구매하셨습니다.";
                return;
            }
        }

        if (Btn.gameObject.name.Equals("Blitz"))
        {
            if (Player_status.PS_sp < 2)
            {
                Btn.transform.parent.GetChild(0).GetComponent<Text>().text = "남은 SP가 없습니다.";
                return;
            }
            else
            {
                //Blitz 한계값 5 첫번째 구매
                if (Player_status.PS_sp >= 2 && Player_status.PS_blitz == 3)
                {
                    Player_status.PS_sp -= 2;
                    Player_status.PS_blitz = 4;
                    Btn.transform.parent.GetChild(0).GetComponent<Text>().text = "구매하시겠습니까?\n필요 SP포인트  :  3";
                    return;
                }
            }

            //두번째 구매
            if (Player_status.PS_sp >= 3 && Player_status.PS_blitz == 4)
            {
                Player_status.PS_sp -= 3;
                Player_status.PS_blitz = 5;
                Btn.transform.parent.GetChild(0).GetComponent<Text>().text = "최대치까지\n구매하셨습니다.";
                return;
            }
        }

        if (Btn.gameObject.name.Equals("Drone"))
        {
            if (Player_status.PS_sp < 3)
            {
                Btn.transform.parent.GetChild(0).GetComponent<Text>().text = "남은 SP가 없습니다.";
                return;
            }
            else
            {
                //드론 한계값 2 첫번째 구매
                if (Player_status.PS_sp >= 3 && Player_status.PS_drone == 0)
                {
                    Player_status.PS_sp -= 3;
                    Player_status.PS_drone = 1;
                    Btn.transform.parent.GetChild(0).GetComponent<Text>().text = "구매하시겠습니까?\n필요 SP포인트  :  5";
                    return;
                }
            }

            //두번째 구매
            if (Player_status.PS_sp >= 5 && Player_status.PS_drone == 1)
            {
                Player_status.PS_sp -= 5;
                Player_status.PS_drone = 2;
                Btn.transform.parent.GetChild(0).GetComponent<Text>().text = "최대치까지\n구매하셨습니다.";
                return;
            }
        }

        ///////////////////////////////////////////////////////////////////여기부터 GearShop

        if (Btn.gameObject.name.Equals("RecoveryHp"))
        {
            if (Player_status.PS_maxHp == Player_status.PS_hp)
            {
                Btn.transform.parent.GetChild(0).GetComponent<Text>().text = "현재 최대 체력입니다.";
                return;
            }
            else if (Player_status.PS_maxHp > Player_status.PS_hp && Player_status.PS_score >= 2500)
            {
                Player_status.PS_score -= 2500;
                Player_status.PS_hp++;
                return;
            }
            else
            {
                Btn.transform.parent.GetChild(0).GetComponent<Text>().text = "스코어가 부족합니다.";
                return;
            }
        }

        if (Btn.gameObject.name.Equals("InstanceDrone"))
        {
            if (Player_status.PS_score >= 25000)
            {
                Player_status.PS_instanceDrone++;
                Player_status.PS_score -= 25000;
                return;
            }
            else
            {
                Btn.transform.parent.GetChild(0).GetComponent<Text>().text = "스코어가 부족합니다.";
                return;
            }
        }

        if (Btn.gameObject.name.Equals("SellBomb"))
        {
            if (Player_status.PS_bomb > 0)
            {
                Player_status.PS_score += 10000;
                Player_status.PS_bomb--;
                return;
            }
            else if (Player_status.PS_bomb == 0)
            {
                Btn.transform.parent.GetChild(0).GetComponent<Text>().text = "남은 폭탄이 없습니다.";
                return;
            }
        }

        if (Btn.gameObject.name.Equals("SellSP"))
        {
            if (Player_status.PS_sp > 0)
            {
                Player_status.PS_score += 20000;
                Player_status.PS_sp--;
                return;
            }
            else if (Player_status.PS_sp == 0)
            {
                Btn.transform.parent.GetChild(0).GetComponent<Text>().text = "남은 SP가 없습니다.";
                return;
            }
        }

        if (Btn.gameObject.name.Equals("ResetSP"))
        {
            if (Player_status.PS_sp == Player_status.PS_maxsp)
            {
                Btn.transform.parent.GetChild(0).GetComponent<Text>().text = "초기화 할 SP가 없습니다.";
                return;
            }
            else if (Player_status.PS_score >= 5000)
            {
                Player_status.PS_score -= 5000;
                Player_status.PS_maxHp = 20;
                if (Player_status.PS_hp > Player_status.PS_maxHp)
                {
                    Player_status.PS_hp = Player_status.PS_maxHp;
                }
                Player_status.PS_maxBomb = 3;
                if (Player_status.PS_bomb > Player_status.PS_maxBomb)
                {
                    Player_status.PS_bomb = Player_status.PS_maxBomb;
                }
                Player_status.PS_blitz = 3;
                Player_status.PS_bulletLevel = 0;
                Player_status.PS_sp = Player_status.PS_maxsp;
                Player_status.PS_drone = 0;
                return;
            }
            else
            {
                Btn.transform.parent.GetChild(0).GetComponent<Text>().text = "스코어가 부족합니다.";
                return;
            }
        }
    }
}
