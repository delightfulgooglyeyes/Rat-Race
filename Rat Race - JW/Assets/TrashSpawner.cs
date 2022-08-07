using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashSpawner : MonoBehaviour
{
    public GameObject Cheese;
    public float spawnDelay = 1f;
    public float spawnTime = 2.5f;

    public int numberToSpawn;
    public List<GameObject> spawnPool;
    public GameObject quad;

    public CheesePoints score;

    void Start()
    {
        InvokeRepeating("spawnObjects", spawnDelay, spawnTime);
        Vector3 position = new Vector3(5.0f, 0, 0); 
        Cheese.transform.position += position;
        Vector3 position1 = new Vector3(0, 1, 0);
        Cheese.transform.position += position1;
    }
    void Update()
    {
        if (score.pointsCounter == 20)
        {
            spawnTime = 1;
            spawnDelay = 2;
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
  //  private void destroyObjects()
   // {
    //    foreach (GameObject o in GameObject.FindGameObjectsWithTag("Spawnable"))
    //    {
    //        Destroy(o);
     //   }
   // }


}

