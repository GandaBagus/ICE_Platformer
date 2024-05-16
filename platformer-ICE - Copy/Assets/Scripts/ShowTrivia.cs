using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowTrivia : MonoBehaviour
{
    public GameObject trivia;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "player")
        {
        trivia.SetActive(true);
        Time.timeScale = 0;
        }
        
    }

    public void CloseTrivia()
    {
        trivia.SetActive(false);
        Time.timeScale = 1;
    }

    // private void OnTriggerExit(Collider other) 
    // {
    //     if (other.tag == "player")
    //     {
    //     trivia.SetActive(false);
    //     }
    // }
}
