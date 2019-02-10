using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mushroom : MonoBehaviour 
{
	public GameObject quitFirtsMessage;
	public GameObject messageForFrogo;
	

	void Start () 
	{
		quitFirtsMessage = gameObject.transform.Find ("FirstMessage").gameObject;
		messageForFrogo = gameObject.transform.Find ("SecondMessage").gameObject;
		
	}
	
	void Update () 
	{
		
	}

	void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
		{
			Debug.Log ("fsdfadsfa");
			quitFirtsMessage.gameObject.SetActive(false);
			messageForFrogo.gameObject.SetActive(true);
        }
    }

}
