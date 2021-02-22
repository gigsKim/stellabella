using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissileManager : MonoBehaviour
{
    private static GameObject[] missiles;
    private static int index;
    private static int counter = 0;
    private void Start()
    {
        index = gameObject.transform.childCount;
        missiles = new GameObject[index];
        for (int i = 0; i < index; i++)
        {
            missiles[i] = GameObject.Find(gameObject.transform.GetChild(i).name);
            missiles[i].SetActive(false);
        }
        
    }
    public static GameObject GetMissile(GameObject gameObject)
    {
        counter++;
        if (counter % index == 0)
        {
            counter = 0;
        }
        missiles[counter].transform.parent = gameObject.transform;
        missiles[counter].transform.localPosition = Vector3.zero;
        missiles[counter].transform.parent = null;
        missiles[counter].SetActive(true);
        return missiles[counter];
    }
}
