using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menuprincipal : MonoBehaviour
{
    [SerializeField] private string nomeDoLeveDeJogo;
    [SerializeField] private GameObject painelMenuInicial;
    [SerializeField] private GameObject painelOpcoes;

     public void Jogar()
    {
        SceneManager.LoadScene("31.05tcc"); 
    }
    public void AbrirOpcoes()
    {
        painelMenuInicial.SetActive(false);
        painelOpcoes.SetActive(true);
    }
    public void FecharOpcoes()
    {
        painelOpcoes.SetActive(false);
        painelMenuInicial.SetActive(true);
    }

    
    public void SairJogo()
    {
        Debug.Log("sair do jogo");
        Application.Quit();
    }







   









    void Start()
    {
        
    }

 
    void Update()
    {
        
    }
}
