using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBossHiddenPattern2 : MonoBehaviour
{
    // Start is called before the first frame update
    // Start is called before the first frame update
    float time = 0f;
    public float bullet_speed = 100f;
    bool cocheck = true;
    float coTime = 0;

    private void FixedUpdate()
    {
        time += Time.deltaTime;
        if (time >= 1.0f)
        {
            if (cocheck)
            {
                StartCoroutine(BigShot());
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
    IEnumerator BigShot()
    {
        BossBigBullet.GetBossBigBullet(this.gameObject).GetComponent<Rigidbody2D>().AddForce(new Vector2(-4 * bullet_speed, 4 * bullet_speed));
        BossBigBullet.GetBossBigBullet(this.gameObject).GetComponent<Rigidbody2D>().AddForce(new Vector2(-4 * bullet_speed, -4 * bullet_speed));

        yield return new WaitForSeconds(1f);
    }
}
