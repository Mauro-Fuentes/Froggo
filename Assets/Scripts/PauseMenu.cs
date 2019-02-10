using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour 
{
	public GameObject child;
	public GameObject deadCanvas;

	void Awake()
	{
		// Restart all funtionality
		CheckDistance.isDead = false;


	}

	void Start ()
	{
		child = gameObject.transform.Find ("Menu_Pause").gameObject;
		deadCanvas = gameObject.transform.Find ("YouAreDead").gameObject;

	}

	void Update () 
	{
		FreezeTime();
		CheckIsDead();
	}

    public void CheckIsDead()
    {
	
		if (CheckDistance.isDead)
        {
			deadCanvas.gameObject.SetActive(true);
		}
    }

    public void FreezeTime ()
	{
		if (Input.GetKeyDown(KeyCode.P) || (Input.GetKeyDown(KeyCode.Escape) ))
		{
			if (child.gameObject.activeInHierarchy == false)
			{	
				child.gameObject.SetActive(true);	
				Time.timeScale = 0f;
				AudioListener.pause = true;
			}

			else
            {
                DeactiveFreeze();
            }
        }
	}



    public void DeactiveFreeze()	// Método extraído de FreezeTime()... else;
    {
        child.gameObject.SetActive(false);
        Time.timeScale = 1f;
        AudioListener.pause = false;
    }



    public void QuitGame ()
	{	
		Debug.Log ("Game is Off");
		Application.Quit();
	}



	public void GoMainMenu()
	{
        bool Scene0_hasbeenLoaded;
		
		// Scene currentscene = SceneManager.GetActiveScene();
        
		SceneManager.LoadScene("Scene0", LoadSceneMode.Single);


		DeactiveFreeze();

		Scene0_hasbeenLoaded = SceneManager.GetSceneByName("Scene0").isLoaded;

        if (Scene0_hasbeenLoaded == true)
        {   
			SceneManager.SetActiveScene(SceneManager.GetSceneByName("Scene0"));
        }

    }
	


	public void Restart()
	{	

		Scene currentscene = SceneManager.GetActiveScene();

        SceneManager.LoadScene(currentscene.name);

		bool currentscene_hasbeenLoaded = SceneManager.GetSceneByName(currentscene.name).isLoaded;

        if (currentscene_hasbeenLoaded == true)
        {
            SceneManager.SetActiveScene(SceneManager.GetSceneByName(currentscene.name));
        }

	
	}
}
