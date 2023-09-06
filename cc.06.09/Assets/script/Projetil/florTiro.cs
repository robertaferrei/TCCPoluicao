using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class florTiro : MonoBehaviour
{
   
    public float velocidadeTiro;
    public Transform  sentidoTiro;
    public int direcao;

    private Toch _receberObjeto;



    void Start()
    {

        _receberObjeto = FindAnyObjectByType(typeof(Toch)) as Toch;

    }

   void Update()
    {

        if( _receberObjeto.valorDirecao > 0)
        {
            direcao = 1;

            
            

           
        }
        if (_receberObjeto.valorDirecao < 0 )
        {
            direcao = -1;

        

        }

        transform.Translate(new Vector2(1, 0) * velocidadeTiro * direcao * Time.deltaTime);



    }

}
