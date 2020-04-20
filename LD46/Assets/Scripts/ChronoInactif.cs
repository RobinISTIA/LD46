using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChronoInactif : MonoBehaviour
{
    public bool IsInactif;
    public float tmpRestant;

    GameObject go;
    GameObject player;

    private Text txt;
    private float tmp = 0.0f;

    void Start()
    {
        tmpRestant = 5;
        txt = GetComponent<Text>();
        go = GameObject.FindWithTag("Finish");
        player = GameObject.FindWithTag("Player");
    }

    void Update()
    {
        if (!player.GetComponent<PlayerController>().inactif)
        {
            tmpRestant = 5f;
            txt.text = tmpRestant.ToString();
        }
        else
        {
            tmp += Time.deltaTime;
            if( tmp >= 1f)
            {
                tmpRestant -= 1;
                tmp = 0f;
            }
        
            txt.text = tmpRestant.ToString();

            if(tmpRestant <= 0)
            {
                go.SetActive(true);
                tmpRestant = 0;
            }
        }
    }
}
