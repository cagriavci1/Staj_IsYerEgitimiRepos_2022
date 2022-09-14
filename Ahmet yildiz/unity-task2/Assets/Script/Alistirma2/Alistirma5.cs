using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Alistirma5 : MonoBehaviour
{
    int sayi = 1;
    int rast;
    int buyuk;
    void Start()
    {
        while (sayi < 11) {
            rast = Random.Range(1, 25);
            if (rast > 15) { buyuk++; }
            Debug.Log(rast);
            sayi++;
        }
        Debug.Log("15 den büyük olanlar:" + buyuk);
    }

   
}
