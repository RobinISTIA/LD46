using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public string inputFront;
    public string inputBack;
    public string inputLeft;
    public string inputRight;

    public float speed;

    void Start()
    {
        
    }

    void Update()
    {
        if(Input.GetKey(inputFront))
        {
            transform.Translate(0, speed * Time.deltaTime, 0);
        }

        if (Input.GetKey(inputBack))
        {
            transform.Translate(0, -speed * Time.deltaTime, 0);
        }

        if (Input.GetKey(inputLeft))
        {
            transform.Translate(-speed * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey(inputRight))
        {
            transform.Translate(speed * Time.deltaTime, 0, 0);
        }
    }
}
