using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class florTiro : MonoBehaviour
{
   
    public float velocidadeTiro;
    
     


    void Start()
    {

       

    }

   void Update()
    {

    
        transform.Translate(new Vector2(1, 0) * velocidadeTiro *  Time.deltaTime);



    }



}
