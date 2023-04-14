using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;


public class audioManager : MonoBehaviour
{

    public AudioClip bandaSonora;
    public AudioClip clickMenu;
    public AudioClip lanzaBola;
    public AudioClip sonidoMuerte;
    public AudioClip sonidoGoal;


    AudioSource hiloMusical;
    public static GameObject scriptDuplicado;

    void Awake(){
        DontDestroyOnLoad(this.gameObject);

        //si este objeto existe, se destruye!
        if(scriptDuplicado == null){
            scriptDuplicado = this.gameObject;
        }
        else{
            Destroy(this.gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        hiloMusical = GetComponent<AudioSource>();
        hiloMusical.clip = bandaSonora;
        hiloMusical.loop = true;
        hiloMusical.Play();
    }
//
    // Update is called once per frame
    void Update()
    {
        Scene escenaActual  = SceneManager.GetActiveScene();

        // que suene algo en funcion de la escena

        if(escenaActual.name == "Start"){
            hiloMusical.pitch = 0.5f;
            //que suene la musica de comienzo!
        }


        //Debug.Log("escenaActual.name");
        if(escenaActual.name == "Nivel1"){
            hiloMusical.pitch = 1f;
            //que suene la musica de comienzo!
        }
    }


    public void clicBoton(){
        //que suene el sonido del boton
        hiloMusical.PlayOneShot(clickMenu);
    }

    public void sonidoDead(){
        hiloMusical.PlayOneShot(sonidoMuerte);
    }
    public void sonidoGoals(){
        hiloMusical.PlayOneShot(sonidoGoal);
    }


}
