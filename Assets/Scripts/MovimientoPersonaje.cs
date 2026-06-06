using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoPersonaje : MonoBehaviour
{
    [Header("Movimiento")]
    public float velocidadLateral = 5f;
    public float velocidadAdelante = 5f;
    public float fuerzaSalto = 7f;
    private bool estaEnSuelo = true;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        MoverLateral();
        Saltar();
    }

    void Saltar()
{
    if (Input.GetKeyDown(KeyCode.Space) && estaEnSuelo)
    {
        rb.AddForce(Vector3.up * fuerzaSalto, ForceMode.Impulse);
    }
}

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Suelo"))
        {
            estaEnSuelo = true;
        }
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
