using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckBounds : MonoBehaviour 
{

	void Start () 
	{
		
	}
	
	void Update () 
	{
		
	}

    void OnCollisionEnter(Collision collision)
    {
		Debug.Log ("Go back, Toad");
    }
}
