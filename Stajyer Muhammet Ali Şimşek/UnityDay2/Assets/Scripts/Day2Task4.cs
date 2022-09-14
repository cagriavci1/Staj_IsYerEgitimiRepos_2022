using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Day2Task4 : MonoBehaviour
{
    int rastgele;

    private void Update()
    {
        
        if (Input.GetMouseButtonDown(0))
        {
            rastgele = Random.Range(1, 11);
            Debug.Log(rastgele);
            if (rastgele%2==0)
            {
                Debug.Log("Çift sayý deðeri atandý");
            }
            else
            {
                Debug.Log("Tek sayý deðeri atandý");
            }
        }
    }
}
