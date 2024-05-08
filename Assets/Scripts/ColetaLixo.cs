using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColetaLixo : MonoBehaviour
{
    public int lixoColetado = 0;
    public Text lixoTexto;
    public GameObject lixoPrefab;


    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Trash")
        {
            lixoColetado++;
            lixoTexto.text = "PONTOS: " + lixoColetado;
            Debug.Log(lixoColetado);
            Destroy(other.gameObject);
        }
    }
}
