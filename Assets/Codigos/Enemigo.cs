using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo : MonoBehaviour
{
    //public string clonBala; //VIDEO MOISES 18
    //float SpeedEnemigo = 0.6f;//VIDEO MOISES 19
    GameObject player;


    Vector3 posicionOriginal;

    float distanciaAtaque = 5.0f;
    float velocidadAtaque = 0.6f; //LO HE AÑADIDO == VIDEO 19
    GameObject gestorSonido;



    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player"); //encuentra el personaje con el TAG PLAYER
        posicionOriginal = transform.position; //

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 Objetivo = posicionOriginal;//MOISES 19
        
        float distancia = Vector3.Distance(player.transform.position, transform.position); //distancia = fantasma .x - personaje .x
        Debug.Log(distancia); //calcular/comprobar la distancia

        float velocidadEnemigo = velocidadAtaque * Time.deltaTime;

        if(distancia >= distanciaAtaque){
            transform.position = Vector3.MoveTowards(transform.position, posicionOriginal, velocidadEnemigo);
        
        }else if(distancia <= distanciaAtaque){
            transform.position = Vector3.MoveTowards(transform.position, player.transform.position, velocidadEnemigo);
        }
       
    }

    void OnTriggerEnter2D(Collider2D otro){
            //Debug.Log(Collider2D.gameObject.name); //que la bala colisione con el Enemigo
            //Debug.Log("otro");

            //clonBala = otro.gameObject.name;

            if(otro.gameObject.name == "bala(Clone)"){  //me destruye con la bala
                principalScript.enemigos++;
                Destroy(this.gameObject, 0.3f);
            }

            if(otro.gameObject.name == "Personaje)"){
                //Debug.Log("Has muerto!");
                principalScript.vidas -=1; //MOISÉS --;
                //principalScript.vidas--; //VIDEO 18 MOISÉS
                player.transform.position = new Vector3(-1.3f,3.4f,0);
            
                gestorSonido.GetComponent<audioManager>().sonidoDead();
            }
    }

    

}
