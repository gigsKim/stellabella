using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vehicle : MonoBehaviour
{
    private static GameObject[] vehicles;
    private static int index;
    public void Start()
    {
        index = gameObject.transform.childCount;
        vehicles = new GameObject[index];
        for (int i = 0; i < index; i++)
        {
            vehicles[i] = GameObject.Find(gameObject.transform.GetChild(i).name);
            vehicles[i].SetActive(false);

        }
        
    }

    public static void SetVehicle(GameObject vehicle)
    {
        vehicles[++index] = vehicle;
    }
    public static GameObject GetVehicle(int idx)
    {
        return vehicles[idx];
    }

}
