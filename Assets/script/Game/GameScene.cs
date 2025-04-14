using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameScene : MonoBehaviour
{
   public GameObject[] personagemPrefbs;
    void Start()
    {
        string personagem=DadosUsuario.Instance.nomePersonagem;
    }


}
