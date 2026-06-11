using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float tiempoVida = 3f; // Bullet destroys itself after 3 seconds if it misses

    void Start()
    {
        // Automatically destroy the bullet after 'tiempoVida' seconds
        Destroy(gameObject, tiempoVida);
    }


// Al colisionar con cualquier objeto, reproduce un audio, una animacion, y se destruye
void OnTriggerEnter(Collider other) {
  
            Destroy(gameObject);     

    }
}