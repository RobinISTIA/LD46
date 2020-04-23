using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    /*public string inputFront;
    public string inputBack;
    public string inputLeft;
    public string inputRight;*/

    public string etat = "haut";
    public float speed;

    public bool inactif;

    public Animator anim;

    SpriteRenderer sp;

    void Start()
    {
        sp = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
        inactif = false;
        

    }

    void Update()
    {
        if( !Input.GetKey(KeyCode.UpArrow) && !Input.GetKey(KeyCode.DownArrow) && !Input.GetKey(KeyCode.LeftArrow) && !Input.GetKey(KeyCode.RightArrow))
        {
            anim.SetBool("PasBouger", true );
            anim.SetBool("Bouger", false );
            inactif = true;
        }

        if(Input.GetKey(KeyCode.UpArrow))
        {
            anim.SetBool("Bouger", true );
            anim.SetBool("PasBouger", false );
            transform.Translate(-speed * Time.deltaTime, 0, 0);
            transform.SetPositionAndRotation(new Vector3(transform.position.x, transform.position.y), Quaternion.Euler(new Vector3(transform.rotation.x, transform.rotation.y, -90f)));
            inactif = false;
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            anim.SetBool("Bouger", true);
            anim.SetBool("PasBouger", false);
            transform.Translate(-speed * Time.deltaTime, 0, 0);
            transform.SetPositionAndRotation(new Vector3(transform.position.x, transform.position.y), Quaternion.Euler(new Vector3(transform.rotation.x, transform.rotation.y, 90f)));
            inactif = false;
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            anim.SetBool("Bouger", true);
            anim.SetBool("PasBouger", false);
            transform.Translate(-speed * Time.deltaTime, 0, 0);
            transform.SetPositionAndRotation(new Vector3(transform.position.x, transform.position.y), Quaternion.Euler(new Vector3(transform.rotation.x, transform.rotation.y, 0f)));
            inactif = false;
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            anim.SetBool("Bouger", true);
            anim.SetBool("PasBouger", false);
            transform.Translate(-speed * Time.deltaTime, 0, 0);
            transform.SetPositionAndRotation(new Vector3(transform.position.x, transform.position.y), Quaternion.Euler(new Vector3(transform.rotation.x, transform.rotation.y, 180f)));
            inactif = false;
        }

    }
}
