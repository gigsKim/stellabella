﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class CtrlPlayer : MonoBehaviour
{
    
   
    //조절가능 속도
    public float MoveSpeed = 10;

    public int Player_moveTime=0;

    private Vector3 moveVector;
    private Transform mytransform;

    // Start is called before the first frame update
    void Start()
    {
        

        moveVector = Vector3.zero;
        mytransform = transform;

    }

    // Update is called once per frame
    void Update()
    {
        Player_moveTime++;
        HandleInput();
       
        // 반대로 도는 함수
        /**if (Player_moveTime ==300 )
        {
            print("화면 전환");
            player.transform.Rotate(0, 180,0);

        }**/
    }

    private void FixedUpdate()
    {
        Move();
    }

    private void HandleInput()
    {
        moveVector = poolInput();
    }

    private Vector3 poolInput()
    {

        //입력받은 값으로 상하좌우 움직인다

        /** if (Player_moveTime >= 300)
        {
            float h = -joyStick.GetHorizontalValue();
            float v = joyStick.GetVerticalValue();
            Vector3 moveDir = new Vector3(h, v, 0).normalized;
            return moveDir;
        }
        else 
        {**/
        float h = Input.GetAxis("Horizontal") * MoveSpeed * Time.deltaTime;
        float v = Input.GetAxis("Vertical") * MoveSpeed * Time.deltaTime;
        Vector3 moveDir = new Vector3(h, v, 0).normalized;
        return moveDir;
       // }

    }

    public void Move()
    {
            mytransform.Translate(moveVector * MoveSpeed * Time.deltaTime);

    }

   
    private void OnTriggerEnter(Collider enemy)
    {
        print("작동");
        if (enemy.tag == "Enemy")
        {
            
            print("enemy");
        }
    }
}