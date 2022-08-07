using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class Movement : MonoBehaviour
{
    public float playerSpeed;
    private Rigidbody2D rb;
    private Vector2 playerDirection;
    public GameObject Rat;
    public CheesePoints score;
    [Header("Costume Selection")]
    public GameObject fancy;
    public GameObject hat;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        fancy.SetActive(false);
        hat.SetActive(false);
    }

    void Update()
    {
        float directionY = Input.GetAxisRaw("Vertical");
        playerDirection = new Vector2(0, directionY).normalized;
        if (Input.GetKey("m"))
        {
            fancy.SetActive(true);
        }
        if (Input.GetKey("h"))
        {
            hat.SetActive(true);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {

    }
        void FixedUpdate()
    {
        rb.velocity = new Vector2(0, playerDirection.y * playerSpeed);
    }
}
