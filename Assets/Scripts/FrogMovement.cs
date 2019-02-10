using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrogMovement : MonoBehaviour 
{

    public Transform target;    // target to follow back and forth
    public Transform target2;   // target to follow right and left

    public GameObject fetchTargetInFront;
    public GameObject fetchTargetInBack;

    public float speed = 40;

    void Start()
    {
        fetchTargetInFront = gameObject.transform.Find("targetFandB").gameObject;
        fetchTargetInBack = gameObject.transform.Find("targetLandR").gameObject;

        target = fetchTargetInFront.transform;
        target2 = fetchTargetInBack.transform;

    }

    void Update()
    {
        checkInput();

    }

    private void checkInput()
    {

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {

            float step = speed * Time.deltaTime;

            StepForwardnBack(step);

        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {

            float step = speed * Time.deltaTime;

            StepForwardnBack(-step);

        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {

            float step = speed * Time.deltaTime;

            StepSides(step);

        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {

            float step = speed * Time.deltaTime;
            StepSides(-step);


        }

    }

    private void StepSides(float step)
    {
        transform.position = Vector3.MoveTowards(transform.position, target2.position, step);
    }

    private void StepForwardnBack(float step)
    {
        transform.position = Vector3.MoveTowards(transform.position, target.position, step);
    }


}
