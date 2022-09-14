using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdTask : MonoBehaviour
{

    int sayi;
    bool ciftSayiMi;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            sayi = Random.Range(0, 101);
            if (sayi % 2 == 0)
            {
                ciftSayiMi = true;

            }
            else ciftSayiMi = false;


            Debug.Log("Sayý : " + sayi + "\n Çift mi ? : " + ciftSayiMi);

        }        
    }
}
