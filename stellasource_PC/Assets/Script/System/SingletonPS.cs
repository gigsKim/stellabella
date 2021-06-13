using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingletonPS : MonoBehaviour
{
    public static SingletonPS instance = null;              //Static instance of GameManager which allows it to be accessed by any other script.
    void Awake()
    {
        if (instance == null)
            instance = this;

        else if (instance != this)
            Destroy(gameObject);

        DontDestroyOnLoad(gameObject);

        InitGame();
    }

    //Initializes the game for each level.
    void InitGame()
    {
        this.gameObject.AddComponent<Player_status>();
    }

}
