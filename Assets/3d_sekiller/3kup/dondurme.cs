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
        //k�p z ekseninde kendi etraf�nda d�necek.
        transform.Rotate(new Vector3(0, 0, Time.deltaTime * 75));

    }
}
