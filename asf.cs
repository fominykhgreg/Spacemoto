using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class asf : MonoBehaviour
{
    GameObject player;
    public static float inet = 1;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("moto");
    }

    // Update is called once per frame
    void Update()
    {
        void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.gameObject.tag == "moto")
            {
                inet += 1;
            }
        }
    }
}
