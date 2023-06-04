using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dondurme3 : MonoBehaviour
{
    void Start()
    {

    }

    void Update()
    {
        //silindir z ekseninde kendi etrafýnda dönecek.
        transform.Rotate(new Vector3(0, Time.deltaTime * 150, 0));

    }
}
