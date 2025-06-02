using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlataformaController : MonoBehaviour
{
    
    public Animator Animator;


    public void OnTriggerEnter(Collider col)
    {
        Debug.Log("TRIGGER ATIVADO: " + col.gameObject.tag);

        if(col.gameObject.tag == "Player")
        {
            Debug.Log("Player em cima da plataforma.");
        }
    }
}
