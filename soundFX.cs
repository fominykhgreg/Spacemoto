using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class soundFX : MonoBehaviour
{
    public AudioSource AudioS;
    // Start is called before the first frame update
    void Start()
    {
        AudioS = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKeyDown)
        {
            AudioS.Play();
        }
    }
}
