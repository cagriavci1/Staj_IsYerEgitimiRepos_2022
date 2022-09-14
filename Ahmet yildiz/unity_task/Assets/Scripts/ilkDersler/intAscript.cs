using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class intAscript : MonoBehaviour
{
    // Start is called before the first frame update
    int a = 5;
    int b = 10;
    float s = 5;
    void Start()
    {
        Debug.Log(a+ " "+ b);
        Debug.Log("float: " + s);
        Debug.Log(a + b);
        Debug.Log(s / 3);
        Debug.Log(s + a);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
