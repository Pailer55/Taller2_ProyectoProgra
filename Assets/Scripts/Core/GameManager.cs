using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{

    public TextMeshProUGUI textPuntaje;
    public TextMeshProUGUI textMonedas;
    //Contadores
    public int monedas = 0;
    public float puntuacion = 00000;

    private Transform jugador;
    private float posicionInicialZ;


    public static GameManager Instance
    {
        get; 
        private set;
    }

    public void Start()
    {
        jugador = GameObject.FindWithTag("Player").transform;
        posicionInicialZ = jugador.position.z;
    }

    void Update()
    {
        if (jugador == null) return;
        AgregarPuntuacion();
        ActualizarUI();
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

    public void AgregarPuntuacion()
    {
        puntuacion = (jugador.position.z - posicionInicialZ) * 5f;
    }

     void ActualizarUI()
    {
        textPuntaje.text = "PUNTAJE: " + Mathf.FloorToInt(puntuacion).ToString("D8");
        textMonedas.text = "MONEDAS: " + monedas.ToString("D2");
    }

}
