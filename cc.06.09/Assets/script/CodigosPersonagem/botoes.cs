using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class botoes : MonoBehaviour
{


    public GameObject painelFechar;


    public void Start()
    {
        painelFechar.SetActive(false);
    }

    public void Opcoes()
    {
        SceneManager.LoadScene("New Scene 1");
    }

    public void fecharPainel()
    {
        painelFechar.SetActive(false);
    }

  
}
