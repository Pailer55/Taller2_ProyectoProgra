using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Vehiculo : MonoBehaviour



{

    public string sceneName;

    public AudioClip hitSound;
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            SceneManager.LoadScene(sceneName);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Bala"))
        {
            AudioSource.PlayClipAtPoint(hitSound, transform.position, 0.25f);
            Destroy(gameObject);
        }
    }
}
