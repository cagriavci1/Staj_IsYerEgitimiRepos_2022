using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlistirmafonkScript : MonoBehaviour
{
    // Start is called before the first frame update
    //void ikisayi(int a, int b)
    //{
    //    Debug.Log(a + b);
    //}
    //void isim(string a,int b) { Debug.Log(a); Debug.Log(b); }
    //void Start()
    //{
    //    ikisayi(5, 10);
    //    isim("Ahmet",5);
    //}
    void forDongu(int a) { for (int i =0; i<a;i++) { Debug.Log(i); } }
     void Start()
    {
        forDongu(5);
    }
}
