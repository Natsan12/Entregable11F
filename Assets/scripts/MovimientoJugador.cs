using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
	public float velocidadCaminar = 5f;
	public float fuerzaSalto = 10f;
    public Rigidbody2D rb;
	

	

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void FixedUpdate()
    {
		float movimientoHorizontal = Input.GetAxisRaw("Horizontal");
		

		rb.velocity = new Vector2(movimientoHorizontal*velocidadCaminar,rb.velocity.y);
        Saltar();
	}
    private void Saltar()
    {
        float movimientoVertical = Input.GetAxisRaw("Vertical");
        if (Input.GetKey(KeyCode.UpArrow)) 
        {
            rb.AddForce(Vector2.up * fuerzaSalto, ForceMode2D.Impulse);
        }
        //if (movimientoVertical == 1) 
        //{
        //    rb.AddForce(Vector2.up * fuerzaSalto, ForceMode2D.Impulse);
        //}
    }

}
