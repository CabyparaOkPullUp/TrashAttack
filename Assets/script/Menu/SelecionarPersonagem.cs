using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SelecionarPersonagem : MonoBehaviour
{
    public string[] nomePersonagem;
    public Sprite[] spritesPersonagem;
    public Image personagem;
    int indice=0;

    // Start is called before the first frame update
    void carregarImagem()
    {
        personagem.sprite=spritesPersonagem[indice];
    }
    void Start()
    {
        indice = 0;
        carregarImagem();
    }
    public void proximo()
    {
        indice++;
        if(indice >= nomePersonagem.Length)
        {
            indice=0;
        }
        carregarImagem();
    }
    public void Anterior()
    {
        indice--;
        if(indice < 0)
        {
            indice=nomePersonagem.Length -1;
        }
        carregarImagem();
    }
    // Update is called once per frame
    public void escolherPersonagem()
    {
       DadosUsuario.Instance.personagemEscolhido(nomePersonagem[indice]);
       SceneManager.LoadScene("Game");
    }
}

