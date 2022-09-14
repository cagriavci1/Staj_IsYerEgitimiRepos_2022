using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aliştirma2Script : MonoBehaviour
{
    // Start is called before the first frame update
    bool değişken;
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            değişken = !değişken;
            Debug.Log(değişken);
        }
    }
}
