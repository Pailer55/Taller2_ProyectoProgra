using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeguimientoCamara : MonoBehaviour
{
   [Header("Objetivo")]
    public Transform jugador;

    [Header("Rotacion")]
    public float inclinacion = 25f;

    [Header("Offset")]
    public float offsetY = 4f;   // altura de la camara
    public float offsetZ = -3.5f;  // distancia detras del jugador

    void LateUpdate()
    {
        SeguirJugador();
    }

    void SeguirJugador()
    {
        transform.position = new Vector3(
            transform.position.x,        // X fijo, no se mueve lateral
            jugador.position.y + offsetY, // Y sigue la altura del jugador
            jugador.position.z + offsetZ  // Z sigue al jugador hacia adelante
        );
        transform.rotation = Quaternion.Euler(inclinacion, 0, 0);
    }

}
