using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFollowCamera : MonoBehaviour
{


    GameObject player;

    public float speedMove = 4f;

    void Start()
    {
        player = GameObject.FindWithTag("moto");
    }

    void Update()
    {
        float direction = player.transform.position.x - transform.position.x;
        float direction1 = player.transform.position.y - transform.position.y;


        if (Mathf.Abs(direction) <= 5 && Mathf.Abs(direction) > 1)
        {
            Vector3 pos = transform.position;
            pos.x += Mathf.Sign(direction) * speedMove * Time.deltaTime;
            transform.position = pos;
        }
        if (Mathf.Abs(direction1) <= 5 && Mathf.Abs(direction1) > 1)
        {
            Vector3 pos = transform.position;
            pos.y += Mathf.Sign(direction1) * speedMove * Time.deltaTime;
            transform.position = pos;
        }
    }
}

    

