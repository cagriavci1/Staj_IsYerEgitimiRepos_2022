using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fonksiyonlar : MonoBehaviour
{
    public string yazi = " deneme fonksiyonudur !!!";
    public int sayi1 = 10, sayi2 = 30;
    public string isim = "taha";
    public int a=15, b=11;
    public void ekranayazdir()
    {
        Debug.Log(yazi);
    }
    public void toplama() 
    {
        Debug.Log("toplam = "+(sayi1 + sayi2));
    }

    public void isimyazdir() 
    {

        Debug.Log(isim);
        //toplamsayi(); // sonsuz döngüye sebep olur
    }

    public void toplamsayi()
    {
        Debug.Log("toplam="+(a + b));
        isimyazdir();
    }
}
