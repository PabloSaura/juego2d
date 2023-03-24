using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bala : MonoBehaviour
{

    public float velocidad = 3.0f;
    

    // Start is called before the first frame update
    void Start()
    {
    //derecha
     if(Movimiento.direccionBala == false){
            velocidad = 3.0f;
        }else{
           velocidad = -3.0f;
        }
    }
    
    // Update is called once per frame
    void Update()
    {
        transform.Translate(velocidad*Time.deltaTime,0,0);

        if(transform.position.x >= 100 || transform.position.x >= -100){

            Destroy(this.gameObject);
        }



    }
}
