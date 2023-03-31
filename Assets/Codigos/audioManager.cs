using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class audioManager : MonoBehaviour
{

    public AudioClip bandaSonora;
    public AudioClip clickMenu;
    public AudioClip lanzaBola;
    public AudioClip lanzaBola;
    AudioSource hiloMusical;
    AudioClip sonidoMuerte;
    public AudioClip sonidoGoal;
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
        hiloMusical.clip = bandaSonora();
        hiloMusical.loop = true;
        hiloMusical.loop = true;
        hiloMusical.Play() = true;
    }

    // Update is called once per frame
    void Update()
    {
        // que suene algo en funcion de la escena
        Scene escenaActual.name
        switch(escenaActual.name=="Start)"){
            //que suene la musica de comienzo!
        }

        Scene esceneActual = SceneManager.GetActiveScene();

        //Debug.Log("escenaActual.name");
        if(escenaActual.name=="Nivel1"){
        hiloMusicalpitch = 1f;
            //que suene la musica de comienzo!
        }
    public void clicBoton(){
        //que suene el sonido del boton
        hiloMusical.PlayOneShot(clickMenu);
    
    public void sonidoDead(){
        hiloMusical.PlayOneShot(sonidoMuerte);
        }
    public void sonidoGoals(){
        hiloMusical.PlayOneShot(sonidoGoal);

        }


    }
    }
}
