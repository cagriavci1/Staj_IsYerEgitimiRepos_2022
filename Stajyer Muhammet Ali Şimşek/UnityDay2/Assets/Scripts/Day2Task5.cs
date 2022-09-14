using System.Collections;
using System.Collections.Generic;
using System.Net;
using UnityEngine;

public class Day2Task5 : MonoBehaviour
{
    int sayi;
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            sayi = Random.Range(1, 101);
            Debug.Log(sayi);
            if (sayi<50)
            {
                Debug.Log("50'den küçük");
            }
            else if (sayi == 50)
            {
                Debug.Log("50'ye eþit");
            }
            else
            {
                Debug.Log("50'den büyük");
                
            }
        }
    }
}
