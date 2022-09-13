using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class alistirma12 : MonoBehaviour
{
    int tekrar_miktari = 0, rastgele_sayi, ellidenbuyuk = 0;

    private void Start()
    {
        for (int i = 0; i < 11; i++)
        {
            rastgele_sayi = Random.Range(1, 101);
            Debug.Log(rastgele_sayi);
            
            if (rastgele_sayi > 50)
            {
                ellidenbuyuk++;
            }
        }
        Debug.Log("elliden büyük sayýlar = " + ellidenbuyuk);
    }


}
