using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Niveau4Script : MonoBehaviour
{
    public float tmpRestant;

    private Text txt;
    private float tmp = 0.0f;


    GameObject boule1;
    GameObject boule2;
    GameObject boule3;
    GameObject boule4;
    GameObject vir1;
    GameObject vir2;

    void Start()
    {
        boule1 = GameObject.FindWithTag("Boule1");
        if (boule1 == null)
        {
            Debug.Log("BDF1 non trouvé !");
        }
        boule2 = GameObject.FindWithTag("Boule2");
        if (boule2 == null)
        {
            Debug.Log("Boule 2 non trouvé");
        }
        boule3 = GameObject.FindWithTag("Boule3");
        if (boule3 == null)
        {
            Debug.Log("BDF1 non trouvé !");
        }
        boule4 = GameObject.FindWithTag("Boule4");
        if (boule4 == null)
        {
            Debug.Log("Boule 2 non trouvé");
        }
        vir1 = GameObject.FindWithTag("Vir1");
        if (vir1 == null)
        {
            Debug.Log("virus non trouvé !");
        }
        vir2 = GameObject.FindWithTag("Vir2");
        if (vir2 == null)
        {
            Debug.Log("virus non trouvé !");
        }
        boule1.SetActive(false);
        boule2.SetActive(false);
        boule3.SetActive(false);
        boule4.SetActive(false);

        vir1.SetActive(false);
        vir2.SetActive(false);
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
            SceneManager.LoadScene("Transition4");
            tmpRestant = 0;
        }

        if (tmpRestant == 21)
        {
            boule1.SetActive(true);
        }

        if (tmpRestant == 19)
        {
            vir1.SetActive(true);
        }

        if (tmpRestant == 14)
        {
            vir2.SetActive(true);
        }

        if (tmpRestant == 12)
        {
            boule2.SetActive(true);
        }

        if( tmpRestant == 8)
        {
            boule3.SetActive(true);
            boule4.SetActive(true);
        }

        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y);

            RaycastHit2D hit = Physics2D.Raycast(mousePos2D, Vector2.zero);

        }

    }
}
