using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inimigo1 : MonoBehaviour
{

    public float StoppingDistance;
    public float Speed;
    private Transform Target;
    public float distancia;
   
    // Start is called before the first frame update
    void Start()
    {

        
        Target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {


        distancia = Vector2.Distance(transform.position, Target.position);

        if(distancia < 9)
        {
            Speed = 2;
        }else
        {
            Speed = 0;
        }
        if (distancia < StoppingDistance) 
        {
            Speed = 0; 
        }

        transform.position = Vector2.MoveTowards(transform.position, Target.position, Speed * Time.deltaTime);

    }


    void OnCollisionEnter2D(Collision2D collisior)


    {

        if (collisior.gameObject.tag == "inimigo")
        {
            Destroy(gameObject);
        }


    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if(collision.gameObject.tag == "florTiro")
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }


}
