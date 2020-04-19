using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    public bool gameOver = false;

    void Start()
    {
        
    }


    void Update()
    {
        if(gameOver)
        {
            gameObject.SetActive(true);
        }
    }
}
