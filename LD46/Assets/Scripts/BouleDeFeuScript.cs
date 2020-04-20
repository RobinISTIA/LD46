using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BouleDeFeuScript : MonoBehaviour
{
    public float speed = 1;
    public float interval;
    public int mode;
    public int nbVie;

    private GameObject player;
    private float xplayer;
    private float yplayer;
    private float tmp = 0.0f;
    private string nomBDF;

    void Start()
    {
        player = GameObject.FindWithTag("Player");
        if(player == null)
        {
            Debug.Log("Le Player n'a pas été trouvé !");
        }
        nomBDF =  gameObject.name;
    }


    void Update()
    {
        tmp += Time.deltaTime;
        if(tmp >= interval)
        {
            xplayer = player.GetComponent<Transform>().position.x;
            yplayer = player.GetComponent<Transform>().position.y;
            tmp = 0;
        }

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

        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y);

            RaycastHit2D hit = Physics2D.Raycast(mousePos2D, Vector2.zero);

            if(hit.collider != null)
            {
                if(hit.collider.gameObject.name == nomBDF)
                {
                    nbVie -= 1;
                }
            }
        }

        if(nbVie <= 0)
        {
            gameObject.SetActive(false);
        }
    }
}
