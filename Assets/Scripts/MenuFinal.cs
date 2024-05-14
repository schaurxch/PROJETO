using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuFinal : MonoBehaviour
{

    public void ReiniciarJogo()
    {
        SceneManager.LoadScene(0);
    }
    public void SairDoJogo()
    {
        Application.Quit();
    }
}
