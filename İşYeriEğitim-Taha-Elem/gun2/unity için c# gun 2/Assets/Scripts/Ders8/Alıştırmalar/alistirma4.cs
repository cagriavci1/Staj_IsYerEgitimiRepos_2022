using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class alistirma4 : MonoBehaviour
{
    public float urun_fiyat =2.95f;
    public int urun_adet =100;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(urun_fiyat * urun_adet);
    }

    
}
