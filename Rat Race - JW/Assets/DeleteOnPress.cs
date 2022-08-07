using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DeleteOnPress : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("m"))
        {
            Destroy(gameObject);
        }
        if (Input.GetKey("h"))
        {
            Destroy(gameObject);
        }
        if (Input.GetKey("n"))
        {
            Destroy(gameObject);
        }
    }
}
