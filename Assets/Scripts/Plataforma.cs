using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plataforma : MonoBehaviour
{
    public float largoPlataforma = 10f;
    private Transform jugador;

    void Start()
    {
        jugador = GameObject.FindWithTag("Player").transform;
    }

    void Update()
    {
        if (jugador.position.z > transform.position.z + largoPlataforma)
        {
            MoverAlFinal();
        }
    }

    void MoverAlFinal()
    {
        Plataforma[] todas = FindObjectsOfType<Plataforma>();
        float maxZ = 0;
        foreach (Plataforma p in todas)
        {
            if (p.transform.position.z > maxZ)
                maxZ = p.transform.position.z;
        }
        transform.position = new Vector3(0, transform.position.y, maxZ + largoPlataforma);
    }
}
