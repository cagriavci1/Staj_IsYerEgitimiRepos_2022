using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Day2Task6 : MonoBehaviour
{
    byte sayac=1;
    byte buyuk=0;
    byte sayi;
    
    void Start()
    {
        while (sayac<11)
        {
            sayi = ((byte)(Random.Range(1, 101)));
            Debug.Log(sayi);
            if (sayi > 50)
            {
                buyuk++;
            }
            sayac++;
        }
        Debug.Log(buyuk+" tane sayý 50'den büyüktür.");
    }

    void Update()
    {
        
    }
}
