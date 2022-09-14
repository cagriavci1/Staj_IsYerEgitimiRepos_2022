using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Alistirma6 : MonoBehaviour
{
    string[] meyve = {"armut","elma","karpuz","kiraz","çilek" };
    
    void Start()
    {
        for (int i = 0; i < 5; i++)
        {
            Debug.Log(meyve[i]);
        }
        
    }

}
