using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Victory : MonoBehaviour
{
    public int LixoNecessario = 10;
    public ColetaLixo coletalixo;

    void Update()
    {
        if (coletalixo.lixoColetado >= LixoNecessario)
        {
            SceneManager.LoadScene(2);
        }
    }
}
