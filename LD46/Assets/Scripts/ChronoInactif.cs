using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChronoInactif : MonoBehaviour
{
    public bool IsInactif;
    public float tmpRestant;

    //GameObject go;
    GameObject player;
    GameObject camera;

    private Text txt;
    private float tmp = 0.0f;

    void Start()
    {
        tmpRestant = 3;
        txt = GetComponent<Text>();
        //go = GameObject.FindWithTag("Finish");
        camera = GameObject.FindWithTag("MainCamera");
        player = GameObject.FindWithTag("Player");
        if(camera == null)
        {
            Debug.Log("Objet Camera non trouvé dans Chrono inactif !");
        }
    }

    void Update()
    {
        if (!player.GetComponent<PlayerController>().inactif)
        {
            tmpRestant = 3f;
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
                camera.GetComponent<GameOver>().gameOver = true;
                //go.SetActive(true);
                tmpRestant = 0;
            }
        }
    }
}
