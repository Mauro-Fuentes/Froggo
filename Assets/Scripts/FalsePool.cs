using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FalsePool : MonoBehaviour 
{

	void Start () 
	{
		
	}
	

	void Update () 
	{
		
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("car"))
		{
			Debug.Log ("ENTER POOL");
			Destroy(obj: other.gameObject);
        }
    }

    void OnCollisionEnter(Collision otherObject)   //OnCollisionEnter is called when this collider/rigidbody begun touching another rb/coll.
    {
        Debug.Log(otherObject.collider.name);       //Output the other's Collider's GameObject's name
    }

}
