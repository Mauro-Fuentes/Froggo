using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpammer : MonoBehaviour 
{

    public GameObject car;

    public float spawnTime = 3f;
    public float wave = 4f;
    
    void Awake()
    {
    }

    void Start()
    {
        InvokeRepeating("Spawn", spawnTime, wave);
    }

    void Spawn()
    {
        Instantiate(car, transform.position, Quaternion.Euler (0,0,0));

    }

}
