using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class alistirma7 : MonoBehaviour
{
    public bool denetim;
    string sonuc;
    void Start()
    {
        if(denetim==true)
        {
            sonuc = "Baaþarýlý";
        }
        else
        {
            sonuc = "Baþarýsýz";
        }
        Debug.Log(sonuc);
    }

    
}
