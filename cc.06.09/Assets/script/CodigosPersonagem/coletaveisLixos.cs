using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class coletaveisLixos : MonoBehaviour
{
    public int contarColetaveis;
    public TextMeshProUGUI txtColetaveis;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == ("ColetarIntes"))
        {
            
            contarColetaveis++;
            Destroy(collision.gameObject);

            txtColetaveis.text = contarColetaveis.ToString();
        }  
    }
    
}

