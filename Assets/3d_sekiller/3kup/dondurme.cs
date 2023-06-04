using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dondurme : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        //küp z ekseninde kendi etrafýnda dönecek.
        transform.Rotate(new Vector3(0, 0, Time.deltaTime * 75));

    }
}
