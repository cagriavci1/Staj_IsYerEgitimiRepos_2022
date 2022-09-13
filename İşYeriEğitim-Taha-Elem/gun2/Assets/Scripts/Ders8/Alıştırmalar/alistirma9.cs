using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class alistirma9 : MonoBehaviour
{
    int rastgele_sayi;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            rastgele_sayi = Random.Range(1, 11);
            Debug.Log(rastgele_sayi);
            if(rastgele_sayi%2==0)
            {
                Debug.Log("rastgele sayýmýz çif !");

            }
            else
            {
                Debug.Log("rastgele sayýmýz tek sayý!");
            }

        }
    }
}
