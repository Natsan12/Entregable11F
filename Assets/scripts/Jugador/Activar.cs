using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activar : MonoBehaviour
{
    // Start is called before the first frame update
    public Animator obstaculo1; 

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Obstaculo"))
        {
            obstaculo1.enabled = true;
            Debug.Log("moverse");
        }
    }
}
