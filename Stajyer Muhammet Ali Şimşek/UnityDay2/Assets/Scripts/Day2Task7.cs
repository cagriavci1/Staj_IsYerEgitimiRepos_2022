using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Day2Task7 : MonoBehaviour
{
    string[] meyveler = {"elma","armut","ananas","þeftali","kayýsý"};
    private void Start()
    {
        for (int i = 0; i < meyveler.Length; i++)
        {
            Debug.Log(meyveler[i]);
        }
    }
}
