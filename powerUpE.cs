using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class powerUpE : MonoBehaviour
{

    public GameObject Player;

    




    void Start()
    {
        Player = GameObject.FindWithTag("koleso");
    }


    void OnCollisionEnter2D(Collision2D variable)
    {
        if (variable.gameObject == Player)
        {
            endGame.lifeValue -= 1;
            Destroy(gameObject);
            SceneManager.LoadScene("SceneE");
        }

    }
}

