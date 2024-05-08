using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuFImDeJogo : MonoBehaviour
{
    public static bool jogoFim = false;
    public GameObject menuFimDeJogoUI;
    public Victory victory;
    public Text fimDeJogoText;

    private void Start()
    {
        menuFimDeJogoUI.SetActive(false); 
    }

    private void Update()
    {
        if(victory.fimDeJogoVitoria == true)
        {
            Cursor.lockState = CursorLockMode.None; Cursor.visible = true;
            Time.timeScale = 0f;
            menuFimDeJogoUI.SetActive(true);
        }
    }
}
