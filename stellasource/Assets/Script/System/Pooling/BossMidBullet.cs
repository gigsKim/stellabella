using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossMidBullet : MonoBehaviour
{
    private static GameObject[] bossmidbullets;
    private static int index;
    private static int counter = 0;
    private void Start()
    {
        counter = 0;
        index = this.gameObject.transform.childCount;
        bossmidbullets = new GameObject[index];
        for (int i = 0; i < index; i++)
        {
            bossmidbullets[i] = GameObject.Find(gameObject.transform.GetChild(i).name);
            bossmidbullets[i].SetActive(false);
        }
    }

    public static GameObject GetBossMidBullet(GameObject gameObject)
    {
        counter++;
        if (counter % index == 0)
        {
            counter = 0;
        }
        bossmidbullets[counter].transform.parent = gameObject.transform;
        bossmidbullets[counter].transform.localPosition = Vector3.zero;
        bossmidbullets[counter].SetActive(true);
        bossmidbullets[counter].transform.parent = null;

        return bossmidbullets[counter];
    }
}
