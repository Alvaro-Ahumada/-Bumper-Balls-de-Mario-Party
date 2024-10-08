using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class BallController : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float rotationSpeed = 100f;
    public Transform character;

    private Rigidbody rb;
    public Vector2 movementInput;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        //Ball Movement
        Vector3 movement = new Vector3(movementInput.x, 0, movementInput.y) * moveSpeed;
        rb.AddForce(movement);

        if (movement != Vector3.zero)
        {
            Vector3 rotationDirection = new Vector3(movementInput.y, 0, -movementInput.x);
            rb.AddTorque(rotationDirection * rotationSpeed);
        }

        //Character + Ball
        if (character != null)
        {
            character.position = transform.position + new Vector3(0, 0.7f, 0); // Ajustar la altura

            if (movement != Vector3.zero)
            {
                Quaternion lookRotation = Quaternion.LookRotation(movement);
                character.rotation = Quaternion.Slerp(character.rotation, lookRotation, Time.deltaTime * rotationSpeed);
            }
        }
    }
    
    //Input Action Controllers
    public void OnMove(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            movementInput = context.ReadValue<Vector2>();
        }
        else if (context.canceled)
        {
            movementInput = Vector2.zero;
        }
    }

}

