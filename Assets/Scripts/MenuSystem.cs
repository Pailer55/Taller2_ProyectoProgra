using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuSystem : MonoBehaviour
{
     public void jugar()
    {
        SceneManager.LoadScene("SampleScene");
    }
    public void salir()
    {
        Debug.Log("salendo del juego....");
        Application.Quit();
    }
}
