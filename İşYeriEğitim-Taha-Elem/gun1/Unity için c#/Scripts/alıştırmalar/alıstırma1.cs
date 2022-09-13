using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class alıstırma1 : MonoBehaviour
{
    int sayac;
    private void Start()
    {
        sayac = 0;

    }
    private void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            sayac++;
            Debug.Log(sayac);

        }
    }
}
