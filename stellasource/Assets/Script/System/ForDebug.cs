using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ForDebug : MonoBehaviour
{
    float h;
    float v;
    private Player_charge A_but;
    private Player_Bomb Bomb;
    PointerEventData a;
    private void Start()
    {
        A_but = GameObject.Find("A_but").GetComponent<Player_charge>();
        Bomb = GameObject.Find("BombB").GetComponent<Player_Bomb>();
    }
    // Update is called once per frame
    void Update()
    {
        h = Input.GetAxis("Horizontal");
        v = Input.GetAxis("Vertical");

        transform.Translate(Vector3.right * 25f * Time.smoothDeltaTime * h, Space.World);
        transform.Translate(Vector3.up * 25f * Time.smoothDeltaTime * v, Space.World);
        if (Input.GetButtonDown("Fire1"))
        {
            Debug.Log("입력됨");
            A_but.OnPointerDown(a);
        }
        if (Input.GetButtonUp("Fire1"))
        {
            
            A_but.OnPointerUp(a);
        }
        if (Input.GetButtonDown("Fire3"))
        {
            Bomb.OnPointerDown(a);
        }
    }
}
