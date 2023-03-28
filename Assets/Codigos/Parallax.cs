using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{

    public GameObject Personaje;

    public GameObject fondoNubes;

    public GameObject fondoArboles;

    public GameObject arbolGrande;

    public static string direccionPersonaje;

    float velocidadNubes = 0.1f;
    float velocidadArboles = 0.8f;
    float velocidadArbolGrande = 1.2f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        Debug.Log(direccionPersonaje);

        if(direccionPersonaje == "derecha"){
        ///fondoNubes.transform.Translate(0.1f,0,0);
        velocidadNubes = -0.01f;
        velocidadArboles = -0.02f;
        velocidadArbolGrande = -0.04f;
    }

    if(direccionPersonaje == "izquierda"){
        ///fondoNubes.transform.Translate(-0.1f,0,0);
        velocidadNubes = 0.01f;
        velocidadArboles = 0.02f;
        velocidadArbolGrande = 0.04f;
    }
    if(direccionPersonaje == "parado"){
        ///fondoNubes.transform.Translate(-0.1f,0,0);
        velocidadNubes = 0f;
        velocidadArboles = 0f;
        velocidadArbolGrande = 0f;
    }
 
    //float velNubes = velocidadNube*Time.deltaTime
    //float velArboles 
    //float velArbolGrande 

    fondoNubes.transform.position = new Vector3(Personaje.transform.position.x/5f,Personaje.transform.position.y/5f,0);

    //fondoNubes.transform.Translate(velocidadNube,0,0);
    //fondoArboles.transform.Translate(velocidadArboles,0,0);
    //arbolGrande.transform.Translate(velocidadArbolGrande,0,0);
}
}
