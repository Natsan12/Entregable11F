using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering;

public class MovimientoJugador : MonoBehaviour
{
	public float velocidadCaminar = 5f;
	public float fuerzaSalto = 10f;
    public Rigidbody2D rb;
    public LayerMask Grounded;
    public bool ground;
    public Animator animator;
    public bool ladderUp = false;
	

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        animator=GetComponent<Animator>();

      


    }
    private void FixedUpdate()
    {
        Saltar();
        float movimientoHorizontal = Input.GetAxisRaw("Horizontal");
        

        Debug.DrawRay(transform.position, Vector3.down*0.1f, Color.red); //Dibujar el ray


        ground = Physics2D.Raycast(transform.position, Vector2.down, 0.1f,Grounded);
        
          
          
  


		rb.velocity = new Vector2(movimientoHorizontal*velocidadCaminar,rb.velocity.y);
        if(movimientoHorizontal !=0 )
        {
            animator.SetFloat("velX", movimientoHorizontal);
           

        }
        //else
        //{
        //    animator.SetBool("Jumping", mano = true);
        //}       
       
        
    }
    private void Saltar()
    {
        float movimientoVertical = Input.GetAxisRaw("Vertical");
        rb.velocity = new Vector2(0f, movimientoVertical * velocidadCaminar);

        if (Input.GetKey(KeyCode.UpArrow) && ground && !ladderUp) 
        {
            rb.AddForce(Vector2.up * fuerzaSalto, ForceMode2D.Impulse);
            
            animator.SetTrigger("jump");
            Debug.Log("entro");
            


        }
        if (movimientoVertical !=0 && ground && ladderUp)
        {

            animator.SetFloat("velX", movimientoVertical);
           
            Debug.Log("prueba");


        }


        //if(!ground)
        //{
        //    mano = true;
        //}

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Ladder"))
        {
            ladderUp = true;
        }
    }

}
