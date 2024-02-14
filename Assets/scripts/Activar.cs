using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activar : MonoBehaviour
{
    // Start is called before the first frame update
    public Animator plataforma; 

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Obstaculo"))
        {
            plataforma.enabled = true;
            Debug.Log("moverse");
        }
    }
}
