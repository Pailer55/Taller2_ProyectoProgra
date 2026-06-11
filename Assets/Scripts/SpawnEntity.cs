using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEntity : MonoBehaviour
{
    public GameObject[] prefabsAutos;
    public GameObject prefabZombie;
    public float carrilIzquierdo = -2f;
    public float carrilCentro = 0f;
    public float carrilDerecho = 2f;

    void Start()
    {
        Spawnear();
    }

    void Spawnear()
    {
        float[] carriles = { carrilIzquierdo, carrilCentro, carrilDerecho };
        float carrilElegido = carriles[Random.Range(0, carriles.Length)];

        // 0 = auto, 1 = zombie
        int tipo = Random.Range(0, 2);
        GameObject prefabElegido;

        if (tipo == 0)
            prefabElegido = prefabsAutos[Random.Range(0, prefabsAutos.Length)];
        else
            prefabElegido = prefabZombie;

        GameObject obj = Instantiate(prefabElegido, new Vector3(carrilElegido, 0.2f, transform.position.z), Quaternion.Euler(0, 180, 0));
        obj.transform.SetParent(transform);
    }
}
