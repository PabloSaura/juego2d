using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scriptStart : MonoBehaviour
{

    public GameObject canvasStart;  /// QUITAR EL COMENTADO !!!

    public GameObject canvasControles;  /// QUITAR EL COMENTADO !!!



    // Start is called before the first frame update
    void Start()
    {
        //canvasStart.SetActive(false);   /// QUITAR EL COMENTADO !!!
        //canvasControles.SetActive(true); /// QUITAR EL COMENTADO !!!
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void EntrarJuego(){
        SceneManager.LoadScene("Nivel1");

    }

    public void EntrarControles(){
        canvasStart.SetActive(false);
        canvasControles.SetActive(true);

    }

    public void VolverStart(){
        canvasStart.SetActive(true);
        canvasControles.SetActive(false);
    }

    public void SairJuego(){
        Application.Quit();

    }

}
