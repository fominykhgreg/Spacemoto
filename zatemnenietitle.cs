using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class zatemnenietitle : MonoBehaviour
{


    public Image AlphaImage;

    // Start is called before the first frame update
    void Start()
    {
        //zkonectitle.zastavkaValue = 0;
    }



    // Update is called once per frame
    void Update()
    {
        if (title.titleValue > 0)
        {

            AlphaImage.color = new Color(AlphaImage.color.r, AlphaImage.color.g, AlphaImage.color.b, AlphaImage.color.a + 1.2f * Time.deltaTime);
        }
    }
}
