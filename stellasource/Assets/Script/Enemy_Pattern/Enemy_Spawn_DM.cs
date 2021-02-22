using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Spawn_DM : MonoBehaviour
{
    //메인카메라에 달 것
    //스테이지별로 이스크립트 복제해서 Enemy_Spawn_Stage1 의 양식으로 제작 후 사용
    //스폰포인트 갯수만큼 createnum을 수정할 것 
    //스폰포인트는 무조건 CreatePoint0,CreatePoint1 등의 양식으로 제작할것

    private int createnum; //스폰포인트배열최대값 

    public GameObject[] waypoint;   //스폰포인트배열

    //배열돌리기
    private int enemySelect = 1;
    private int enemySelect2 = 0;

    int enemyMaximum = 10;
    //자동으로 하이어라키에 있는 오브젝트 찾아줌
    private void Awake()
    {
        createnum = GameObject.Find("Creator").transform.childCount;
        waypoint = new GameObject[createnum];
        for (int i = 0; i < createnum; i++)
        {
            waypoint[i] = GameObject.Find("CreatePoint" + i);
        }

    }


    //적 소환할때 이 메소드 호출 waypointer => 0~n == 적이 나올 위치
    //idx -----------------------------------------------------------
    //0 == boss
    //1 == justmove
    //2 == luncher
    //3 == tank
    //4 == pattern1
    //5 == pattern2
    //6 == pattern3
    //7 == pattern4




        public void PrintEnemy(int wayPointer, int enemyType)
    {
        if (enemySelect == enemyMaximum+1)
        {
            enemySelect = 1;
        }
        if(enemySelect2 == 10)
        {
            enemySelect2 = 0;
        }
        if(enemyType == 0)
        {
            Vehicle.GetVehicle(enemyType).transform.parent = waypoint[wayPointer].transform;
            //Vehicle.GetVehicle(enemyType).transform.rotation = waypoint[wayPointer].transform.rotation;
            Vehicle.GetVehicle(enemyType).SetActive(true);
            Vehicle.GetVehicle(enemyType).transform.localPosition = Vector3.zero;
            Vehicle.GetVehicle(enemyType).transform.parent = null;
        }
        else if(enemyType == 1)
        {
            Vehicle.GetVehicle(enemyType + enemySelect2).transform.parent = waypoint[wayPointer].transform;
            Vehicle.GetVehicle(enemyType + enemySelect2).SetActive(true);
            Vehicle.GetVehicle(enemyType + enemySelect2).transform.localPosition = Vector3.zero;
            Vehicle.GetVehicle(enemyType + enemySelect2).transform.parent = null;
            enemySelect2++;
        }
        else
        {
            Vehicle.GetVehicle((enemyType * enemyMaximum) - enemySelect).transform.parent = waypoint[wayPointer].transform;
            Debug.Log(wayPointer+"웨이포인터,"+enemyType +"타입,"+enemyType*enemyMaximum+"타입*맥시멈(시작값),"+ ((enemyType * enemyMaximum) - enemySelect) + "실제인덱스");
          
            Vehicle.GetVehicle((enemyType * enemyMaximum) - enemySelect).SetActive(true);
            Vehicle.GetVehicle((enemyType * enemyMaximum) - enemySelect).transform.localPosition = Vector3.zero;
            Vehicle.GetVehicle((enemyType * enemyMaximum) - enemySelect).transform.parent = null;
            enemySelect++;
        }
        
        
        /*GameObject ins = Instantiate(isPattern_Prefab, waypoint[waypointer].transform.position, Quaternion.identity) as GameObject;*/
        /*
         0 = 보스
         1~9 = just move
         10~19 = missile
         20~29 = tank
         30~39 = p1
         40~49 = p2
         50~59 = p3
         60~69 = p4
         
         
         */
    }
}

