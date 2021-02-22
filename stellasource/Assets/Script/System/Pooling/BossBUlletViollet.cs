using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossBUlletViollet : MonoBehaviour
{
    // Start is called before the first frame update
    private static GameObject[] bossbulletsviollet;
    private static int index;
    private static int counter = 0;
    private static Transform transform;
    private void Start()
    {
        counter = 0;
        transform = this.gameObject.transform;
        index = this.gameObject.transform.childCount;
        bossbulletsviollet = new GameObject[index];
        for (int i = 0; i < index; i++)
        {
            bossbulletsviollet[i] = GameObject.Find(gameObject.transform.GetChild(i).name);
            bossbulletsviollet[i].SetActive(false);
        }
 
    }

    public static GameObject GetBossBulletViollet(GameObject gameObject)
    {
        counter++;
        if (counter % index == 0)
        {
            counter = 0;
        }
        bossbulletsviollet[counter].transform.parent = gameObject.transform;
        bossbulletsviollet[counter].transform.localPosition = Vector3.zero;
        bossbulletsviollet[counter].SetActive(true);
        bossbulletsviollet[counter].transform.parent = null;

        return bossbulletsviollet[counter];
    }
    public static void RetireBullet(GameObject gameObject)
    {
        gameObject.transform.parent = transform;
        gameObject.SetActive(false);
    }
}
