using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class alistirma11 : MonoBehaviour
{
    int tekrar_miktari=0, rastgele_sayi,ellidenbuyuk=0;

    private void Start()
    {
        while (tekrar_miktari<11)
        {
            rastgele_sayi = Random.Range(1, 101);
            Debug.Log(rastgele_sayi);
            tekrar_miktari++;
            if (rastgele_sayi>50)
            {
                ellidenbuyuk++;
            }
        }
        Debug.Log("elliden büyük sayýlar = " + ellidenbuyuk);
    }
}
