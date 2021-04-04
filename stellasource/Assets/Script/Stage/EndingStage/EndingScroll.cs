using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndingScroll : MonoBehaviour
{
    public float moveSpeed = 10.0f;
    // Start is called before the first frame update
    void Start()
    {
        Player_status.combo = 0;
    }

    private void Update()
    {
        this.transform.Translate(Vector2.up*moveSpeed);
    }
    // Update is called once per frame

}
