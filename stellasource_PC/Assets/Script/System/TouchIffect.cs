using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchIffect : MonoBehaviour
{
    public GameObject obj;
    float delayTime = 0;
    public float defaultTime = 0.05f;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0) && delayTime >= defaultTime)
        {
            EffectCreat();
            delayTime = 0;
        }
        delayTime += Time.deltaTime;
    }
    void EffectCreat()
    {
        // 스크린 좌표를 월드 좌표로 변환함
        Vector3 wp = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        wp.z = -1f;
        // 생성
        Instantiate(obj, wp, Quaternion.identity);
    }
}
