using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Controls : MonoBehaviour
{
    public void OnMouseDown()
    {
        SceneManager.LoadScene(1);
        Debug.Log("Button Clicked");

    }
}
