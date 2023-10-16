using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class botoesIniciar : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] private GameObject painelOpcoes;

    [SerializeField] private GameObject painelInstrucoes;

    [SerializeField] private GameObject painelGameOver;

    public GameObject volume;


    public Slider slider;

    public AudioSource audioSom;

    private void Start()
    {
        painelGameOver.SetActive(false);
        painelOpcoes.SetActive(false);
        painelInstrucoes.SetActive(false);
    }

    private void Update()
    {
        audioSom.volume = slider.GetComponent<Slider>().value;
    }

    public void jogar()
    {
        SceneManager.LoadScene("MenuFases");
    }

    public void opcoes()
    {
        painelOpcoes.SetActive(true);
    }

    public void voltar()
    {
        painelOpcoes.SetActive(false);
    }

    public void instrucoes()
    {
        painelInstrucoes.SetActive(true);
    }

    public void voltarInstrucoes()
    {
        painelInstrucoes.SetActive(false);
    }

    public void Menu()
    {
        SceneManager.LoadScene("Menu Principal");
    }

    public void SairJogo()
    {
        Application.Quit();
    }

}
