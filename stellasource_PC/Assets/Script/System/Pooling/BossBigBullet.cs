using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossBigBullet : MonoBehaviour
{
    private static GameObject[] bossbigbullets;
    private static int index;
    private static int counter = 0;
    private void Start()
    {
        counter = 0;
        index = this.gameObject.transform.childCount;
        Debug.Log(index);
        bossbigbullets = new GameObject[index];
        for (int i = 0; i < index; i++)
        {
            bossbigbullets[i] = GameObject.Find(gameObject.transform.GetChild(i).name);
            bossbigbullets[i].SetActive(false);
        }
    }

    public static GameObject GetBossBigBullet(GameObject gameObject)
    {
        counter++;
        if (counter % index == 0)
        {
            counter = 0;
        }
        bossbigbullets[counter].transform.parent = gameObject.transform;
        bossbigbullets[counter].transform.localPosition = Vector3.zero;
        bossbigbullets[counter].SetActive(true);
        bossbigbullets[counter].transform.parent = null;

        return bossbigbullets[counter];
    }
}
