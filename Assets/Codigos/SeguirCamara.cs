using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeguirCamara : MonoBehaviour
{

    public Transform Personaje;
    public float dondePersonajeX;
    public float dondePersonajeY;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //posicion de la camara = posiciom del personaje

        dondePersonajeX = Personaje.transform.position.x;
        dondePersonajeY = Personaje.transform.position.y;


        transform.position = new Vector3(dondePersonajeX,dondePersonajeY,-10);

    }
}
