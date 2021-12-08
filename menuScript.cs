using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menuScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.JoystickButton0))
        {
            SceneManager.LoadScene("Scene1");
            
        }

        if (Input.GetKeyDown(KeyCode.JoystickButton1))
        {
            SceneManager.LoadScene("Scene2");

        }
        if (Input.GetKeyDown(KeyCode.JoystickButton2))
        {
            SceneManager.LoadScene("Scene3");

        }
    }
}
