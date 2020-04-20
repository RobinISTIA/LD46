using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleStaticMortel : MonoBehaviour
{
    private GameObject camera;

    void Start()
    {
        camera = GameObject.FindWithTag("MainCamera");
        if(camera == null)
        {
            Debug.Log("Camera non trouvé dans ObstacleStatic !");
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            camera.GetComponent<GameOver>().gameOver = true;
        }
    }
}
