using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{

    public float velocidad =1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //obtengo el valor de las teclas A-D (1-1)
        float movTeclas = Input.GetAxis("Horizontal")*velocidad;

        //convierto a metros por segundo
        movTeclas *= Time.deltaTime;
        transform.Translate(movTeclas,0,0);

        //movTeclas = Time.deltaTime;


        //Debug.Log(movTeclas);


        //si,la tecla apretada es A, el personaje en su escala
        if(Input.GetKeyDown(KeyCode.A)){
                    transform.localScale = new Vector3(-1,1,1);
         }
        
        if(Input.GetKeyDown(KeyCode.D)){
                    transform.localScale = new Vector3(1,1,1);
        }
    //un simple coment
    }
}