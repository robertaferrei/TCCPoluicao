using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class receberObjeto : MonoBehaviour
{

    private florTiro _florTiro;

    public Transform player;
    void Start()
    {
       player = this.gameObject.transform;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
