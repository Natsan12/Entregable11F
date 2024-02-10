using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
	public float velocidadCaminar = 5f;
	public float velocidadSalto = 10f;
	public float alturaAgacharse = 0.5f;
	public string Horizontal, Vertical;

	private bool estaAgachado=false;

    private void FixedUpdate()
    {
		float movimientoHorizontal = Input.GetAxisRaw(Horizontal);
		float movimientoVertical = Input.GetAxisRaw(Vertical);

		transform.position = new Vector2(movimientoVertical, movimientoHorizontal * velocidadCaminar * Time.deltaTime);
	}


}
