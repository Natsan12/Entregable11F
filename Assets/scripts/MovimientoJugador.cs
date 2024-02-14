using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
	public float velocidadCaminar = 5f;
	public float fuerzaSalto = 10f;
    public Rigidbody2D rb;
    private bool Grounded;
    //private Animator animator;
	

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
       // animator.GetComponent<Animator>();
    }
    private void FixedUpdate()
    {
		float movimientoHorizontal = Input.GetAxisRaw("Horizontal");
       // animator.SetBool("Jump", movimientoHorizontal!= 0.0f);

        Debug.DrawRay(transform.position, Vector3.down*0.1f, Color.red); //Dibujar el ray


        if (Physics2D.Raycast(transform.position, Vector2.down, 0.1f))
        {
            Grounded = true;            
        }
        else Grounded = false;


		rb.velocity = new Vector2(movimientoHorizontal*velocidadCaminar,rb.velocity.y);
        Saltar();
	}
    private void Saltar()
    {
        float movimientoVertical = Input.GetAxisRaw("Vertical");
        if (Input.GetKey(KeyCode.UpArrow) && Grounded) 
        {
            rb.AddForce(Vector2.up * fuerzaSalto, ForceMode2D.Impulse);
        }
        //if (movimientoVertical == 1) 
        //{
        //    rb.AddForce(Vector2.up * fuerzaSalto, ForceMode2D.Impulse);
        //}
    }

}
