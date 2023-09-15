using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerTiro : MonoBehaviour
{
    public GameObject tiro;
    public Transform posicaoJogo;
    public GameObject playerFilho;

    private 


    void Start()
    {

        

    }

    // Update is called once per frame
    void Update()
    {
        


    }

    public void Atirar()
    {
        
        if(playerFilho.gameObject.transform.localScale.x > 0)
        {

            GameObject tempo = Instantiate(tiro, posicaoJogo.position, Quaternion.identity);
            tempo.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(10, 0);

        }
        else if(playerFilho.gameObject.transform.localScale.x < 0)
        {
           GameObject tempo = Instantiate(tiro, posicaoJogo.position, Quaternion.identity);

           tempo.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(-10, 0);
        }


       


    }

}
