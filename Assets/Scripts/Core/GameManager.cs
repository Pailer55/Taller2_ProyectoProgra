using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    //Contadores
    public int monedas = 0;

    public int puntuacion = 00000;


    public static GameManager Instance
    {
        get; 
        private set;
    }

    void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;

        DontDestroyOnLoad(gameObject);
    }
    
    public void AgregarMonedas(int cantidadMonedas)
    {
        monedas += cantidadMonedas;
    }

    public void AgregarPuntuacion(int cantidadPuntuacion)
    {
        puntuacion += cantidadPuntuacion;
    }
}
