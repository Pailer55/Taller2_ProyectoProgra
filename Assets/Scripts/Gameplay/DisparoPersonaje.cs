using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisparoPersonaje : MonoBehaviour
{



    public AudioClip fireSound;
    public GameObject bulletPrefab;
    private float cooldown = 0f;
    public float fireRate = 0.5f;

    public float velocidadProyectil = 0.5f;
    // Start is called before the first frame update

    private Rigidbody rb;

    void Start()
    {
        

        rb = GetComponent<Rigidbody>();
    }

    // Cuando el cooldown llega a 0, al apretar las teclas indicadas se realiza el disparo de proyectil
    void Update()
    {
         cooldown -= Time.deltaTime;

    if (cooldown <= 0f)
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            Shoot();
            cooldown = fireRate;  
        }

    } 

}
void Shoot()
{

    float distanceInFront = 0.5f; 
    float heightOffset = 0.75f;    


    Vector3 initialPosition = transform.position + (transform.forward * distanceInFront) + (Vector3.up * heightOffset);


    GameObject bullet = Instantiate(bulletPrefab, initialPosition, transform.rotation);
    Rigidbody rbBullet = bullet.GetComponent<Rigidbody>();


    Physics.IgnoreCollision(bullet.GetComponent<Collider>(), GetComponent<Collider>());


    MovimientoPersonaje movimiento = GetComponent<MovimientoPersonaje>();
    float actualForwardSpeed = (movimiento != null) ? movimiento.velocidadAdelante : 0f;
    float finalBulletSpeed = actualForwardSpeed + velocidadProyectil;

    rbBullet.velocity = new Vector3(rb.velocity.x, rb.velocity.y, finalBulletSpeed);

    AudioSource.PlayClipAtPoint(fireSound, transform.position, 0.75f);
}




}
