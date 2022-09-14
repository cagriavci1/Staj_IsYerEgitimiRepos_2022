using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sart_ifadeleri : MonoBehaviour
{
    int a = 1;
    private void Start()
    {
        if (a == 1)
        {
            Debug.Log("a Deðiþkeni 1'e eþittir.");
        }

        else if (a == 2)
        {
            Debug.Log("a deðiþkeni 2'ye eþittir.");
        }

        else if (a == 3)
        {
            Debug.Log("a deðiþkeni 3'e eþittir.");
        }

        else 
        {
            Debug.Log("a deðiþkeni 1'e eþit deðildir.");
        }

        // random ile deðiþken kontrolü

        a = Random.Range(0, 6);
        Debug.Log(a);

        if (a==1)
        {
            Debug.Log("a= 1");

        }
        
        else if(a==2)
        {
            Debug.Log("a= 2");
        }
        else if(a>=3)
        {
            Debug.Log("a >= 1");
        }
        else
        {
            Debug.Log("a= 0");
        }


    }
}
