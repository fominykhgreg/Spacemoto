using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class trigger : MonoBehaviour
{
    public AudioClip PrivetFX;

    // Start is called before the first frame update
    void Start()
    {
        //Invoke("kolesa", 2);
        
    }
    void kolesa()
    {
        GetComponent<WheelJoint2D>().enabled = false;
        GetComponent<WheelJoint2D>().enabled = false;
        this.enabled = false;

        //GetComponent<BoxCollider2D>().enabled = false;
        //this.enabled = false;
    }



    // Update is called once per frame
    void Update()
    {

        if (asf.inet > 1){
            kolesa();
        }
        //if (collision.gameObject.tag == "asf")
        //  {
        //      GetComponent<WheelJoint2D>().enabled = false;
        //      this.enabled = false;


        //  }
        //void OnTriggerEnter2D(Collider2D other)
        //{
        //    kolesa();
        //}
        //void OnCollisionEnter2D(Collision2D collision)
        //{
        //    if (collision.gameObject.tag == "asf")
        //    {
        //        kolesa();
        //    }
        //}
         
    }

        private void OnCollisionEnter2D(Collision2D collision)
        {

            if (collision.gameObject.tag == "asf")
            {
                kolesa();
            }
        }
    }
   
       
        
    
 
