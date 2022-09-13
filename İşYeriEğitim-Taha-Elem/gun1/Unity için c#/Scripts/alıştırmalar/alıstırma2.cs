using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class alıstırma2 : MonoBehaviour
{
    bool degisken;
   
    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            degisken = !degisken;
            Debug.Log(degisken);
        }
    }
}
