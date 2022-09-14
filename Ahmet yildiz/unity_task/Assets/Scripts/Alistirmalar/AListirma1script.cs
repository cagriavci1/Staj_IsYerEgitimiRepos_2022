using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AListirma1script : MonoBehaviour
{
    // Start is called before the first frame update
    int sayac;
    void Start()
    {
        sayac = 0;
    }

    // Update is called once per frame
    void Update()
    {
        //GetMouseButtonDown da masun sol kýsmýna tek tek basýnca artýyor
        //GetMouseButton basýldýðý andan itibaren ellini çekene kadar artýyor.
        //GetkeyButton de ise belirlediðin 
        if (Input.GetMouseButtonDown(0))
        {
            sayac++;
            Debug.Log(sayac);
        }   
    }
}
