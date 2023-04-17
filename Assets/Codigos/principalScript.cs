using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class principalScript : MonoBehaviour
{
    public static int vidas = 3;
    public static int score = 0;
    public static int enemigos = 0;
    /////public GUISkin miSkin; /////public
    /////public Texture2D logoJuego; /////public
    /////int Anchopantalla; /////public

    GameObject player;

    void Awake(){
    
    }

    // Start is called before the first frame update
    void Start(){
        player = GameObject.FindGameObjectWithTag("Player"); //encuentra el personaje con el TAG PLAYER
    }

    ///Update is called once per frame
    void Update()
    {
        ///Anchopantalla = Screen.width/2;//////MOISES COMENTARLO

        //Debug.Log("Vidas:" + vidas);
        //Debug.Log("Score:" + score);
        //Debug.Log("Score:" + enemigos + enemigos);
        

        if(Input.GetKeyDown(KeyCode.Escape)){
            SceneManager.LoadScene("Start");
        }   
    }
}
///////MOISÉS GUI 21
/*
    void OnGUI(){
        GUI.skin=miSkin;
        GUI.Label(new Rect(20,20,150,80),"Vida: "+vidas.ToString(),"estiloScore");
        GUI.Label(new Rect(20,20,150,80),"Score: "+score.ToString);
        GUI.Label(new Rect(20,20,150,80),"Enemigos: "+enemigos.ToString);
        GUI.Label(new Rect(Anchopantalla,-100,20,200,100),"Nombre Juego", "estiloTitulo");
        ///imagen
        GUI.DrawTexture(new Rect(Screen.width-80,20,80),logoJuego);


    }
*/




