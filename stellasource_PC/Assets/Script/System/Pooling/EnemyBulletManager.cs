using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Internal;

public class EnemyBulletManager : MonoBehaviour
{
    private static GameObject[] bullets;
    private static int index;
    private static int counter = 0;
    private static Transform transform = null;
    private void Start()
    {
        counter = 0;
        transform = this.gameObject.transform;
        index = this.gameObject.transform.childCount;
        bullets = new GameObject[index];
        for (int i = 0; i < index; i++)
        {
            bullets[i] = GameObject.Find(gameObject.transform.GetChild(i).name);
            bullets[i].SetActive(false);
        }
        
    }

    public static GameObject GetBullet(GameObject gameObject)
    {
        counter++;
        if (counter % index == 0)
        {
            counter = 0;
        }
        bullets[counter].transform.parent = gameObject.transform;
        bullets[counter].transform.localPosition = Vector3.zero;
        bullets[counter].SetActive(true);
        bullets[counter].transform.parent = null;
        return bullets[counter];
    }

    public static void RetireBullet(GameObject gameObject)
    {
        gameObject.transform.parent = transform;
        gameObject.SetActive(false);
    }

}
