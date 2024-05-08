using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Victory : MonoBehaviour
{
    public int LixoNecessario = 10;
    public Text VitoriaTexto;
    public ColetaLixo coletalixo;
    public bool fimDeJogoVitoria = false;


    void Update()
    {
        if (coletalixo.lixoColetado >= LixoNecessario)
        {
            fimDeJogoVitoria = true;
            VitoriaTexto.text = "VOCÊ VENCEU";
        }
    }
}
