using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootBullett : MonoBehaviour
{

    public GameObject bulletPrefab; // Prefab della pallottola da sparare
    public Transform spawnPoint;    // Punto di spawn della pallottola
    public float bulletSpeed = 10f; // Velocità della pallottola

    void Update()
    {
        // Se viene premuto il tasto spazio
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Sparare la pallottola
            Shoot();
        }
    }

    void Shoot()
    {
        // Creare una nuova istanza della pallottola al punto di spawn
        GameObject bullet = Instantiate(bulletPrefab, spawnPoint.position, spawnPoint.rotation);

        // Ottenere il Rigidbody della pallottola (se presente)
        Rigidbody rb = bullet.GetComponent<Rigidbody>();

        // Applicare la velocità alla pallottola
        if (rb != null)
        {
            rb.velocity = spawnPoint.forward * bulletSpeed;
        }
        else
        {
            Debug.LogWarning("Il prefab della pallottola non contiene un componente Rigidbody.");
        }
    }
}
