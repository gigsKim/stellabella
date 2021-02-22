using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DroneMgr : MonoBehaviour
{

    private GameObject droneTemp;
    private GameObject bulletTemp;

    //생성할 오브젝트
    private GameObject drone;

    void Start()
    {
        drone = this.transform.GetChild(2).gameObject;

        //드론켜기 및 총알준비
        if (Player_status.PS_drone > 0)
        {
            for (int i = 0; i < Player_status.PS_drone; i++)
            {
                this.transform.GetChild(i).gameObject.SetActive(true);
            }
        }

        //1회용드론 추가 및 총알 준비
        if (Player_status.PS_instanceDrone > 0)
        {
            for (int i = 0; i < Player_status.PS_instanceDrone; i++)
            {
                droneTemp = Instantiate(drone, new Vector3(0, 0, 0), Quaternion.identity) as GameObject;
                droneTemp.transform.parent = this.transform;
                droneTemp.GetComponent<HomingDrone>().xMargin = i/3.0f;
                droneTemp.GetComponent<HomingDrone>().yMargin = 1f + i/5f;
                droneTemp.gameObject.name = "instancedrone";
                droneTemp.SetActive(true);
            }
        }
        StartCoroutine("InstanceDroneFire");
    }

    IEnumerator InstanceDroneFire()
    {
        while (true)
        {
            for (int i = 0; i < this.transform.childCount; i++)
            {
                
                if (this.transform.GetChild(i).gameObject.activeSelf == true)
                {
                        this.transform.GetChild(i).GetChild(0).localPosition = new Vector3(0, 0, 0);
                        this.transform.GetChild(i).GetChild(0).gameObject.SetActive(true);
                }
            }
            
            yield return new WaitForSeconds(3.0f);
        }

    }
}
