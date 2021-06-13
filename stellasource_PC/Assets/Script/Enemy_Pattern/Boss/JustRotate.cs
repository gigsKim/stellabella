using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JustRotate : MonoBehaviour
{
    //회전간격
    public int rotSpeed = 5;
    //회전속도
    public int bulletTerm = 10;

    float z = 0;

    float time;
    void FixedUpdate()
    {
        time++;
        if ((int)time % bulletTerm == 0)
        {
            z += rotSpeed;
            if (z >= 360) z = 0;
            this.transform.rotation = Quaternion.Euler(new Vector3(0, 0, 0));
            this.transform.Rotate(0, 0, z);

        }
    }
}
