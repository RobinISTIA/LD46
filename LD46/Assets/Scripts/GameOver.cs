using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    public bool gameOver = false;

    private GameObject go;

    void Start()
    {
        go = GameObject.FindWithTag("Finish");
        go.SetActive(false);
    }


    void Update()
    {
        if(gameOver)
        {
            go.SetActive(true);
            Time.timeScale = 0f;
        }
    }
}
