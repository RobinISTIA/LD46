using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleStaticMortel : MonoBehaviour
{
    private GameObject go;

    void Start()
    {
        go = GameObject.FindWithTag("Finish");
        go.SetActive(false);
    }

    
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("On rentre en collision et on provoque game over");
        go.SetActive(true);
        Time.timeScale = 0f;
    }
}
