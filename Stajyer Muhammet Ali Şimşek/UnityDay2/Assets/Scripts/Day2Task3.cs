using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Day2Task3 : MonoBehaviour
{
    float ortalama;
    public float not1, not2, not3;

    private void Start()
    {
        ortalama = (not1+not2+not3)/3;
        Debug.Log(ortalama);
        if (ortalama >= 50)
        {
            Debug.Log("Geçti");
            
        }
        else
        {
            Debug.Log("Kaldý");
        }
    }


}
