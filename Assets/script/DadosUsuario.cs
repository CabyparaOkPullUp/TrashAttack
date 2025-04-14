using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DadosUsuario : MonoBehaviour
{
    public string nomePersonagem {get;set;}
   
    public static DadosUsuario Instance{get;set;}

    void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void personagemEscolhido(string nomePersonagem)
    {
        this.nomePersonagem=nomePersonagem;

    }
}
