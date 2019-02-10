using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class activate_Frogo : MonoBehaviour 
{
    public Canvas activateFrogo; 

	public Transform myCanvas;

	public Text frogoText;
	public Text lordOfToads;
	public Text clickMe;

	void Start () 
	{
		//activateFrogo  = GetComponent<Canvas>();
        myCanvas = activateFrogo.transform.Find("Frogo");
		frogoText = myCanvas.GetComponent<Text>();
        
		myCanvas = activateFrogo.transform.Find("Lord of the toads");
		lordOfToads = myCanvas.GetComponent<Text>();

        myCanvas = activateFrogo.transform.Find("clickme");
        clickMe = myCanvas.GetComponent<Text>();
	}
	

	void Update () 
	{
		
	}

	void Activate_Frogo()
	{
        frogoText.enabled = true;
		lordOfToads.enabled = true;
		clickMe.enabled = true;
	}
}
