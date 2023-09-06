using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerTiro : MonoBehaviour
{
    public GameObject tiro;
    public Transform posicaoJogo;



    void Start()
    {
        


    }

    // Update is called once per frame
    void Update()
    {
        


    }

    public void Atirar()
    {

        GameObject tempo = Instantiate(tiro, posicaoJogo.position, Quaternion.identity);

    }

}
