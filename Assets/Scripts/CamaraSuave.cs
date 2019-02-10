using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraSuave : MonoBehaviour 
{
	public GameObject target;	// posición de Otro

	public float arrastre	= 9f;	// velocidad de actualización

	public Vector3 offset;	// distancia al Otro

	void Awake()
	{
		target = GameObject.FindGameObjectWithTag("Player");
		
	}

	void LateUpdate () 
	{
		Vector3 nuevaPosicion = target.transform.position + offset; 
		Vector3 lag	= Vector3.Lerp (transform.position, nuevaPosicion, arrastre * Time.deltaTime);
		
		transform.position = lag;
	}
}
