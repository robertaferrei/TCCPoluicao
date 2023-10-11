using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MovimentoHorizontal : MonoBehaviour
{
    public int qntVidaAtual, qntVida;
    public int coins;

    public float velocidade;
    public float jumpForce;
    public float movimentoHorizontal, movimentoVertical;
    public float speed = defaultSpeed;
    public float alturaDoPulo;
    public float raioDeVerificacao;
    public float tempo;
    public float forcaTiro;
    public float velocidadeTiro;
    public float forcaPulo;
    const float lifeTime = 2;
    public const float runningSpeed = 9, defaultSpeed = 6;

    public bool isJumping;
    public bool estaNoChao;
    private bool abaixar;
    private bool ativarTempo;

    public GameObject projetil;
    public GameObject bullet;
    public GameObject Bandeira;
    public GameObject posicaoTiro;
    public GameObject painelInformacao;
    public GameObject painePorcao;
    public GameObject painelGameOver;
    private Rigidbody2D rB;
    public Transform posicaoProjetil;
    public Transform verrificadorDeChao;
    public Animator anim;
    public SpriteRenderer spRender;
    public Image vida1, vida2, vida3, vida4, vida5;
    public TextMeshProUGUI textoMoedas;
    public TextMeshProUGUI timetext;
    private AudioSource sound;
    public AudioClip somMoeda, somPulo, atirar;
    public Button fechar;
    public LayerMask layerDoChao;

    // Start is called before the first frame update
    void Start()
    {
        painePorcao.SetActive(false);

        painelGameOver.SetActive(false);

        rB = GetComponent<Rigidbody2D>();
        anim = GetComponentInChildren<Animator>();
        spRender = GetComponentInChildren<SpriteRenderer>();
        qntVidaAtual = 5;
        qntVida = qntVidaAtual;
        sound = GetComponent<AudioSource>();
        fechar.interactable = false;
    }

    // Update is called once per frame
    void Update()
    {
        // Jump();
        Movimento();
        Slide();
        Run();
        // Shoot();
        TempoMoeda();

        if (ativarTempo == true)
        {
            tempo += Time.deltaTime;

        }
        if (tempo >= 10)
        {
            fechar.interactable = true;
;       }
    }

    private void FixedUpdate()
    {
        estaNoChao = Physics2D.OverlapCircle(verrificadorDeChao.position, raioDeVerificacao, layerDoChao);
    }
    //Minhas funções
 
    void Slide()
    {
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            anim.SetTrigger("slide");
        }
        else
        {
            spRender.flipX = false;
        }
    }

   public void Shoot()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
           GameObject temp = Instantiate(projetil);
           temp.transform.position = posicaoTiro.transform.position;
           // temp.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2();
        }
    }

    void Movimento()
    {
        movimentoHorizontal = Input.GetAxisRaw("Horizontal");
        movimentoVertical = Input.GetAxisRaw("Vertical");

        transform.Translate(new Vector3(1 * movimentoHorizontal, 1 * movimentoVertical, 0) * velocidade * Time.deltaTime);
    }   

    void OnCollisionExit2D(Collision2D collisior)
    {
        if (collisior.gameObject.tag == "Chão")
        {
            isJumping = false;
        }
    }

    void Run()
    {
        if (Input.GetKey(KeyCode.K))
        {
            speed = runningSpeed;
        }
        else if (speed != defaultSpeed)
        {
            speed = defaultSpeed;
        }
    }

    public void Pular()
    {
        if (estaNoChao == true)
        {
            rB.AddForce(Vector2.up * forcaPulo);
            sound.PlayOneShot(somPulo);
        }
    }

    public void TempoMoeda()
    {
        tempo += Time.deltaTime;
        timetext.text = tempo.ToString("0");
        textoMoedas.text = coins.ToString();
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "inimigo")
        {           
            qntVida -= 1;

            if (qntVida <= 4)
            {
                vida1.enabled = false;
                vida2.enabled = true;
                vida3.enabled = true;
                vida4.enabled = true;
                vida5.enabled = true;
            }

            if (qntVida <= 3)
            {
                vida1.enabled = false;
                vida2.enabled = false;
                vida3.enabled = true;
                vida4.enabled = true;
                vida5.enabled = true;
            }

            if (qntVida <= 2)
            {
                vida1.enabled = false;
                vida2.enabled = false;
                vida3.enabled = false;
                vida4.enabled = true;
                vida5.enabled = true;
            }

            if (qntVida <= 1)
            {
                vida1.enabled = false;
                vida2.enabled = false;
                vida3.enabled = false;
                vida4.enabled = false;
                vida5.enabled = true;
            }

            if (qntVida <= 0)
            {

                painelGameOver.SetActive(true);
                vida1.enabled = false;
                vida2.enabled = false;
                vida3.enabled = false;
                vida4.enabled = false;
                vida5.enabled = false;
                qntVida = 0;
                anim.SetTrigger("morrer");

                movimentoHorizontal = 0;
                movimentoVertical = 0;

                velocidade = 0;

                Destroy(gameObject, 2);
            }
        }

        if (col.gameObject.tag == "coins")
        {
            coins++;
            sound.PlayOneShot(somMoeda);
            Destroy(col.gameObject);
        }
        
        if (col.gameObject.tag == "informacoes")
        {
            Bandeira.SetActive(true);
            ativarTempo = true; 
        }

        if (col.gameObject.tag == "coletarPorcao")
        {
            painePorcao.SetActive(true);          
        }

        if (col.gameObject.tag == "Morrer")
        {
           painelGameOver.SetActive(true);
        }
    }

    public void fecharPainel()
    {
        painelInformacao.SetActive(false);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name.Equals("MacaColetavel"))
        {
            Destroy(collision.gameObject);
        }
    }
} 


