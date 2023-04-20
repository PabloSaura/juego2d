using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{

    public float Speed = 3.5f;

    public bool ActivaSalto = true;

    public float salto = 5f;

    Rigidbody2D miCuerpoRigido;

    Animator controlAnimacion; 

    public static bool direccionBala = false;

    public static bool ParardireccionBala = false;  //VIDEO 17 DE MOISES


void Awake(){
        DontDestroyOnLoad(gameObject); /// 23
    }

    // Start is called before the first frame update
    void Start(){
        miCuerpoRigido = GetComponent<Rigidbody2D>();

        controlAnimacion = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

        //si no hay vidas no se ejecuta
        //    return;
    if(principalScript.vidas > 0){
        


        //obtengo el valor de las teclas A-D (1-1)

        //GETAXIS
        float H = Input.GetAxis("Horizontal")*Speed;
        H *= Time.deltaTime; //convierto a metros por segundo
        transform.Translate (H,0,0);

        //movTeclas = Time.deltaTime;

        //Debug.Log(movTeclas);

        //si,la tecla apretada es A, el personaje en su escala

        //INPUTS CONTROL NO PREDEFINIDOS
        if(Input.GetKey(KeyCode.Space) && ActivaSalto == true) {
            GetComponent<Rigidbody2D> ().AddForce (new Vector2(0,3f),ForceMode2D.Impulse); //Salto
            ActivaSalto = false;
        }

        //izquierda
        if(
            Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow) ) {

                transform.localScale = new Vector3(-1,1,1);
                controlAnimacion.SetBool("activaCamina",true);
                direccionBala = false;
                ParardireccionBala = true;
                Parallax.direccionPersonaje = "izquierda";
        }
        //derecha
        if(
            Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow)
        )
        {
                transform.localScale = new Vector3(1,1,1);
                controlAnimacion.SetBool("activaCamina",true);
                direccionBala = true;
                ParardireccionBala = true;
                Parallax.direccionPersonaje = "derecha";
        }
        

        //parado
        if(Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.LeftArrow)) {

            controlAnimacion.SetBool("activaCamina",false);
            ParardireccionBala = false;
            Parallax.direccionPersonaje = "parado";
        }

        if(Input.GetKeyUp(KeyCode.D) || Input.GetKeyUp(KeyCode.RightArrow)){
            controlAnimacion.SetBool("activaCamina",false);
            ParardireccionBala = true;
            Parallax.direccionPersonaje = "parado";
        }
    }
    }

    //FIN UPDATE
    void OnCollisionEnter2D (Collision2D otro){
        ActivaSalto = true;
    }



}
