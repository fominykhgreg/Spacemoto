using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class title : MonoBehaviour
{
    
    public static int titleValue = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void zapusk()
    {
        Application.LoadLevel("Scene1");
    }
        // Update is called once per frame
        void Update()
    {
        if (Input.anyKey)
        {
            //zapusk();
            Invoke("zapusk", 1);
            titleValue += 1;
            
        }
    }
}
