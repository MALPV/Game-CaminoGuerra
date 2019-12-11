using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class color : MonoBehaviour {

    //Forma uno de cambiar el color
    //public float r, g, b;
    public Color colorCubo;

	// Use this for initialization
	void Start () {
        //Forma 1 GetComponent<Renderer>().material.color = new Color(r, g, b);
        GetComponent<Renderer>().material.color = colorCubo;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
