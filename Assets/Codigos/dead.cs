using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dead : MonoBehaviour
{


    public GameObject personaje;

    GameObject gestorSonido;
    AudioClip sonidoMuerte;

    // Start is called before the first frame update
    void Start()
    {

        personaje = GameObject.Find("Personaje");
        gestorSonido = GameObject.Find("AudioManager");
        sonidoMuerte = gestorSonido.GetComponent<audioManager>().sonidoMuerte;


    }

    // Update is called once per frame
    void Update()
    {
        
    }



    void OnTriggerEnter2D(Collider2D otro){
        Debug.Log("Has muerto!");
        principalScript.vidas = -1; // MOISÉS  --;
        personaje.transform.position = new Vector3(-1.3f,3.4f,0);

        personaje.GetComponent<AudioSource>().PlayOneShot(sonidoMuerte);
        gestorSonido.


        //gestorSonido. 
    }




}
