using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleKill : MonoBehaviour
{
    void onCollisionEnter2D(Collision2D col)
    {
        // When target is hit
        if (col.gameObject.tag == "Player")
        {
            Debug.Log("Target was Hit!");
        }
    }

}
