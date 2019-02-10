using UnityEngine;

public class CheckDistance : MonoBehaviour 
{

    public float collisionCheckDistance;
    public float distanceToCollision;

    bool aboutToCollide;

    public AudioClip pedoClip;
    // public AudioClip rebep;
    public AudioSource fetchAudioSource;

    Rigidbody rb;
    GameObject bodyHolder;
    GameObject deadBodyHolder;

    FrogMovement frogMovScript;

    public static bool isDead;


    void Awake()
    {
        rb = GetComponent<Rigidbody>();
        fetchAudioSource = GetComponent<AudioSource>();
    }

    void Start()
    {
        bodyHolder = gameObject.transform.Find("bodyholder").gameObject;
        deadBodyHolder = gameObject.transform.Find("DeadBodyHolder").gameObject;

        frogMovScript = GetComponent<FrogMovement>();
    }


    void Update()
    {
		// CheckDistanceToCar();
		// AboutToCollide();
        if (Input.anyKeyDown)
        {
            JumpSound();
        }
    }

	// void CheckDistanceToCar()
    // {
    //     RaycastHit hit;
    //     if (rb.SweepTest(transform.forward, out hit, collisionCheckDistance))
    //     {
    //         aboutToCollide = true;
    //         distanceToCollision = hit.distance;
    //     }
    // }

    // void AboutToCollide()
    // {
    //     if (aboutToCollide)
    //     {
    //         Debug.Log("What are you lookin' at, madafaka");
    //     }
    // }




    void OnCollisionEnter(Collision otherObject)   
    {
        if (otherObject.gameObject.CompareTag("car"))
        { 
            Debug.Log ("run-over");
            
            bodyHolder.SetActive(false);

            activateDeadBody();

            rb.isKinematic = true;

            frogMovScript.enabled = false;
            this.enabled = false;

            fetchAudioSource.clip = pedoClip;
            fetchAudioSource.Play();

            isDead = true;
        }
    }

    void activateDeadBody()
    {

        if (deadBodyHolder.gameObject.activeInHierarchy == false)
        {
            deadBodyHolder.gameObject.SetActive(true);

            rb.GetComponent<Collider>().enabled = false;           
            //AudioListener.pause = true; 
        }

    }

    void JumpSound()
    {   
        // fetchAudioSource.clip = rebep;
        bool result = Random.value < 5 ? true : false;
			
        //Sound horn
        if (result)
        {
            fetchAudioSource.Play();
        }

    }

}
