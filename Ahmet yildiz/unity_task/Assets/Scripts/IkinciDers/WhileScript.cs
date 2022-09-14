using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhileScript : MonoBehaviour
{
    int a=0;
    // Start is called before the first frame update
    void Start()
    {
        //while (a<10)
        //{
        //    Debug.Log(a);
        //    a++; //10 a kadar olan rakamlarý ekrana yazdýrýr
        //    a+=2; // 10 a kadar olan çift sayýlarý ekrana yazdýrýr.
        //    if (a % 2 == 1)
        //    {
        //        Debug.Log(a); //tek olan sayýlarý yazdýracak.
        //    }
        //}
        //for (int i = 0; i <50; i++)
        //{
        //    if (a % 2 == 1)
        //        Debug.Log(i);
        //}
        //for(int b = 0; b < 10; b+=2)
        //{
        //    Debug.Log(b);
        //}
        for (int k = 50; k >0; k++)
        {
            Debug.Log(k);
        }
    }
}
