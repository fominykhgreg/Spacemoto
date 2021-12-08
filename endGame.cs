using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;

public class endGame : MonoBehaviour
{
    public static int lifeValue = 1;
    public static float deltaTime;
    float score;
    float timer1;
    Text endGame1;
    bool enableTimer = true;
    float timer = 0f;
    // Start is called before the first frame update
    void Start()
    {
        endGame1 = GetComponent<Text>();
        
    }
    
    // Update is called once per frame
    void Update()
    {
        timer=0+ Time.deltaTime;

        score += Time.deltaTime;

        float res = ((int)(score * 10));
       

        if (lifeValue <= 0)
        {
            endGame1.text = res.ToString("#.##") + " ";
            
            
            
        }
    }
}
