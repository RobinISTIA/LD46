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

    GameObject vict;

    void Start()
    {
        vict = GameObject.FindWithTag("Victory");
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

        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y);

            RaycastHit2D hit = Physics2D.Raycast(mousePos2D, Vector2.zero);

            if (hit.collider != null)
            {
                if (hit.collider.gameObject.name == vict.gameObject.name)
                {
                    Time.timeScale = 1.0f;
                    SceneManager.LoadScene("Niveau2");
                }
            }
        }
    }
}
