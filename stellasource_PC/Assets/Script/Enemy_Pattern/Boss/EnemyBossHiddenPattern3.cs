using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBossHiddenPattern3 : MonoBehaviour
{
    // Start is called before the first frame update
    float time = 0f;
    public float bullet_speed = 5f;
    bool cocheck = true;
    float coTime = 0;

    private void FixedUpdate()
    {
        time += Time.deltaTime;
        if (time >= 1.0f)
        {
            if (cocheck)
            {
                BossBUlletViollet.GetBossBulletViollet(this.gameObject);
                cocheck = false;
            }
            else if (!cocheck)
            {
                coTime += Time.deltaTime;
                if (coTime >= 0.5)
                {
                    coTime = 0;
                    cocheck = true;

                }
            }
        }
    }

    // Update is called once per frame
    
}
