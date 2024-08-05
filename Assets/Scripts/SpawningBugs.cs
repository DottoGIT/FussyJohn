using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawningBugs : MonoBehaviour
{
    public float timeTick;
    public Vector2 spawnWidth;
    public static float FrequencyInSec;
    public static bool doSpawn = false;
    public float spawnY;

    public GameObject Ant;
    public GameObject Fly;
    public GameObject Worm;
    

    void Update()
    {
        if (doSpawn)
            timeTick += Time.deltaTime;
        else timeTick = FrequencyInSec - 2f;

        if(timeTick >= FrequencyInSec)
        {
            SpawnBug();
            timeTick = 0;
        }
        
    }

    void SpawnBug()
    {
        int randBug;
        float randX;


        randX = Random.Range(spawnWidth.x, spawnWidth.y);
        randBug = Random.Range(1,4);
        switch (randBug)
        {
            case 1: Instantiate(Ant, new Vector3(randX , spawnY, 0), transform.rotation);
                break;

            case 2:
                Instantiate(Fly, new Vector3(randX, spawnY, 0), transform.rotation);
                break;

            case 3:
                Instantiate(Worm, new Vector3(randX, spawnY, 0), transform.rotation);
                break;
        }
        
    }
}
