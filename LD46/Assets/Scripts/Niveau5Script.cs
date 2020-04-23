using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Niveau5Script : MonoBehaviour
{
    public float tmpRestant;

    private Text txt;
    private float tmp = 0.0f;


    GameObject boule1;
    GameObject boule2;
    GameObject boule3;
    GameObject boule4;
    GameObject boule5;
    GameObject boule6;
    GameObject boule7;
    GameObject boule8;
    GameObject vir1;
    GameObject vir2;
    GameObject vir3;


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
        boule5 = GameObject.FindWithTag("Boule5");
        boule6 = GameObject.FindWithTag("Boule6");
        boule7 = GameObject.FindWithTag("Boule7");
        boule8 = GameObject.FindWithTag("Boule8");
        vir1 = GameObject.FindWithTag("Vir1");
        if (vir1 == null)
        {
            Debug.Log("virus1 non trouvé !");
        }
        vir2 = GameObject.FindWithTag("Vir2");
        if (vir2 == null)
        {
            Debug.Log("virus2 non trouvé !");
        }
        vir3 = GameObject.FindWithTag("Vir3");
        if (vir3 == null)
        {
            Debug.Log("virus3 non trouvé !");
        }
        boule1.SetActive(false);
        boule2.SetActive(false);
        boule3.SetActive(false);
        boule4.SetActive(false);
        boule5.SetActive(false);
        boule6.SetActive(false);
        boule7.SetActive(false);
        boule8.SetActive(false);

        //Debug.Log("Nom du virus1 : " + vir1.gameObject.name);
        vir1.SetActive(false);
        vir2.SetActive(false);
        vir3.SetActive(false);

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
            SceneManager.LoadScene("Final");
            tmpRestant = 0;
        }

        if (tmpRestant == 27)
        {
            boule1.SetActive(true);
        }

        if (tmpRestant == 24)
        {
            vir1.SetActive(true);
        }

        if (tmpRestant == 22)
        {
            boule4.SetActive(true);
        }

        if (tmpRestant == 18)
        {
            boule5.SetActive(true);
            boule8.SetActive(true);
        }

        if (tmpRestant == 15)
        {
            boule2.SetActive(true);
            boule6.SetActive(true);
        }

        if (tmpRestant == 8)
        {
            vir2.SetActive(true);
        }

        if (tmpRestant == 5)
        {
            vir3.SetActive(true);
        }

        if (tmpRestant == 5)
        {
            boule3.SetActive(true);
            boule7.SetActive(true);
        }

    }
}
