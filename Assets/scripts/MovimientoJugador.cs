//using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering;
using static UnityEditor.Searcher.SearcherWindow.Alignment;

public class MovimientoJugador : MonoBehaviour
{  // public GameObject PuntoDisparo;
	public float velocidadCaminar = 15f;
	public float fuerzaSalto = 50f;
    public Rigidbody2D rb;
    public LayerMask Grounded;
    public bool ground;
    public Animator animator;

    public string horizontal;
    public KeyCode salto;
    //public bool ladderUp = false;
	

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        animator=GetComponent<Animator>();

      


    }
    private void FixedUpdate()
    {
        
        float movimientoHorizontal = Input.GetAxisRaw(horizontal);
        
        if(movimientoHorizontal<0.0f)transform.localScale = new Vector3 (-1.0f,1.0f,1.0f);// Girar el jugador 
        else if(movimientoHorizontal>0.0f)transform.localScale=new Vector3(1.0f,1.0f,1.0f);
        Debug.DrawRay(transform.position, Vector3.down*0.1f, Color.red); //Dibujar el ray


        ground = Physics2D.Raycast(transform.position, Vector3.down, 0.1f,Grounded);



        if (Input.GetKey(salto) && ground)
        {
            rb.AddForce(Vector2.up * fuerzaSalto, ForceMode2D.Impulse);
            { 
                Saltar(); 
            }

                animator.SetTrigger("jump");
            Debug.Log("entro");
        }
    

        rb.velocity = new Vector2(movimientoHorizontal*velocidadCaminar,rb.velocity.y);
        if(movimientoHorizontal !=0 )
        {
            animator.SetFloat("velX", movimientoHorizontal);
        }
        //if (Input.GetKey(KeyCode.DownArrow))

        //{
          // Shoot();
        //}

    }
    private void Saltar()
    
    {
        //float movimientoVertical = Input.GetAxisRaw("Vertical");
        //rb.velocity = new Vector2(0f, movimientoVertical * velocidadCaminar);
        

      
        

    }

        
    //private void Shoot()

     //{ Vector3 direction;
       // if (transform.localScale.x == 1.0f) direction = Vector2.right;
        //else direction = Vector2.left;

       

        //GameObject Bullets=Instantiate(PuntoDisparo.position+(direction*0.1f),Quaternion.identity);
        //Bullets.GetComponent <Bullets>().SetDirection ( direction);
    }













//}
//if (movimientoVertical !=0 && ground && ladderUp)
//{

//    animator.SetFloat("velX", movimientoVertical);

//    Debug.Log("prueba");





//if(!ground)
//{
//    mano = true;
//}


//    private void OnTriggerEnter2D(Collider2D collision)
//    {
//        if(collision.gameObject.CompareTag("Ladder"))
//        {
//            ladderUp = true;
//        }
//    }

//}
