using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerTiro : MonoBehaviour
{
    public GameObject tiro;
    public Transform posicaoJogo;
    public GameObject playerFilho;
    private AudioSource audioSource;
    public AudioClip somTiro;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
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

            Destroy(tempo.gameObject, 1f);

            audioSource.PlayOneShot(somTiro);
        }
        else if(playerFilho.gameObject.transform.localScale.x < 0)
        {
           GameObject tempo = Instantiate(tiro, posicaoJogo.position, Quaternion.identity);

           tempo.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(-10, 0);
            audioSource.PlayOneShot(somTiro);
            Destroy(tempo.gameObject, 1f);
        }
    }
}
