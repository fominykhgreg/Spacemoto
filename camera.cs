using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{

    
        GameObject player;

        const float speedMove = 1.7f;

        void Start()
        {
            player = GameObject.FindWithTag("Player");
        }

        void Update()
        {
            float direction = player.transform.position.x - transform.position.x;

        if (direction < -0.2)
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }

        if (direction > 0)
        {
            transform.rotation = Quaternion.Euler(0, 180, 0);
        }
        if (Mathf.Abs(direction) < 150)
            {
                Vector3 pos = transform.position;
                pos.x += Mathf.Sign(direction) * speedMove * Time.deltaTime;
                transform.position = pos;
            }
        }
    }

