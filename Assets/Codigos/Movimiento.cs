using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{

    public float velocidad =1;
    public float salto = 3f;

    bool saltando = false;

    RugidBody2D miCuerpoRigido;



    Animator controlAnimacion; 


    // Start is called before the first frame update
    void Start(){
        miCuerpoRigido = GetComponent<RugidBody2D>();


        controlAnimacion = GetComponent<Animator>;
        controlAnimacion = GetComponent<Animator>; 

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
        if(
            Input.GetKeyDown(KeyCode.A)
            ||
            Input.GetKeyDown(KeyCode.LeftArrow)){

                transform.localScale = new Vector3(-1,1,1);
                controlAnimacion.SetBool("activaCamina",true);
        }
        
        if(Input.GetKeyDown(KeyCode.D)){
                ||Input.GetKeyUp(KeyCode.RightArrow)

                transform.localScale = new Vector3(1,1,1);
                controlAnimacion.SetBool("activaCamina",true);
        }

        if (Input.GetKeyUp(KeyCode.A)){
            controlAnimacion.SetBool("activaCamina",true);
        }

        if(Input.GetKeyDown(KeyCode.D)){
                    ||Input.GetKeyUp(KeyCode.D)
                    ||Input.GetKeyUp(KeyCode.LeftArrow)
                    ||Input.GetKeyUp(KeyCode.RightArrow)


                    controlAnimacion.SetBool("activaCamina",false);
        }


        //Salto
    }
}