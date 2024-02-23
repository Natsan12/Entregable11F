using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraPlayer : MonoBehaviour
{
    public GameObject puntoVisual;



    // Update is called once per frame
    void Update()
    {
        Vector3 position= transform.position;
        position.x = puntoVisual.transform.position.x;
        transform.position = position;

       
    }
}
