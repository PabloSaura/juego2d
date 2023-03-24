using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{

    public float velocidad =1;
    public float salto = 3f;

    bool saltando = false;

    Rigidbody2D miCuerpoRigido;



    Animator controlAnimacion; 

    public static bool direccionBala = false;


    // Start is called before the first frame update
    void Start(){
        miCuerpoRigido = GetComponent<Rigidbody2D>();


        controlAnimacion = GetComponent<Animator>();
        controlAnimacion = GetComponent<Animator>(); 


    }

    // Update is called once per frame
    void Update()
    {

            //si no hay vidas no se ejecuta
            if(principalScript.vidas <= 0){
                return;



            }






        //obtengo el valor de las teclas A-D (1-1)
        float movTeclas = Input.GetAxis("Horizontal")*velocidad;

        //convierto a metros por segundo
        movTeclas *= Time.deltaTime;
        transform.Translate(movTeclas,0,0);

        //movTeclas = Time.deltaTime;


        //Debug.Log(movTeclas);


        //si,la tecla apretada es A, el personaje en su escala

        //izquierda
        if(
            Input.GetKeyDown(KeyCode.A)
            ||
            Input.GetKeyDown(KeyCode.LeftArrow)){

                transform.localScale = new Vector3(-1,1,1);
                controlAnimacion.SetBool("activaCamina",true);
                direccionBala = true;
        }
        
        //derecha
        if(
            Input.GetKeyDown(KeyCode.D) || Input.GetKeyUp(KeyCode.RightArrow)
        )
        {
                transform.localScale = new Vector3(1,1,1);
                controlAnimacion.SetBool("activaCamina",true);
                direccionBala = false;
        }
        


        if( Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.D) || Input.GetKeyUp(KeyCode.LeftArrow) || Input.GetKeyUp(KeyCode.RightArrow) ){

            controlAnimacion.SetBool("activaCamina",false);
        }


                    
        


        //Salto
    }
}