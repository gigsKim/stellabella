using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionManager : MonoBehaviour
{
    private static GameObject[] Explosion;
    private static int index;
    private static int counter = 0;
    private void Start()
    {
        index = gameObject.transform.childCount;
        Explosion = new GameObject[index];
        for(int i = 0; i < index; i++)
        {
            Explosion[i] = GameObject.Find(gameObject.transform.GetChild(i).name);
            Explosion[i].SetActive(false);
        }
        
    }
    public static void GetExplosion(GameObject gameObject)
    {
        counter++;
        if (counter % index == 0)
        {
            counter = 0;
        }
        Explosion[counter].transform.parent = gameObject.transform;
        Explosion[counter].transform.localPosition = Vector3.zero;
        Explosion[counter].transform.parent = null;
        Explosion[counter].SetActive(true);
    }
}
