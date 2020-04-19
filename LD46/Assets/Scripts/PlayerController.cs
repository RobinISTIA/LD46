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

    public Animator anim;

    private GameObject gameOver;

    SpriteRenderer sp;

    void Start()
    {
        sp = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
        //gameOver = GameObject.FindWithTag("Finish");
        //gameOver.SetActive(false);
    }

    void Update()
    {
        if( !Input.GetKey(inputFront) && !Input.GetKey(inputBack) && !Input.GetKey(inputLeft) && !Input.GetKey(inputRight))
        {
            anim.SetBool("PasBouger", true );
            anim.SetBool("Bouger", false );
            Debug.Log("On arrête de bouger !");
        }

        if(Input.GetKey(inputFront))
        {
            Debug.Log("On Bouge !");
            anim.SetBool("Bouger", true );
            anim.SetBool("PasBouger", false );
            transform.Translate(-speed * Time.deltaTime, 0, 0);
            transform.SetPositionAndRotation(new Vector3(transform.position.x, transform.position.y), Quaternion.Euler(new Vector3(transform.rotation.x, transform.rotation.y, -90f)));
        }

        if (Input.GetKey(inputBack))
        {
            anim.SetBool("Bouger", true);
            anim.SetBool("PasBouger", false);
            transform.Translate(-speed * Time.deltaTime, 0, 0);
            transform.SetPositionAndRotation(new Vector3(transform.position.x, transform.position.y), Quaternion.Euler(new Vector3(transform.rotation.x, transform.rotation.y, 90f)));
        }

        if (Input.GetKey(inputLeft))
        {
            anim.SetBool("Bouger", true);
            anim.SetBool("PasBouger", false);
            transform.Translate(-speed * Time.deltaTime, 0, 0);
            transform.SetPositionAndRotation(new Vector3(transform.position.x, transform.position.y), Quaternion.Euler(new Vector3(transform.rotation.x, transform.rotation.y, 0f)));
        }

        if (Input.GetKey(inputRight))
        {
            anim.SetBool("Bouger", true);
            anim.SetBool("PasBouger", false);
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
