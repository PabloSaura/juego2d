using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bala : MonoBehaviour
{

    public float velocidad = 3.0f;
    

    // Start is called before the first frame update
    void Start()
    {
        //Destroy(this.gameObject, 0.5f); //SI QUITO/COMENTO ESTO ME DA MENOS ERRORES
    
        //derecha
        if(Movimiento.direccionBala == false){
            velocidad = velocidad*-1;
        }else{
           velocidad = velocidad; /// PROBLEMA!!!
        }
    }
    
    // Update is called once per frame
    void Update()
    {

        //VIDEO 16 DE MOISÉS LO TIENE ASI:

        //if(Movimiento.direccionBala == true && movimiento.ParardireccionBala == false){
            //transform.Translate (new Vector2(Time.deltaTime*7.0));
        //}
        //if(Movimiento.direccionBala == false && movimiento.ParardireccionBala == false){
            //transform.Translate (new Vector2(-Time.deltaTime*7.0));
        //}



        transform.Translate(velocidad*Time.deltaTime,0,0);
        //transform.Translate(new Vector2(Time.deltaTime*7.0));  // En el video de Moisés aparece así

        if(transform.position.x >= 100 || transform.position.x <= -100){
            Destroy(this.gameObject, 0.5f);  // Moisés lo pone arruba en el void start
        }

    }



}
