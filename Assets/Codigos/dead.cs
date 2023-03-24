using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dead : MonoBehaviour
{


    GameObject personaje;


    // Start is called before the first frame update
    void Start()
    {

        personaje = GameObject.Find("Personaje");


    }

    // Update is called once per frame
    void Update()
    {
        
    }



    void OnTriggerEnter2D(Collider2D otro){
        Debug.Log("Has muerto!");
        principalScript.vidas = principalScript.vidas -1;
        personaje.transform.position = new Vector3(-1.3f,3.4f,0);

    }




}
