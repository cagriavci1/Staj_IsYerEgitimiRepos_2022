using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dizi : MonoBehaviour
{
    string[] sinif_listesi = { "ali", "mehmet", "ayþe", "ahmet", "þeyda" };
    int[] envanter = { 13, 3, 5, 6, 7 };

    private void Start()
    {
        for (int i = 0; i < 5; i++)
        {
            Debug.Log(sinif_listesi[i] + " " + envanter[i]);
        }


    }
}
