using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camerasm : MonoBehaviour
{
    public GameObject player; // тут объект игрока
    private Vector3 offset;

    void Start()
    {
        offset = transform.position - player.transform.position;
    }

    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }



    //public Transform target;
    //public float smooth = 5.0f;
    //public Vector3 offset = new Vector3(0, 2, -5);
    //void Update()
    //{
    //    transform.position = Vector3.Lerp(transform.position, target.position + offset, Time.deltaTime * smooth);
    //}

}