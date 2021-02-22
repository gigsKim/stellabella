using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class TouchMove : MonoBehaviour
{

    void Update()
    {
        if (Input.touchCount > 0) {
            for (int i = 0; i < Input.touchCount; i++)
            {
                if (EventSystem.current.IsPointerOverGameObject(i) == false)
                {
                    Vector2 touchDeltaPosition = Input.GetTouch(i).deltaPosition;
                    transform.Translate(touchDeltaPosition.x * Input.GetTouch(i).deltaTime, touchDeltaPosition.y * Input.GetTouch(i).deltaTime, 0);
                    break;
                }
                
            }

        }
        
    }
}