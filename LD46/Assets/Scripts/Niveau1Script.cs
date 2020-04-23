using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Niveau1Script : MonoBehaviour
{
    public float tmpRestant;

    private Text txt;
    private float tmp = 0.0f;
    private int etat;

    //GameObject vict;
    GameObject tuto1;
    GameObject tuto2;
    GameObject tuto3;

    void Start()
    {
        //vict = GameObject.FindWithTag("Victory");
        //tuto1 = GameObject.FindWithTag("Tuto1");
        //tuto2 = GameObject.FindWithTag("Tuto2");
        //tuto3 = GameObject.FindWithTag("Tuto3");
        //vict.SetActive(false);
        //Time.timeScale = 0.0f;
        etat = 1;
        //tuto1.SetActive(false);
        //tuto2.SetActive(false);
        //tuto3.SetActive(false);
        txt = GetComponent<Text>();
    }

    void Update()
    {
        tmp += Time.deltaTime;
        if (tmp >= 1f)
        {
            tmpRestant -= 1f;
            tmp = 0f;
        }

        if (tmpRestant <= 0)
        {
            SceneManager.LoadScene("Transition1");
            //vict.SetActive(true);
            //Time.timeScale = 0f;
            tmpRestant = 0;
        }

        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y);

            RaycastHit2D hit = Physics2D.Raycast(mousePos2D, Vector2.zero);

            if (hit.collider != null)
            {

                /*if (hit.collider.gameObject.name == vict.gameObject.name)
                {
                    Time.timeScale = 1.0f;
                    SceneManager.LoadScene("Niveau2");
                }*/
                /*
                if(etat == 1)
                {
                    if (hit.collider.gameObject.name == tuto1.gameObject.name)
                    {
                        tuto1.SetActive(false);
                        tuto2.SetActive(true);
                        tuto3.SetActive(false);
                        etat = 2;
                    }
                }
                if(etat == 2)
                {
                    if (hit.collider.gameObject.name == tuto2.gameObject.name)
                    {
                        tuto1.SetActive(false);
                        tuto2.SetActive(false);
                        tuto3.SetActive(true);
                        etat = 3;
                    }
                }
                if(etat == 3)
                {
                    if (hit.collider.gameObject.name == tuto3.gameObject.name)
                    {
                        tuto1.SetActive(false);
                        tuto2.SetActive(false);
                        tuto3.SetActive(false);
                        Time.timeScale = 1.0f;
                        etat = 4;
                    }
                }

                if (etat == 1)
                {
                    if (hit.collider.gameObject.name == tuto1.gameObject.name)
                    {
                        tuto1.SetActive(false);
                        tuto2.SetActive(true);
                        tuto3.SetActive(false);
                        etat = 2;
                    }
                }
                if (etat == 2)
                {
                    if (hit.collider.gameObject.name == tuto2.gameObject.name)
                    {
                        tuto1.SetActive(false);
                        tuto2.SetActive(false);
                        tuto3.SetActive(true);
                        etat = 3;
                    }
                }
                if (etat == 3)
                {
                    if (hit.collider.gameObject.name == tuto3.gameObject.name)
                    {
                        tuto1.SetActive(false);
                        tuto2.SetActive(false);
                        tuto3.SetActive(false);
                        Time.timeScale = 1.0f;
                        etat = 4;
                    }
                }*/
            }
        }
    }
}
