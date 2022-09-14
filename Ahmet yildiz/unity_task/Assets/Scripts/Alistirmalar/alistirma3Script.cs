using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class alistirma3Script : MonoBehaviour
{
    // Start is called before the first frame update
    int sayi;
    bool ciftsayimi;
    

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            sayi = Random.Range(0, 101);
            if (sayi % 2 == 0)
            {
                ciftsayimi = true;
                
            }
            else
            {
                ciftsayimi = false;
            }
            Debug.Log(sayi);
            Debug.Log(ciftsayimi);
        }   
    }
}
