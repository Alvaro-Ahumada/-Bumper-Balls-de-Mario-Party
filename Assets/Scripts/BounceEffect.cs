using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BounceEffect : MonoBehaviour
{
    public float bounceForce = 10f; // Fuerza de rebote
    public GameObject humoPrefab; // Prefab del sistema de part�culas
    private AudioSource audioSource; // Componente de AudioSource

    private void Start()
    {
        // Obtener el componente AudioSource
        audioSource = GetComponent<AudioSource>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        // Verificar si la colisi�n es con otra esfera
        if (collision.gameObject.CompareTag("Ball"))
        {
            // Obtener el Rigidbody de la esfera
            Rigidbody rb = GetComponent<Rigidbody>();

            // Calcular la direcci�n del rebote
            Vector3 bounceDirection = collision.contacts[0].normal;

            // Aplicar una fuerza de rebote
            rb.AddForce(bounceDirection * bounceForce, ForceMode.Impulse);

            // Calcular la posici�n media entre las dos esferas
            Vector3 positionBetween = (transform.position + collision.transform.position) / 2;

            // Instanciar el sistema de part�culas de humo en la posici�n media
            GameObject humo = Instantiate(humoPrefab, positionBetween, Quaternion.identity);

            // Rotar el prefab de humo para que emita hacia arriba
            humo.transform.rotation = Quaternion.Euler(90, 0, 0); // Ajusta la rotaci�n seg�n sea necesario

            Destroy(humo, 2f); // Destruir el efecto de humo despu�s de 2 segundos

            // Reproducir el efecto de sonido
            if (audioSource != null)
            {
                audioSource.Play(); // Reproduce el sonido
            }
        }
    }
}





