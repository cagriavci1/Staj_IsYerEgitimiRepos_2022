using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Day2Task1 : MonoBehaviour
{
    public float fiyat;
    public int urun_adedi;
    private float son_fiyat;
    void Start()
    {
        son_fiyat = fiyat * urun_adedi;
        Debug.Log(son_fiyat); 
    }

    
}
