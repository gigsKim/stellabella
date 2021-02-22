using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnHidden : MonoBehaviour
{
    //메인카메라에 달 것
    //스테이지별로 이스크립트 복제해서 Enemy_Spawn_Stage1 의 양식으로 제작 후 사용
    //스폰포인트 갯수만큼 createnum을 수정할 것 
    //스폰포인트는 무조건 CreatePoint0,CreatePoint1 등의 양식으로 제작할것

    private int createnum; //스폰포인트배열최대값 

    public GameObject[] waypoint;   //스폰포인트배열

    public Vector3[] pos; //현재위치

    public float speed = 4.0f; // 이동속도

    float delta = 3f; // 상하로 이동가능한 (y)최대값
    float time;
    Vector3[] v;

    //자동으로 하이어라키에 있는 오브젝트 찾아줌
    private void Awake()
    {
        createnum = GameObject.Find("Creator").transform.childCount;
        waypoint = new GameObject[createnum];
        pos = new Vector3[createnum];
        v = new Vector3[createnum];
        for (int i = 0; i < createnum; i++)
        {
            waypoint[i] = GameObject.Find("CreatePoint" + i);
            pos[i] = waypoint[i].transform.position;
        }

    }

    //상시 상하반복이동
    void Update()
    {

        for (int i = 0; i < createnum - 1; i++)
        {
            v[i] = pos[i];
        }
        for (int i = 0; i < createnum - 1; i++)
        {
            v[i].y += delta * Mathf.Sin(Time.time * speed);
            waypoint[i].transform.position = v[i];

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
      
       
       
            Vehicle.GetVehicle(enemyType).transform.parent = waypoint[wayPointer].transform;
            Vehicle.GetVehicle(enemyType).SetActive(true);
            Vehicle.GetVehicle(enemyType).transform.localPosition = Vector3.zero;
            Vehicle.GetVehicle(enemyType).transform.parent = null;
      
       

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
