using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BulletList;

public class BossBullet : MonoBehaviour
{
    public static Bullets<GameObject> bossbullets;
    private static int counter = 0;
    private int index;

    private void Start()
    {
        bossbullets = new Bullets<GameObject>();
        counter = 0;
        index = this.gameObject.transform.childCount;
        for (int i = 0; i < index; i++)
        {
            bossbullets.add(this.transform.GetChild(i).gameObject);
            bossbullets.get(i).SetActive(false);
        }
        Debug.Log("현재 id와 기기정보 = " + Player_status.PS_ID + ", " + Player_status.PS_deviceID);
        
    }

    //인자로 받는 게임오브젝트 위치에 총알을 갖다놔줌 이후 총알이 알아서 역할
    public static GameObject GetBossBullet(GameObject gameObject)
    {
        counter++;
        if (counter % bossbullets.Length() == 0)
        {
            counter = 0;
        }
        bossbullets.get(counter).transform.parent = gameObject.transform;
        bossbullets.get(counter).transform.localPosition = Vector3.zero;
        bossbullets.get(counter).SetActive(true);
        bossbullets.get(counter).transform.parent = null;

        return bossbullets.get(counter);
    }
}
