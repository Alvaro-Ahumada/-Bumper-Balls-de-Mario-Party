using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleMovement : MonoBehaviour
{
    public float speed = 0.1f;  // Controla la velocidad del movimiento.

    void Update()
    {
        // Mueve el objeto continuamente hacia la izquierda en el eje X
        transform.Translate(Vector3.left * speed * Time.deltaTime);
    }
}