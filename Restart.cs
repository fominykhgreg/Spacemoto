using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{

    public GameObject Player;






    void Start()
    {
        Player = GameObject.FindWithTag("koleso");
    }


    public void Restart1()
    {
        Application.LoadLevel(Application.loadedLevel);
        //SceneManager.GetActiveScene();
        //SceneManager.LoadScene("Scene1");

    }
}

