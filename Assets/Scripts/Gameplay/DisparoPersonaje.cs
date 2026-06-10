using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisparoPersonaje : MonoBehaviour
{


    public GameObject bulletPrefab;
     private float cooldown = 0f;
    public float fireRate = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Cuando el cooldown llega a 0, al apretar las teclas indicadas se realiza el disparo de proyectil
    void Update()
    {
         cooldown -= Time.deltaTime;

    if (cooldown <= 0f)
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            Shoot(Vector2.up);
            cooldown = fireRate;  
        }

    } 

}
void Shoot(Vector2 direction)
    {
        Vector3 initialPosition = transform.position + (Vector3)direction * 0.5f;

        GameObject bullet = Instantiate(bulletPrefab, initialPosition, Quaternion.identity);

        Rigidbody rbBullet = bullet.GetComponent<Rigidbody>();

        rbBullet.velocity = direction * 6.5f;

        Physics.IgnoreCollision(bullet.GetComponent<Collider>(),GetComponent<Collider>());
    }
}
