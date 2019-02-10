using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HalfWayThru : MonoBehaviour 
{

	public Canvas accessCanvas;
	Transform getCanvas;

	void Start () 
	{
		accessCanvas.GetComponent<Canvas>();
		getCanvas = accessCanvas.transform.Find ("GoOn_50");
	}

	void Update () 
	{
		
	}


	


	void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
		{
			Debug.Log ("Go on Frogo");
			getCanvas.gameObject.SetActive(true);
			StartCoroutine("WaitOneSecond");
        }
    }

	IEnumerator WaitOneSecond()
	{
		yield return new WaitForSeconds(3);
		getCanvas.gameObject.SetActive(false);
	}

	void Ondisabled()
	{
		StopAllCoroutines();
	}
}