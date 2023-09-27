using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Toch : MonoBehaviour
{
    private int auxDirecao;
    private float speed;
    public GameObject player;
    public GameObject playerPai;
    public float forca;
    public int valorDirecao;
    public Animator anim;

    void Start()
    {
        speed = 8f; 
    }

    void Update()
    {       
        if(auxDirecao != 0)
        {
            transform.Translate(speed * Time.deltaTime * auxDirecao, 0, 0);
        }

        if (auxDirecao < 0)
        {
            player.transform.localScale = new Vector3(-1, transform.localScale.y, transform.localScale.z);
            valorDirecao = -1;
           // player.gameObject.GetComponent<SpriteRenderer>().flipX = true;
        }

        if(auxDirecao > 0)
        {
            player.transform.localScale = new Vector3(1, transform.localScale.y, transform.localScale.z);
            valorDirecao = 1;
           // player.gameObject.GetComponent<SpriteRenderer>().flipX = false;
        }

        if(auxDirecao == 0)
        {
            anim.SetInteger("run", 0);
        }

        if(auxDirecao != 0)
        {
            anim.SetInteger("run", 1);
        }
    }

    public void TochHorizontal(int direcao)
    {
        auxDirecao = direcao;        
    }

    public void TouchJump()
    {
        playerPai.gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, forca));
    }
}