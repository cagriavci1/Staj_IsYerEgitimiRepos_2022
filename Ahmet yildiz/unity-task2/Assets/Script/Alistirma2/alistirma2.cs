using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class alistirma2 : MonoBehaviour
{
    public int urun_adet;
    public float adet;
    public int a, b;
    public float c, d;
    public string isim;
    void Start()
    {
        Debug.Log(adet * urun_adet);
        Debug.Log((a + b) * (c + d));
        Debug.Log(isim);
    }

    // Update is called once per frame
    void Update()
    {
      
    }
}
