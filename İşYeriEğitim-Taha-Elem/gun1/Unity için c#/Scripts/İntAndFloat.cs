using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class İntAndFloat : MonoBehaviour
{
    int a = 7;
    int b = 10;
    float c = 7.2f;
    private void Start()
    {
        Debug.Log(a);
        Debug.Log(b);
        Debug.Log(c);
        Debug.Log(a / 3);//int tamsayı şeklinde sonuç verir
        Debug.Log(c / 3);//float küsüratlı olarak sonuç verir
        Debug.Log(a * b);
        Debug.Log(c * b);
        Debug.Log(a + b);
        Debug.Log(c + b);
        Debug.Log(a - b);
        Debug.Log(c-b);

    }

}
