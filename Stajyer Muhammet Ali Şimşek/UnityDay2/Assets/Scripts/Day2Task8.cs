using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Day2Task8 : MonoBehaviour
{
    public string yazi;

    public void konsolaYazdir()
    {
        Debug.Log(yazi);
    }

    public int sayi1, sayi2;

    public void topla()
    {
       Debug.Log(sayi1 + sayi2);
    }
    //-----------------------Parametreliler---------------------------

    public void forDongusu(int a)
    {
        for (int i = 0; i < a; i++)
        {
            Debug.Log(i);
        }
    }

    private void Start()
    {
        forDongusu(10);
    }


}
