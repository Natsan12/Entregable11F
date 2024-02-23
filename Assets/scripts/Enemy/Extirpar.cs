using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Extirpar : MonoBehaviour
{
   /* public void OnCollisionEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            this.gameObject.SetActive(false);
        }

    
    }*/

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            this.gameObject.SetActive(false);
        }
    }


}
