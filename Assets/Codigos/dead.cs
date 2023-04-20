using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dead : MonoBehaviour
{


    public GameObject personaje;

    GameObject gestorSonido;
    AudioClip sonidoMuerte;
    //private static int contadorTrigger; /// 37

    // Start is called before the first frame update
    void Start()
    {
        //contadorTrigger;  /// 37
        personaje = GameObject.Find("Personaje");
        gestorSonido = GameObject.Find("AudioManager");
        sonidoMuerte = gestorSonido.GetComponent<audioManager>().sonidoMuerte;


    }

    // Update is called once per frame
    void Update()
    {
        
    }



    void OnTriggerEnter2D(Collider2D otro){
        //if(contadorTrigger <= 0){ ///37 
            //añadir efecto
            //contadorTrigger++; //37
        //}else if(contadorTrigger >= 1){ ///37
        //Debug.Log("Has muerto!");
        principalScript.vidas--; // MARIANO: = -1;
        personaje.transform.position = new Vector3(-1.3f,3.4f,0);
        personaje.GetComponent<AudioSource>().PlayOneShot(sonidoMuerte);
        //contadorTrigger = 0; //37
        }

        //gestorSonido.GetComponent<audioManager>().sonidoMuerte; /// 37
    

    //void OnTriggerExit2D(){ /// 37
        //contadorTrigger--;
    //} //37




}
