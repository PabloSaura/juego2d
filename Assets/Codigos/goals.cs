using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goals : MonoBehaviour
{

    GameObject personaje;
    GameObject gestorSonido;


    // Start is called before the first frame update
    void Start()
    {
       gestorSonido = GameObject.Find("AudioManager");
    }

    // Update is called once per frame
    void Update(){
}
    void OnTriggerEnter2D(){  /// DENTRO DEL PARÉNTESIS ESTABA:   (Collider2D otro)
        principalScript.score += 10;
        Destroy(this.gameObject, 0.5f); ///MOISÉS 14 COMENTARLO
        gestorSonido.GetComponent<audioManager>().sonidoPuntos(); /// 35
       // gestorSonido.GetComponent<sonidoGoals>()
     }

}
