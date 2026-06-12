using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoPersonaje : MonoBehaviour
{
    
    public float velocidadLateral = 5f;
    public float velocidadAdelante = 8f;
    public float fuerzaSalto = 5f;
    public bool estaEnSuelo = true;
    public Transform limiteIzq;
    public Transform limiteDer;

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
            estaEnSuelo = false;
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

          Vector3 pos = transform.position;
    float clampedX = Mathf.Clamp(pos.x, limiteIzq.position.x, limiteDer.position.x);

    // Si toco el limite, anula la velocidad en X
    if (pos.x != clampedX)
    {
        rb.velocity = new Vector3(0, rb.velocity.y, rb.velocity.z);
    }

    pos.x = clampedX;
    transform.position = pos;
    }
}
