using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class alistirma13 : MonoBehaviour
{

    string[] meyveler = { "elma", "armut", "portakal", "viþne", "kiraz" };
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 5; i++)
        {
            Debug.Log(meyveler[i]);
        }
        
    }

    
}
