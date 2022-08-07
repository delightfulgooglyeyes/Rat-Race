using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopingBackground : MonoBehaviour
{
    public float backgroundSpeed;
    public Renderer backgroundRenderer;
    public CheesePoints score;
    [Header("Costume Selection")]
    public GameObject fancy;
    public GameObject hat;

    void Start()
    {
        Time.timeScale = 0;
    }
    void Update()
    {
        if (Input.GetKey("h"))
        {
            hat.SetActive(true);
            Destroy(fancy);
            backgroundRenderer.material.mainTextureOffset += new Vector2(backgroundSpeed * Time.deltaTime, 0f);
            Time.timeScale = 1;
        }
        if (Input.GetKey("m"))
        {
            fancy.SetActive(true);
            Destroy(hat);
            backgroundRenderer.material.mainTextureOffset += new Vector2(backgroundSpeed * Time.deltaTime, 0f);
            Time.timeScale = 1;
        }
        if (Input.GetKey("n"))
        {
            backgroundRenderer.material.mainTextureOffset += new Vector2(backgroundSpeed * Time.deltaTime, 0f);
            Time.timeScale = 1;
            Destroy(hat);
            Destroy(fancy);
        }

    }

}