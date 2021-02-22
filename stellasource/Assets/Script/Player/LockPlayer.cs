using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockPlayer : MonoBehaviour
{
    public float xleft;
    public float xright;
    public float yup;
    public float ydown;

    // Update is called once per frame
    void Update()
    {
        Vector3 worldpos = Camera.main.WorldToViewportPoint(this.transform.position);
        if (worldpos.x < xleft) worldpos.x = xleft;
        if (worldpos.y < ydown) worldpos.y = ydown;
        if (worldpos.x > xright) worldpos.x = xright;
        if (worldpos.y > yup) worldpos.y = yup;
        this.transform.position = Camera.main.ViewportToWorldPoint(worldpos);

    }
}
