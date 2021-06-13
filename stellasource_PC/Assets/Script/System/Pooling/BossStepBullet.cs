using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossStepBullet : MonoBehaviour
{
    // Start is called before the first frame update
    // Start is called before the first frame update
    private static GameObject[] bossbulletsstep;
    private static int index;
    private static int counter = 0;
    
    public bool bossdead = false;
    private void Start()
    {
        counter = 0;
        
        index = this.gameObject.transform.childCount;
        bossbulletsstep = new GameObject[index];
        for (int i = 0; i < index; i++)
        {
            bossbulletsstep[i] = GameObject.Find(gameObject.transform.GetChild(i).name);
            bossbulletsstep[i].SetActive(false);
        }
    }

    public static GameObject GetBossBulletStep(GameObject gameObject)
    {
        counter++;
        if (counter % index == 0)
        {
            counter = 0;
        }
        bossbulletsstep[counter].transform.parent = gameObject.transform;
        bossbulletsstep[counter].transform.localPosition = Vector3.zero;
        bossbulletsstep[counter].SetActive(true);
        bossbulletsstep[counter].transform.parent = null;

        return bossbulletsstep[counter];
    }
    public static void RetireBullet(GameObject gameObject)
    {
        
        gameObject.SetActive(false);
    }
}
