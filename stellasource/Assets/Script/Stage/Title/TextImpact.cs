using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextImpact : MonoBehaviour
{
    private float r = 1;
    private float g = 0;
    private float b = 0;
    void FixedUpdate()
    {
            if (r >= 1 && g <= 0)
            {
                b += 0.08f;
            }
            if (b >= 1 && g <= 0)
            {
                r -= 0.08f;
            }
            if (g >= 1 && r <= 0)
            {
                b -= 0.08f;
            }
            if (g >= 1 && b <= 0)
            {
                r += 0.08f;
            }
            if (r >= 1 && b <= 0)
            {
                g -= 0.08f;
            }
            if (b >= 1 && r <= 0)
            {
                g += 0.08f;
            }
            this.GetComponent<Text>().color = new Color(r, g, b);
        
    }
}
