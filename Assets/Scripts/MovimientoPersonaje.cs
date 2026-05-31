using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoPersonaje : MonoBehaviour
{
    [Header("Movimiento")]
    public float velocidadLateral = 5f;
    public float velocidadAdelante = 5f;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        MoverLateral();
    }

    void MoverLateral()
    {
         if (Input.GetKey(KeyCode.A))
        {
        rb.velocity = new Vector3(-velocidadLateral, rb.velocity.y, velocidadAdelante);
        }
        else if (Input.GetKey(KeyCode.D))
        {
        rb.velocity = new Vector3(velocidadLateral, rb.velocity.y, velocidadAdelante);
        }
        else
        {
        // Si no presiona nada, detiene el movimiento lateral
        rb.velocity = new Vector3(0, rb.velocity.y, velocidadAdelante);
        }
    }
}
