using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner30 : MonoBehaviour
{
    public GameObject Object;
    public float spawnDelay = 1f;
    public float spawnTime = 2.5f;

    public int numberToSpawn;
    public List<GameObject> spawnPool;
    public GameObject quad;

    public CheesePoints score;

    void Start()
    {
        if (score.pointsCounter == 10)
        {
            InvokeRepeating("spawnObjects", spawnDelay, spawnTime);
            Vector3 position = new Vector3(5.0f, 0, 0);
            Object.transform.position += position;
            Vector3 position1 = new Vector3(0, 1, 0);
            Object.transform.position += position1;
        }

    }
    void Update()
    {

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
