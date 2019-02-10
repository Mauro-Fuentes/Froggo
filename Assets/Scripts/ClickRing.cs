using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClickRing : MonoBehaviour 
{
    public AudioClip voiceClip;
    public AudioClip letstart;

    public AudioSource fetchAudioSource;
    public Animator fetchAnimator;

    //bool animHalo;

    void Start()
    {
        fetchAudioSource = GetComponent<AudioSource>();
        fetchAnimator = GetComponent<Animator>();
        //animHalo = false;
    }

    void OnMouseUpAsButton()
    {
        fetchAudioSource.Play();
        fetchAnimator.SetBool("halo", true);
        StartCoroutine(LoadSceneDummy());
    }

    IEnumerator LoadSceneDummy()
    {
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene("Scene1");
    }
    
}
