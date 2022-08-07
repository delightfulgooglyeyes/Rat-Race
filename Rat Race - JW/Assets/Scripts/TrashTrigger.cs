using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TrashTrigger : MonoBehaviour
{
    public bool isTouchingRat;
    public GameObject trash;
    void OnTriggerEnter(Collider trash)
    {
        //checkpointTracker.numberOfCheckpoints
        if (trash.gameObject.tag == "Player")
        {
            if (isTouchingRat == true)
            {
                SceneManager.LoadScene(3);
            }
        }
    }
        void OnCollisionEnter2D(Collision2D trash)
        {
            if (trash.gameObject.tag == "Player")
            {
                isTouchingRat = true;
            }
        }
}
