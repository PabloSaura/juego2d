using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arma : MonoBehaviour
{

    GameObject gestorSonido;
    public GameObject bala;

    

    // Start is called before the first frame update
    void Start()
    {
        gestorSonido = GameObject.Find("AudioManager");
        sonidoBola = gestorSonido.GetComponent<audioManager>().lanzaBola;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E) ) {
            this.GetComponentInParent<AudioSource>().PlayOneShot(sonidoBola);
        Instantiate(bala, new Vector3(transform.position.x,transform.position.y,0), Quaternion.identity);
        }







    }
}
