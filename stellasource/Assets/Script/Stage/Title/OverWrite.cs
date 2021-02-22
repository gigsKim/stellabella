using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OverWrite : MonoBehaviour
{
    public void OverYes()
    {
        Player_status.DBSavePreference();
        SceneManager.LoadScene("LoadingScene2");
    }

    public void OverNo()
    {
        this.transform.parent.gameObject.SetActive(false);
    }
}
