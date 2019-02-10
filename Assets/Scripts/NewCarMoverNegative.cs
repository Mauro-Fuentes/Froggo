using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewCarMoverNegative : MonoBehaviour 
{
	public float velocity = 1f;

	void Start () {
		
	}
	

	void Update () {
		transform.Translate(Vector3.right * Time.deltaTime * velocity, Space.World);
	}
}
