using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo : MonoBehaviour
{

    GameObject player;

    Vector3 posicionOriginal;

    float distanciaAtaque = 5.0f;

    


    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player"); //encuentra el personaje con el TAG PLAYER
        posicionOriginal = transform.position;
    }

    // Update is called once per frame
    void Update()
    {

        



        //distancia = fantasma .x - personaje .x
        float distancia = Vector3.Distance(player.transform.position, transform.position);
        Debug.Log(distancia); //calcular/comprobar la distancia

        float velocidadEnemigo = velocidadAtaque * Time.deltaTime;

        if(distancia >= distanciaAtaque){
            transform.position = Vector3.MoveTowards(transform.position, posicionOriginal, velocidadEnemigo);
        
        }
            else if(distancia <= distanciaAtaque){
                transform.position = Vector3.MoveTowards(transform.position, player.transform.position, velocidadEnemigo);
            }



        void OnTriggerEnter2D(Collider2D otro){
        Debug.Log(Collider2D.gameObject.name); //que la bala colisione con el Enemigo
        Debug.Log("otro");

        if(otro.gameObject.name == "bala(Clone)"){  //me destruye con la bala
            Destroy(this.gameObject);
        }

        if(otro.gameObject.name == "Personaje)"){
            Debug.Log("Has muerto!");
            principalScript.vidas -=1;
        }
    }
    }

    

}
