using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class principalScript : MonoBehaviour
{
    public static int vidas = 3;
    public static int score = 0;

    public static int enemigos = 10;
    /////public GUISkin miSkin;

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
        OnGUI.Label(new Rect(20,20,150,80),"Vida: "+vidas.ToString);
        OnGUI.Label(new Rect(20,20,150,80),"Score: "+score.ToString);
        OnGUI.Label(new Rect(20,20,150,80),"Enemigos: "+enemigos.ToString);


    }
*/




