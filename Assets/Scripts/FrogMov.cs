using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrogMov : MonoBehaviour 
{
    public Rigidbody rb;

    AudioSource fetchAudio;
    public AudioClip rebep;

	bool up;
	bool down;
	bool left;
	bool right;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
	{
        checkInput();
	}

    void FixedUpdate()
    {
        if (up)
        {
            rb.MovePosition(position: transform.position + new Vector3(0, 0, 40) * Time.deltaTime);
			up = false;
        }

		if (down)
		{
            rb.MovePosition(transform.position + new Vector3(0, 0, -100) * Time.deltaTime);
            down = false;
		}

		if (left)
		{
            rb.MovePosition(transform.position + new Vector3(-100, 0, 0) * Time.deltaTime);
			left = false;
		}

		if (right)
		{
            rb.MovePosition(transform.position + new Vector3(100, 0, 0) * Time.deltaTime);
			right = false;
		}
    
    }
	

    private void checkInput()
    {

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            MoveUP();
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            MoveDOWN();
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            MoveLEFT();
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            MoveRIGHT();
        }

    }


	void MoveUP() 
	{ up = true; }

	void MoveDOWN()
	{ down = true; }	

	void MoveRIGHT()
	{ right = true; }

	void MoveLEFT()
	{ left = true; }


}
