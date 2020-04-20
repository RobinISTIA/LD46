using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Niveau2Script : MonoBehaviour
{
    public float tmpRestant;

    private Text txt;
    private float tmp = 0.0f;

    GameObject vict;
    GameObject boule1;
    GameObject vir1;

    void Start()
    {
        vict = GameObject.FindWithTag("Victory");
        if(vict == null)
        {
            Debug.Log("victoire non trouvé !");
        }
        boule1 = GameObject.FindWithTag("Boule1");
        if (boule1 == null)
        {
            Debug.Log("BDF non trouvé !");
        }
        vir1 = GameObject.FindWithTag("Vir1");
        if (vir1 == null)
        {
            Debug.Log("virus non trouvé !");
        }
        boule1.SetActive(false);
        vir1.SetActive(false);
        vict.SetActive(false);
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
            vict.SetActive(true);
            Time.timeScale = 0f;
            tmpRestant = 0;
        }

        if(tmpRestant == 11)
        {
            boule1.SetActive(true);
        }

        if(tmpRestant == 6)
        {
            vir1.SetActive(true);
        }

        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y);

            RaycastHit2D hit = Physics2D.Raycast(mousePos2D, Vector2.zero);

            if (hit.collider != null)
            {
                if (hit.collider.gameObject.name == vict.gameObject.name)
                {
                    SceneManager.LoadScene("Niveau3");
                }
            }
        }
    }
}
