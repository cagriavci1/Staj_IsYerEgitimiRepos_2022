using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondTask : MonoBehaviour
{
    bool variable = true;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            variable = !variable;
            Debug.Log(variable);
        }        
    }
}
