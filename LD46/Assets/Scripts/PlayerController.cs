using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public string inputFront;
    public string inputBack;
    public string inputLeft;
    public string inputRight;

    public string etat = "haut";
    public float speed;

    public Quaternion q = new Quaternion(0, 0, 0, 0);

    private GameObject gameOver;

    SpriteRenderer sp;

    void Start()
    {
        sp = GetComponent<SpriteRenderer>();
        //gameOver = GameObject.FindWithTag("Finish");
        //gameOver.SetActive(false);
    }

    void Update()
    {
        sp.flipY = true;
        if(Input.GetKey(inputFront))
        {
            sp.flipY = !sp.flipY;
            transform.Translate(-speed * Time.deltaTime, 0, 0);
            transform.SetPositionAndRotation(new Vector3(transform.position.x, transform.position.y), Quaternion.Euler(new Vector3(transform.rotation.x, transform.rotation.y, -90f)));

        }

        if (Input.GetKey(inputBack))
        {
            transform.Translate(-speed * Time.deltaTime, 0, 0);
            transform.SetPositionAndRotation(new Vector3(transform.position.x, transform.position.y), Quaternion.Euler(new Vector3(transform.rotation.x, transform.rotation.y, 90f)));
        }

        if (Input.GetKey(inputLeft))
        {
            transform.Translate(-speed * Time.deltaTime, 0, 0);
            transform.SetPositionAndRotation(new Vector3(transform.position.x, transform.position.y), Quaternion.Euler(new Vector3(transform.rotation.x, transform.rotation.y, 0f)));
        }

        if (Input.GetKey(inputRight))
        {
            transform.Translate(-speed * Time.deltaTime, 0, 0);
            transform.SetPositionAndRotation(new Vector3(transform.position.x, transform.position.y), Quaternion.Euler(new Vector3(transform.rotation.x, transform.rotation.y, 180f)));
        }

        /*if (gameOver == null)
        {
            Debug.Log("L'objet game over n'a pas été trouvé");
        }
        else
        {
            gameOver.SetActive(true);
        }*/
    }
}
