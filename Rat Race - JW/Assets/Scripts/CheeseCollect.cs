using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheeseCollect : MonoBehaviour
{
    public AudioSource boop;
    void OnCollisionEnter2D(Collision2D collision)
    {
        // When target is hit
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("Target was Hit!");
            Destroy(gameObject);
            boop.Play();
        }
    }
}
