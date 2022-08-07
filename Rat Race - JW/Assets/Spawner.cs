using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject Cheese;
    public float spawnDelay = 1f;
    public float spawnTime = 1.5f;

    public int numberToSpawn;
    public List<GameObject> spawnPool;
    public GameObject quad;

    public CheesePoints score;

    void Start()
    {
        InvokeRepeating("spawnObjects", spawnDelay, spawnTime);
    }
    void Update()
    {
        if (score.pointsCounter == 20)
        {
            spawnTime = 1;
            spawnDelay = 1;
        }
    }
    public void spawnObjects()
    {
        //destroyObjects();
        int randomItem = 0;
        GameObject toSpawn;
        MeshCollider c = quad.GetComponent<MeshCollider>();

        float screenX, screenY;
        Vector2 pos;

        for (int i = 0; i < numberToSpawn; i++)
        {
            randomItem = Random.Range(0, spawnPool.Count);
            toSpawn = spawnPool[randomItem];

            screenX = Random.Range(c.bounds.min.x, c.bounds.max.x);
            screenY = Random.Range(c.bounds.min.y, c.bounds.max.y);
            pos = new Vector2(screenX, screenY);

            Instantiate(toSpawn, pos, toSpawn.transform.rotation);

        }
    }
}

