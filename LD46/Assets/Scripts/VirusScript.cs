using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VirusScript : MonoBehaviour
{
    public float speed = 1;
    public float interval;
    public int nbVie;

    private bool accroche;
    private float xplayer;
    private float yplayer;
    private float xdistance;
    private float ydistance;
    private float tmp = 0.0f;
    private string nomVirus;
    GameObject player;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            accroche = true;
            player.GetComponent<PlayerController>().speed = 0;
        }
    }

    void Start()
    {
        tmp = 0.0f;
        accroche = false;
        player = GameObject.FindWithTag("Player");
        nomVirus = gameObject.name;
        if(player == null)
        {
            Debug.Log("Player non trouvé !");
        }
    }


    void Update()
    {
        if (!accroche)
        {
            //On recherche le joueur
            tmp += Time.deltaTime;
            if (tmp >= interval)
            {
                xplayer = player.GetComponent<Transform>().position.x;
                yplayer = player.GetComponent<Transform>().position.y;
                tmp = 0;
            }

            if (transform.position.x > xplayer)
            {
                transform.Translate(-speed * Time.deltaTime, 0, 0);
            }
            else
            {
                transform.Translate(speed * Time.deltaTime, 0, 0);
            }
            if (transform.position.y > yplayer)
            {
                transform.Translate(0, -speed * Time.deltaTime, 0);
            }
            else
            {
                transform.Translate(0, speed * Time.deltaTime, 0);
            }
        }
        else
        {
            //On reste accroche au joueur
            xdistance = player.transform.position.x - transform.position.x;
            ydistance = player.transform.position.y - transform.position.y;
            transform.SetPositionAndRotation(new Vector3(xdistance + transform.position.x, ydistance + transform.position.y), Quaternion.Euler(new Vector3(transform.rotation.x, transform.rotation.y, transform.rotation.z)));
        }

        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y);

            RaycastHit2D hit = Physics2D.Raycast(mousePos2D, Vector2.zero);

            if (hit.collider != null)
            {
                if (hit.collider.gameObject.name == nomVirus)
                {
                    nbVie -= 1;
                }
            }
        }

        if (nbVie <= 0)
        {
            player.GetComponent<PlayerController>().speed = 3;
            gameObject.SetActive(false);
        }
    }
}
