using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finalbosspattenmanger : MonoBehaviour
{

   public  Boss_status boss;
    public Finalbosspatten2 f2;
    public Finalbosspatten3 f3;
    // Start is called before the first frame update
    void Start()
    {
        boss = gameObject.transform.parent.gameObject.GetComponent<Boss_status>();
        f2 =gameObject.GetComponent<Finalbosspatten2>();
        f3 =gameObject.GetComponent<Finalbosspatten3>();
    }

    // Update is called once per frame
    void Update()
    {
        if (boss.boss_hp <= 500)
            f2.enabled = true;

        if (boss.boss_hp <= 400)
            f3.enabled = true;
    }
}
