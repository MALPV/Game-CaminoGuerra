using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour {


    public float deltaRotacion = 100f;
    public float deltaMovimiento = 10f;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Rotar();
        Movimiento();
    }

    void Rotar()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
            transform.Rotate(new Vector3(0f, -deltaRotacion, 0f) * Time.deltaTime);
        else if (Input.GetKey(KeyCode.RightArrow))
            transform.Rotate(new Vector3(0f, deltaRotacion, 0f) * Time.deltaTime);
    }

    void Movimiento()
    {
        if (Input.GetKey(KeyCode.UpArrow))
            transform.Translate(Vector3.back * deltaMovimiento * Time.deltaTime);
        else if (Input.GetKey(KeyCode.DownArrow))
            transform.Translate(Vector3.forward * deltaMovimiento * Time.deltaTime);
    }
}
   