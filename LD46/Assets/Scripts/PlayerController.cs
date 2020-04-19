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
        if( !Input.GetKey(inputFront) && !Input.GetKey(inputBack) && !Input.GetKey(inputLeft) && !Input.GetKey(inputRight))
        {
            anim.SetBool("PasBouger", true );
            anim.SetBool("Bouger", false );
            inactif = true;
        }

        if(Input.GetKey(inputFront))
        {
            anim.SetBool("Bouger", true );
            anim.SetBool("PasBouger", false );
            transform.Translate(-speed * Time.deltaTime, 0, 0);
            transform.SetPositionAndRotation(new Vector3(transform.position.x, transform.position.y), Quaternion.Euler(new Vector3(transform.rotation.x, transform.rotation.y, -90f)));
            inactif = false;
        }

        if (Input.GetKey(inputBack))
        {
            anim.SetBool("Bouger", true);
            anim.SetBool("PasBouger", false);
            transform.Translate(-speed * Time.deltaTime, 0, 0);
            transform.SetPositionAndRotation(new Vector3(transform.position.x, transform.position.y), Quaternion.Euler(new Vector3(transform.rotation.x, transform.rotation.y, 90f)));
            inactif = false;
        }

        if (Input.GetKey(inputLeft))
        {
            anim.SetBool("Bouger", true);
            anim.SetBool("PasBouger", false);
            transform.Translate(-speed * Time.deltaTime, 0, 0);
            transform.SetPositionAndRotation(new Vector3(transform.position.x, transform.position.y), Quaternion.Euler(new Vector3(transform.rotation.x, transform.rotation.y, 0f)));
            inactif = false;
        }

        if (Input.GetKey(inputRight))
        {
            anim.SetBool("Bouger", true);
            anim.SetBool("PasBouger", false);
            transform.Translate(-speed * Time.deltaTime, 0, 0);
            transform.SetPositionAndRotation(new Vector3(transform.position.x, transform.position.y), Quaternion.Euler(new Vector3(transform.rotation.x, transform.rotation.y, 180f)));
            inactif = false;
        }

    }
}
