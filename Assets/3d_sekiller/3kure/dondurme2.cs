using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dondurme2 : MonoBehaviour
{
    void Start()
    {

    }

    void Update()
    {
        //k�re z ekseninde kendi etraf�nda d�necek.
        transform.Rotate(new Vector3(Time.deltaTime * 75, 0, Time.deltaTime * 75));

    }
}
