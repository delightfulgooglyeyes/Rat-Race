using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerupCollider : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        // When target is hit
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("Target was Hit!");
            Destroy(gameObject);
        }
    }
}
