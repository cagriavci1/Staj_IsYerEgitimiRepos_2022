using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fonksiyonlar2 : MonoBehaviour
{

    void ikisayinintoplami(int a,int b)
    {
        Debug.Log(a + b);
    
    }
    void isimyazdir(string isim,int sayi)
    {
        Debug.Log(isim + "  " + sayi);
    }

    void fordongusu(int sayi) 
    {
        for (int i = 0; i < sayi; i++)
        {
            Debug.Log(i);
        }
    
    }
    // Start is called before the first frame update
    void Start()
    {
        ikisayinintoplami(5,10);
        isimyazdir("taha", 50);
        fordongusu(15);
    }

   
}
