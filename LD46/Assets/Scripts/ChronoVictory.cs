using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChronoVictory : MonoBehaviour
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
    }
}
