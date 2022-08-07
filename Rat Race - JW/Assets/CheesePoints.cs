using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CheesePoints : MonoBehaviour
{
    public int pointsCounter;
    public Text CheeseCounter;
    public GameObject Cheese;


    void Start()
    {
        Cheese.SetActive(true);
       // InvokeRepeating(ChooseNumber, 3);
    }

    void Update()
    {
        
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Spawnable")
        {
            // Destroy(GameObject.FindWithTag("Spawnable"));
            Cheese.SetActive(false);
            pointsCounter += 1;
            CheeseCounter.text = pointsCounter.ToString();
           // IEnumerator Reset()
           // {
             //   yield return new WaitForSeconds(1);
           // }
            Cheese.SetActive(true);
        }
        if (collision.gameObject.tag == "Trash")
        {
            //  Destroy(GameObject.FindWithTag("Trash"));
            SceneManager.LoadScene(4);
        }
    }
    public void ChooseNumber()
    {
        float randomNumber = Random.Range(1, 5);
        Debug.Log(randomNumber);
    }


}
