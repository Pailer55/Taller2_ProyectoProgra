using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moneda : MonoBehaviour
{
    public AudioClip collectSound;
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            AudioSource.PlayClipAtPoint(collectSound, transform.position, 0.75f);
            GameManager.Instance.AgregarMonedas(1);
            Destroy(gameObject);
        }
    }
}
