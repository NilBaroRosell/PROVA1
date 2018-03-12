using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moviment : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.A)) // ir a la izquierda
        {
            GetComponent<Rigidbody2D>().AddForce(new Vector2(-40, 0));
        }

        if (Input.GetKey(KeyCode.D)) // ir a la derecha
        {
            GetComponent<Rigidbody2D>().AddForce(new Vector2(40, 0));
        }

        if (Input.GetKeyDown(KeyCode.W)) // saltar
        {
            GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 1500));
        }

        if (Input.GetKey(KeyCode.LeftArrow)) // disparar izquierda
        {

        }

        if (Input.GetKey(KeyCode.RightArrow)) // disparar derecha
        {

        }
    }
}
