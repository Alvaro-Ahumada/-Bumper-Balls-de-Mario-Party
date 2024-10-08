using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;
    public float maxVelocity = 5f;
    private Rigidbody rb;

    public int playerNumber;
    public float rotationSpeed = 100f; // Nueva variable para controlar la velocidad de rotación

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        float moveHorizontal = 0f;
        float moveVertical = 0f;

        // Movimiento para el Jugador 1 (Flechas)
        if (playerNumber == 1)
        {
            moveHorizontal = Input.GetAxis("Horizontal");
            moveVertical = Input.GetAxis("Vertical");
        }

        // Movimiento para el Jugador 2 (WASD)
        if (playerNumber == 2)
        {
            moveHorizontal = Input.GetAxis("Horizontal_P2");
            moveVertical = Input.GetAxis("Vertical_P2");
        }

        // Movimiento para el Jugador 3 (IJKL)
        if (playerNumber == 3)
        {
            if (Input.GetKey(KeyCode.I)) moveVertical = 1f;
            if (Input.GetKey(KeyCode.K)) moveVertical = -1f;
            if (Input.GetKey(KeyCode.J)) moveHorizontal = -1f;
            if (Input.GetKey(KeyCode.L)) moveHorizontal = 1f;
        }

        // Movimiento para el Jugador 4 (TFGH)
        if (playerNumber == 4)
        {
            if (Input.GetKey(KeyCode.T)) moveVertical = 1f;
            if (Input.GetKey(KeyCode.G)) moveVertical = -1f;
            if (Input.GetKey(KeyCode.F)) moveHorizontal = -1f;
            if (Input.GetKey(KeyCode.H)) moveHorizontal = 1f;
        }

        // Movimiento final de la esfera
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        // Limitar la velocidad máxima de las esferas
        if (rb.velocity.magnitude < maxVelocity)
        {
            rb.AddForce(movement * speed);
        }

        // Agregar rotación a la esfera solo hacia adelante
        if (movement != Vector3.zero)
        {
            // Rotar en la dirección de movimiento sobre el eje X
            float rotationAmount = movement.magnitude * rotationSpeed * Time.deltaTime;
            transform.Rotate(rotationAmount, 0, 0);
        }
    }
}






