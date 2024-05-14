using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuInicial : MonoBehaviour
{
  public void ComecarJogo()
    {
        SceneManager.LoadScene(1);
    }
    
        
    

  public void AcabarJogo()
    {
        Application.Quit();
    }
    
       
    
}
