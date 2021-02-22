using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HomingDrone : MonoBehaviour
{
    public float xMargin = 1f;      //따라갈 오브젝트 x축 범위
    public float yMargin = 1f;      //따라갈 오브젝트 y축 범위
    public float xSmooth = 2f;     //카메라 x축이동속도
    public float ySmooth = 2f;     //카메라 y축 이동속도

    //따라갈 y축 한계
    public float maxY = 5f;
    public float minY = -5f;

    //캐릭터 오브젝트 위치
    private float targetX;
    private float targetY;

    //캐릭터 오브젝트
    private Transform chase;
    private Transform chase1;
    private Transform chase2;
    private void Start()
    {
        chase = GameObject.Find("ChasePoint").transform;
        chase1 = GameObject.Find("ChasePoint1").transform;
        chase2 = GameObject.Find("ChasePoint2").transform;
    }

    void Update()
    {
        TrackPlayer();
    }

    //드론의 x축이 플레이어로부터 지정한값이상 떨어져있는지 확인
    bool CheckXMargin(Transform chased)
    {
        return Mathf.Abs(transform.position.x - chased.position.x) > xMargin;
    }

    //드론의 y축이 플레이어로부터 지정한값이상 떨어져있는지 확인
    bool CheckYMargin(Transform chased)
    {
        return Mathf.Abs(transform.position.y - chased.position.y) > yMargin;
    }

    //플레이어위치를 실시간으로 받고 x,y축 검사 후 드론위치를 플레이어위치로 변경
    void TrackPlayer()
    {
        targetX = transform.position.x;
        targetY = transform.position.y;
        if (this.gameObject.name == "Drone1")
        {
            if (CheckXMargin(chase1))
            {
                targetX = Mathf.Lerp(transform.position.x, chase1.position.x, xSmooth * Time.deltaTime);
            }
            if (CheckYMargin(chase1))
            {
                targetY = Mathf.Lerp(transform.position.y, chase1.position.y, ySmooth * Time.deltaTime);
            }
        }
        else if (this.gameObject.name == "Drone2")
        {
            if (CheckXMargin(chase2))
            {
                targetX = Mathf.Lerp(transform.position.x, chase2.position.x, xSmooth * Time.deltaTime);
            }
            if (CheckYMargin(chase2))
            {
                targetY = Mathf.Lerp(transform.position.y, chase2.position.y, ySmooth * Time.deltaTime);
            }
        }
        else {
            if (CheckXMargin(chase))
            {
                targetX = Mathf.Lerp(transform.position.x, chase.position.x, xSmooth * Time.deltaTime);
            }
            if (CheckYMargin(chase))
            {
                targetY = Mathf.Lerp(transform.position.y, chase.position.y, ySmooth * Time.deltaTime);
            }
        }

        targetY = Mathf.Clamp(targetY, minY, maxY);

        transform.position = new Vector3(targetX, targetY, transform.position.z);
    }

}
