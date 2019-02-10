using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewCarMover : MonoBehaviour 
{
	public float velocity = 1f;

	public GameObject findFrog;
	Rigidbody frogRigidBody;

	public float collisionCheckDistance;
    public float distanceToCollision;

	bool aboutToCollide;


	public AudioClip carHorn;
    AudioSource fetchAudioSource;

	void OnEnable()
	{
		findFrog = GameObject.Find("GreenFrog");
	}


	void Start () 
	{

		fetchAudioSource = GetComponent<AudioSource>();

		frogRigidBody = findFrog.GetComponent<Rigidbody>();
	}


	void Update () 
	{
		transform.Translate(Vector3.left * Time.deltaTime * velocity, Space.World);

		CheckDistanceToFrog();

	}


	void CheckDistanceToFrog()
    {
        RaycastHit hit;

        if (frogRigidBody.SweepTest(transform.forward, out hit, collisionCheckDistance))
        {

			aboutToCollide = true;
            distanceToCollision = hit.distance;
			
		
			// fetchAudioSource.clip = carHorn;
			// fetchAudioSource.Play();

        }
    }


}
