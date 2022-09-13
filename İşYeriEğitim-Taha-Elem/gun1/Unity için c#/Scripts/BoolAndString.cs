using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoolAndString : MonoBehaviour
{
    string isim = "Taha";//string yazý deðiþkenidir
    string soyisim = "ELEM";
    bool karakteryerde = true;
    string stringtaným = "string yazý deðiþkenidir sadece metin karakterleri içerir.";
    string booltaným = "bool ise sadece true ve false deðerleri arasýnda geçiþ yapabilir.";
    private void Start()
    {
        karakteryerde = !karakteryerde;
        Debug.Log(isim + " " + soyisim);
        Debug.Log(karakteryerde +" aslýnda "+ !karakteryerde + "'dur");
        Debug.Log(stringtaným);
        Debug.Log(booltaným);


    }
}
