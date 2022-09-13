using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class alistirma10 : MonoBehaviour
{
    int rastgele_sayi;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            rastgele_sayi = Random.Range(1, 101);
            if (rastgele_sayi>50)
            {
                Debug.Log("sayý 5o'den büyük !");
            }
            else if (rastgele_sayi<50)
            {
                Debug.Log("sayi 50'den küçük !");

            }
            else if (rastgele_sayi==50)
            {
                Debug.Log("sayý 50'ye eþit !");
            }
        }
    }
}
