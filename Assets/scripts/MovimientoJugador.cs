using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
	public float velocidadCaminar = 5f;
	public float velocidadSalto = 10f;

	

	private bool estaAgachado=false;
	private Rigidbody rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }
    private void FixedUpdate()
    {
		float movimientoHorizontal = Input.GetAxisRaw("Horizontal");
		float movimientoVertical = Input.GetAxisRaw("Vertical");

		rb.velocity = new Vector2(movimientoHorizontal,rb.velocity.y);
	}


}
