using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BouleDeFeuScript : MonoBehaviour
{
    public float speed = 1;
    public float interval;
    public int mode;

    private GameObject player;
    private float xplayer;
    private float yplayer;

    void Start()
    {
        player = GameObject.FindWithTag("Player");
        if(player == null)
        {
            Debug.Log("Le Player n'a pas été trouvé !");
        }
    }


    void Update()
    {
        xplayer = player.GetComponent<Transform>().position.x;
        yplayer = player.GetComponent<Transform>().position.y;

        if(transform.position.x > xplayer)
        {
            transform.Translate(-speed * Time.deltaTime, 0, 0);
        }
        else
        {
            transform.Translate(speed * Time.deltaTime, 0, 0);
        }
        if(transform.position.y > yplayer)
        {
            transform.Translate(0, -speed * Time.deltaTime, 0);
        }
        else
        {
            transform.Translate(0, speed * Time.deltaTime, 0);
        }

        //Debug.Log("La position du joueur est " + xplayer + ", " + yplayer);
    }
}
