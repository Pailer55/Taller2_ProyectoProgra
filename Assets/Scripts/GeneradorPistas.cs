using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneradorPistas : MonoBehaviour
{
    // Start is called before the first frame update
   public GameObject Plane;

    public int cantidadPlataformas = 10;
    public float largoPlatforma = 10f;

    private GameObject[] plataformas;

    void Start()
    {
        plataformas = new GameObject[cantidadPlataformas];
        for (int i = 0; i < cantidadPlataformas; i++)
        {
            plataformas[i] = Instantiate(Plane, new Vector3(0, 0, i * largoPlatforma), Quaternion.identity);
        }
    }
}
