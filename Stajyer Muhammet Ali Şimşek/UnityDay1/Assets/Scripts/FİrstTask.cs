using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class FİrstTask : MonoBehaviour
{
    int counter;


    void Start()
    {
         counter= 0;    
    }
    void Update()
    {
        //0 sol tık 1 sağ tık
        if (Input.GetMouseButtonDown(0))
        {
            counter++;
            Debug.Log(counter);
        }        
    }
}
