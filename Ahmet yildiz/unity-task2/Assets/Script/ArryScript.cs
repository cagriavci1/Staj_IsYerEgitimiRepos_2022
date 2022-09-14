using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArryScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int[] a = new int[9];
        //a[0]= 0; a[1] = 1; a[2] = 0;
        //a[3] = 1; a[4] = 0; a[5] = 1;
        //a[6] = 0; a[7] = 1; a[8] = 0;

        //for (int i = 0; i < a.Length; i++)
        //{
        //    //a[i] = i;
        //    Debug.Log(a[i]);
        //}
        string[] ogrenci = { "Ahmet","Muhammet","Elif","Rabia","Ayça" };// þeklinde de tanýmlanýr
        Debug.Log(ogrenci[0]);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
