using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockMustache : MonoBehaviour
{
    public Rigidbody2D rb;
    void Start()
    {
        rb.isKinematic = true;
    }
}
