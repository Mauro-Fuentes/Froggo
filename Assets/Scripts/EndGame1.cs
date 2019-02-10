using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGame1 : MonoBehaviour 
{

	void Start () 
	{
	}
	
	void Update () 
	{
	}

    void OnTriggerEnter()
    {
        Debug.Log("YOU WON!");
        StartCoroutine(LoadYourAsyncScene());
    }


    IEnumerator LoadYourAsyncScene()
	{
    	
		AsyncOperation asyncLoad = SceneManager.LoadSceneAsync("Scene3");

		// Wait until the asynchronous scene fully loads
		while (!asyncLoad.isDone)
		{
			yield return null;
		}
	}
}
