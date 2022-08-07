using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Credits : MonoBehaviour
{
    public void OnMouseDown()
    {
        SceneManager.LoadScene(2);
        Debug.Log("Button Clicked");
    }
}
